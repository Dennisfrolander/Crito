using Crito.Interfaces;
using Crito.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.Views;
using Umbraco.Cms.Web.Website.ActionResults;

namespace Crito.Controllers.Hijacking
{
	public class SearchController : RenderController
	{
        private readonly IPublishedValueFallback _publishedValueFallback;
        private readonly ISearchService _searchService;
        public SearchController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor, IPublishedValueFallback publishedValueFallback, ISearchService searchService) : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            _publishedValueFallback = publishedValueFallback;
            _searchService = searchService;
        }

        public override IActionResult Index()
		{

            // Get the queryString from the request
            string queryString = HttpContext.Request.Query["query"]!;

            // Create the view model and pass it to the view
            SearchViewModel viewModel = new(CurrentPage!, _publishedValueFallback)
            {
                SearchResults = _searchService.SearchContentNames(queryString!),
                HasSearched = !string.IsNullOrEmpty(queryString),
                SearchValue = queryString
            };
            if (queryString != null && queryString.Length > 0)
                return View("~/Views/SearchResults.cshtml", viewModel);
            else return CurrentTemplate(viewModel);

        }
	}
}
