using System;
using System.Collections.Generic;
using System.Text;


namespace Roberta.Models
{
    public static class DataStatic
    {
        List<Recipe> recipes = new List<Recipe>();

        public static void PeuplementRecettes(){
            
            recipes.Add(new Recipe("Tartelette aux fruits","Belle petite tarte venant des usines tricatel", new DateTime(2020,4,10),@"/recipes/tarteAuxFruits.jpg",
                new List<Product>(new Product("Banane","Tartelette aux fruits"))),3);


        }



























    }
}
