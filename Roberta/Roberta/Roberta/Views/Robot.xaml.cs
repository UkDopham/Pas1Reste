using Roberta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Roberta.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Robot : ContentView
    {
        public Color Red
        {
            get
            {
                return ColorRoberta.Red();
            }
        }
        public Color Grey
        {
            get
            {
                return ColorRoberta.Grey();
            }
        }
        public Robot()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            List<Product> products = Product.GetAllProducts(DataStatic.histoRecipes);
            foreach (Product product in products)
            {
                ProductSL.Children.Add(ControlsHelper.GetImage($"_{product.Name}.png"));
            }
        }

        private void InitRecipes()
        {
            List<Recipe> recipes = DataStatic.favoriRecipes;
            foreach (Recipe recipe in recipes)
            {
                ContentSL.Children.Add(ControlsHelper.GetFavoriGrid(recipe.Name, 30, recipe.Path));
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            InitRecipes();
        }
    }
}