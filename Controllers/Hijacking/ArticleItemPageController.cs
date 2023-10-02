using Crito.Interfaces;
using Crito.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace Crito.Controllers.Hijacking
{
    public class ArticleItemPageController : RenderController
    {
        private readonly IPublishedValueFallback _publishedValueFallback;
        private readonly ISearchService _searchService;
        public ArticleItemPageController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor, IPublishedValueFallback publishedValueFallback, ISearchService searchService) : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            _publishedValueFallback = publishedValueFallback;
            _searchService = searchService;
        }

        public override IActionResult Index()
        {

            string queryString = HttpContext.Request.Query["query"]!;

            SearchViewModel viewModel = new(CurrentPage!, _publishedValueFallback)
            {
                SearchResults = _searchService.SearchContentNames(queryString!),
                HasSearched = !string.IsNullOrEmpty(queryString),
                SearchValue = queryString
            };
            if (queryString != null && queryString.Length > 0)
                return RedirectToAction("Search", viewModel);
            else return CurrentTemplate(CurrentPage);
        }

        [HttpGet]
        [Route("/Search{viewModel.Name}")]
        public IActionResult Search(SearchViewModel viewModel) 
        {
            return View("~/Views/SearchResults.cshtml", viewModel);
        }
    }
}
