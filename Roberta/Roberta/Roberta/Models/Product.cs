using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Roberta.Models
{
    public class Product : IComparable<Product>
    {
        protected string _name;
        protected string _recipeName;
        public List<Recipe> recipes;
        public string RecipeName
        {
            get
            {
                return this._recipeName;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public Product(string name, string recipeName)
        {
            this._name = name;
            this._recipeName = recipeName;
        }

        public static List<Product> GetAllProducts(List<Recipe> recettes){
            List<Product> products = new List<Product>();

            recettes.ForEach(r => products.AddRange(r.Products()));

            return products;
        }

        public float GetDistance()
        {
            Recipe recipe = recipes.First(x => x.Name == this._recipeName); //Trouver la recette à partir du nom dans la base de donnée
            return recipe.Count + 1/((DateTime.Now - recipe.LastCooked).Days == 0 ? 1 : (DateTime.Now - recipe.LastCooked).Days);            
        }


        public int CompareTo(Product other)
        {
            if (GetDistance() >= other.GetDistance()) // plus proche
            {
                return -1;
            }
            else if (GetDistance() == other.GetDistance())
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
