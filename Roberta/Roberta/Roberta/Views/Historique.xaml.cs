
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
    public partial class Historique : ContentView
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
        public Historique()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            List<Recipe> recipes = new List<Recipe>();
            recipes.Add(new Recipe("Pizza", "test", DateTime.Now, "recipes/bagels.png", new List<Product>()));
            recipes.Add(new Recipe("Pizza2", "test", DateTime.Now, "recipes/donut.png", new List<Product>()));
            recipes.Add(new Recipe("Pizza3", "test", DateTime.Now, "_donut.jpg", new List<Product>()));
            foreach (Recipe recipe in recipes)
            {
                ContentSL.Children.Add(ControlsHelper.GetGrid(recipe.Name ,40,recipe.Path));
            }
        }

    }
}