<h1 align="center"> Crito kopia | CMS Inlämning </h1>
<h4 align="center">Av Dennis Frölander</h4>


## Hur man startar programmet:
***Ändra connectionstrings i appsettings.json*** 

```"ConnectionStrings": {
    "UmbracoDatabase": "Your connectionstring to database",
    "umbracoDbDSN_ProviderName": "Microsoft.Data.Sqlite"
  }
  ```
  
  ***Se till att du lagt till en connection mellan sqlite och din lokaladatabas som finns i Models > Contexts > Databases (IdentityDatabase / MainDb).***
