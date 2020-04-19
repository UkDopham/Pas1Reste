using System;
using System.Collections.Generic;
using System.Text;


namespace Roberta.Models
{
    public static class DataStatic
    {
        List<Recipe> recipes = new List<Recipe>();

        public static void PeuplementRecettes(){
            
            Recipe tartelleteFruits = new Recipe("Tartelette aux fruits","Belle petite tarte venant des usines tricatel", new DateTime(2020,4,10),@"tarteAuxFruits.jpg",3);
            tartelleteFruits.AddProduct("fraise","banane","pate","beurre");

            Recipe biscote = new Recipe("Biscote","Un dure mais croustillant", new DateTime(2020,4,18),@"biscotte.jpg",5);
            biscote.AddProduct("ble","eau","levure","beurre");

            Recipe cafeGourmant = new Recipe("Cafe gourmant","Un cafe accompagne de petits gateaux", new DateTime(2020,4,18),@"cafeGourmant.jpg",1);
            cafeGourmant.AddProduct("ble","eau","levure");

            Recipe chocolat = new Recipe("Chocolat","Chocolat noir 70%", new DateTime(2020,4,17),@"chocolat.jpg",2);
            chocolat.AddProduct("cacao","sucre");

            Recipe gateauCitron = new Recipe("Gateau au citron","Un petit gout citrone", new DateTime(2020,4,19),@"gateauCitron.jpg",4);
            gateauCitron.AddProduct("citron","beurre");

            Recipe hamburger = new Recipe("Hamburger","Inspirer des grand cuistots americains", new DateTime(2020,4,13),@"gateauCitron.jpg",2);
            hamburger.AddProduct("pain","steak","fromage","salade","tomate");








            recipes.Add(tartelleteFruits,biscote,cafeGourmant,chocolat,gateauCitron,hamburger);
        }



























    }
}
