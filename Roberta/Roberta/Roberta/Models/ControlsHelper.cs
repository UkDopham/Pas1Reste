using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Roberta.Models
{
    public static class ControlsHelper
    {
        public static Label GetLabel(string text, int fontSize, Color color)
        {
            return new Label()
            {
                Margin = new Thickness(10),
                Text = text,
                FontSize = fontSize,
                BackgroundColor = Color.Transparent,
                FontFamily = "ComfortaaRegular.ttf#Open Sans",
                TextColor = color,                
                FontAttributes = FontAttributes.Bold
            };
        }
        public static Grid GetFavoriGrid(string text, int fontSize, string path)
        {
            Grid grid = new Grid();
            Image image = GetImage(path);
            Label label = GetLabel(text, fontSize, ColorRoberta.DarkRed());
            
            Image imageHeart = new Image()
            {
                HeightRequest= 40,
                MinimumHeightRequest = 40,
                MinimumWidthRequest = 40,
                WidthRequest = 40,
                Margin = new Thickness(20),
                Source = "heart.png",
                HorizontalOptions = LayoutOptions.End,
            }; 
            grid.Children.Add(image);
            grid.Children.Add(imageHeart);
            grid.Children.Add(label);

            return grid;
        }
        public static Grid GetGrid(string text, int fontSize, string path)
        {
            Grid grid = new Grid();
            Image image = GetImage(path);
            Label label = GetLabel(text, fontSize, ColorRoberta.DarkRed());
            grid.Children.Add(image);
            grid.Children.Add(label);

            return grid;
        }
        public static Image GetImage(string path)
        {
            return new Image()
            {
                MinimumHeightRequest = 40,
                MinimumWidthRequest = 40,
                Source = path,
            };
        }
    }
}
