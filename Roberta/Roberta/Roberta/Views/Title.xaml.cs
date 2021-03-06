﻿using Roberta.Models;
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
    public partial class Title : ContentView
    {
        public Color Grey
        {
            get
            {
                return ColorRoberta.Grey();
            }
        }
        public Color Red
        {
            get
            {
                return ColorRoberta.Red();
            }
        }
        public Title()
        {
            InitializeComponent();
        }
    }
}