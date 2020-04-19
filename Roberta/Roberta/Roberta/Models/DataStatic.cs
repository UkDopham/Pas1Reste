using System;
using System.Collections.Generic;
using System.Text;


namespace Roberta.Models
{
    public static class DataStatic
    {
        List<Recipe> recipes = new List<Recipe>();
        List<Product> products = Product.GetAllProducts(recipes);

        public static void PeuplementRecettes(){
            
            Recipe tartelleteFruits = new Recipe("Tartelette aux fruits","Belle petite tarte venant des usines tricatel", new DateTime(2020,4,10),@"_tarteAuxFruits.png",3);
            tartelleteFruits.AddProduct("fraise","banane","pate","beurre","oeuf");

            Recipe biscote = new Recipe("Biscote","Un dure mais croustillant", new DateTime(2020,4,18),@"_biscotte.png",5);
            biscote.AddProduct("ble","eau","levure","beurre");

            Recipe cafeGourmant = new Recipe("Cafe gourmant","Un cafe accompagne de petits gateaux", new DateTime(2020,4,18),@"_cafeGourmant.png",1);
            cafeGourmant.AddProduct("ble","eau","levure");

            Recipe chocolat = new Recipe("Chocolat","Chocolat noir 70%", new DateTime(2020,4,17),@"_chocolat.png",2);
            chocolat.AddProduct("cacao","sucre");

            Recipe gateauCitron = new Recipe("Gateau au citron","Un petit gout citrone", new DateTime(2020,4,19),@"_gateauCitron.png",4);
            gateauCitron.AddProduct("citron","beurre","farine","oeuf","sucre");

            Recipe gateauChocolat = new Recipe("Gateau au chocolat","Chocolat et caramel", new DateTime(2020,4,18),@"_gateauChocolat.png",3);
            gateauChocolat.AddProduct("chocolat","beurre","farine","oeuf","sucre");

            Recipe hamburger = new Recipe("Hamburger","Inspirer des grands cuistots americains", new DateTime(2020,4,13),@"_gateauCitron.png",2);
            hamburger.AddProduct("pain","steak","fromage","salade","tomate");

            Recipe macarons = new Recipe("Macarons","Petite gourmandise a couleurs varies", new DateTime(2020,4,19),@"_macarons.png",6);
            macarons.AddProduct("poudre d'amande","sucre","oeuf");

            Recipe pizzaMargarita = new Recipe("Pizza margarita","fromage et tomate", new DateTime(2020,4,12),@"_pizzaMargarita.png",3);
            pizzaMargarita.AddProduct("pate","tomate","fromage");

            Recipe salade = new Recipe("Salade","fromage et tomate", new DateTime(2020,4,11),@"_salade.png",4);
            salade.AddProduct("salade","tomate","fromage");

            Recipe gateauAuFour = new Recipe("Gateau au four","Un gateau simple avec pas beaucoup de gout", new DateTime(2020,4,1),@"_gateauAuFour.png",2);
            gateauAuFour.AddProduct("farine","oeuf","levure","beurre");

            Recipe ramen = new Recipe("Ramen","Bouillon japonais de poissons", new DateTime(2020,4,3),@"_ramen.png",2);
            ramen.AddProduct("pates","poisson","sauce soja");







            recipes.Add(tartelleteFruits,biscote,cafeGourmant,chocolat,gateauCitron,gateauChocolat,hamburger,macarons,pizzaMargarita,salade,gateauAuFour,ramen);
        }



























    }
}
