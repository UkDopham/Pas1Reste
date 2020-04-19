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
    public partial class MainMenu : ContentView
    {
        public Color Red
        {
            get
            {
                return ColorRoberta.Red();
            }
        }
        public Color Azur
        {
            get
            {
                return ColorRoberta.Azur();
            }
        }
        public Color Blue
        {
            get
            {
                return ColorRoberta.Blue();
            }
        }
        public Color Grey
        {
            get
            {
                return ColorRoberta.Grey();
            }
        }
        public MainMenu()
        {
            InitializeComponent();
            BindingContext = new Title();
        }

        private void OptionsImageButton_Clicked(object sender, EventArgs e)
        {
            Page mainPage = Application.Current.MainPage;
            mainPage.BindingContext = new Options();
        }

        private void HistoriqueImageButton_Clicked(object sender, EventArgs e)
        {
            BindingContext = new Historique();
        }

        private void FavoriImageButton_Clicked(object sender, EventArgs e)
        {
            BindingContext = new Favori();
        }

        private void CatalogueImageButton_Clicked(object sender, EventArgs e)
        {
            BindingContext = new Catalogue();
        }

        private void IAImageButton_Clicked(object sender, EventArgs e)
        {
            BindingContext = new Robot();
        }
    }
}