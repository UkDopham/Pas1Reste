using System;
using System.Collections.Generic;
using System.Text;


namespace Roberta.Models
{
    public static class DataStatic
    {
        List<Recipe> recipes = new List<Recipe>();

        public static void PeuplementRecettes(){
            
            Recipe tartelleteFruits = new Recipe("Tartelette aux fruits","Belle petite tarte venant des usines tricatel", new DateTime(2020,4,10),@"tarteAuxFruits.png",3);
            tartelleteFruits.AddProduct("fraise","banane","pate","beurre","oeuf");

            Recipe biscote = new Recipe("Biscote","Un dure mais croustillant", new DateTime(2020,4,18),@"biscotte.png",5);
            biscote.AddProduct("ble","eau","levure","beurre");

            Recipe cafeGourmant = new Recipe("Cafe gourmant","Un cafe accompagne de petits gateaux", new DateTime(2020,4,18),@"cafeGourmant.png",1);
            cafeGourmant.AddProduct("ble","eau","levure");

            Recipe chocolat = new Recipe("Chocolat","Chocolat noir 70%", new DateTime(2020,4,17),@"chocolat.png",2);
            chocolat.AddProduct("cacao","sucre");

            Recipe gateauCitron = new Recipe("Gateau au citron","Un petit gout citrone", new DateTime(2020,4,19),@"gateauCitron.png",4);
            gateauCitron.AddProduct("citron","beurre");

            Recipe hamburger = new Recipe("Hamburger","Inspirer des grands cuistots americains", new DateTime(2020,4,13),@"gateauCitron.png",2);
            hamburger.AddProduct("pain","steak","fromage","salade","tomate");

            Recipe macarons = new Recipe("Macarons","Petite gourmandise a couleurs varies", new DateTime(2020,4,19),@"macarons.png",6);
            macarons.AddProduct("poudre d'amande","sucre","oeuf");








            recipes.Add(tartelleteFruits,biscote,cafeGourmant,chocolat,gateauCitron,hamburger);
        }



























    }
}
