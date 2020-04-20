
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
    public partial class Catalogue : ContentView
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
        public Catalogue()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {            
            List<Recipe> recipes = DataStatic.allRecipes;
            foreach (Recipe recipe in recipes)
            {
                ContentSL.Children.Add(ControlsHelper.GetGrid(recipe.Name, 30, recipe.Path));
            }
        }
    }
}