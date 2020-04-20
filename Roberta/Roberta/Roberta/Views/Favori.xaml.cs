
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
    public partial class Favori : ContentView
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
        public Favori()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            List<Recipe> recipes = DataStatic.favoriRecipes;
            foreach (Recipe recipe in recipes)
            {
                ContentSL.Children.Add(ControlsHelper.GetFavoriGrid(recipe.Name, 30, recipe.Path));
            }
        }
    }
}