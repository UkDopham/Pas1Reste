using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roberta.Models
{
    public class KNN
    {
        private List<Product> _data = new List<Product>();

        public KNN()
        {
            InitData();
        }

        private void InitData()
        {
            this._data.Add(new Product("banane", "cake"));
            this._data.Add(new Product("banane", "soupe"));
            this._data.Add(new Product("banane", "soda"));
            this._data.Add(new Product("eau", "soda"));
            this._data.Add(new Product("eau", "soupe"));
            //recuper les données
        }

        /// <summary>
        /// Retourne la recette la plus favorable à l'utilisateur
        /// </summary>
        /// <param name="product"></param>
        public Product GetRecipe(List<Product> products, int k = 10)
        {
            List<Product> sameProducts = this._data.Where(x => ContainsProduct(x, products)).ToList(); // on traite seulement les mêmes produits
            sameProducts.Sort(); // on tri en fonction de la ressemblance
            List<Product> bestProducts = k < this._data.Count() ? GetBest(sameProducts, k) : GetBest(sameProducts, sameProducts.Count()); // dans le cas ou la data est trop petite

            return GetMostPopular(bestProducts);
        }
        
        private bool ContainsProduct(Product containsProduct, List<Product> products)
        {
            bool contains = false;
            foreach(Product product in products)
            {
                if (product.Name == containsProduct.Name)
                {
                    contains = true;
                }
            }
            return contains;
        }
        /// <summary>
        /// Retourne l'élément le plus présent dans la liste
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        private Product GetMostPopular(List<Product> products)
        {
            List<DoubleContainer<Product, int>> productsCount = new List<DoubleContainer<Product, int>>();
            foreach(Product product in products)
            {
                DoubleContainer<Product, int> tmp = productsCount.FirstOrDefault(x => x.Value.RecipeName == product.RecipeName);
                if (tmp != null)
                {
                    tmp.OtherValue++;
                }
                else
                {
                    productsCount.Add(new DoubleContainer<Product, int>(product, 1));
                }
            }
            return productsCount[0].Value;
        }
        /// <summary>
        /// Recuper les k premier de la liste triée 
        /// </summary>
        /// <param name="products"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        private List<Product> GetBest(List<Product> products, int k)
        {
            List<Product> tmp = new List<Product>();
            for (int i = 0;
                i < k;
                i ++)
            {
                tmp.Add(products[i]);
            }

            return tmp;
        }
    }
}
