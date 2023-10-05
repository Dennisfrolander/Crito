<h1 align="center"> Crito kopia | CMS Inlämning </h1>
<h4 align="center">Av Dennis Frölander</h4>

## Datalagring
Du kan spara ner information med hjälp av EFC. Det som skrivs in i subscribe och kontaktformuläret sparas ned i umbracos databas, validering finns även på kontaktformuläret ifall något fel skulle uppstå. Det går inte att subscriba 2 gånger med samma email.



## Sökfunktion
Det finns en sökfunktion på News där användarna kan enkelt söka efter specifika ord eller fraser och få snabba och exakta resultat.

## Hur man startar programmet:

```
    "Login Information":

    "Username": "Dennis@domain.com",
    "Password": "Dennis123!"
  
  ```
  
  ***Se till att du lagt till en connection mellan sqlite och din lokaladatabas som finns i Models > Contexts > Databases (IdentityDatabase / MainDb).***
