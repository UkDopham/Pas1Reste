using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace KNNPING.Models
{
    public class Product : IComparable<Product>
    {
        protected string _name;
        protected string _recipeName;

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

        public float GetDistance()
        {
            List<Recipe> recipes = new List<Recipe>();
            //recipes.Add(new Recipe("cake", "test", DateTime.Now, 1));
            //recipes.Add(new Recipe("soda", "test", new DateTime(1999,1,1), 3));
            //recipes.Add(new Recipe("soupe", "test", new DateTime(2009, 1, 1), 3));
            //recipes.Add(new Recipe("voiture", "test", DateTime.Now, 1));
            //Recipe recipe = recipes.First(x => x.Name == this._recipe.Name); //Trouver la recette à partir du nom dans la base de donnée
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
