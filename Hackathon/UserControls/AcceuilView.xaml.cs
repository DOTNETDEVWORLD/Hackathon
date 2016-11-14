﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hackathon.UserControls
{
    /// <summary>
    /// Logique d'interaction pour AcceuilView.xaml
    /// </summary>
    public partial class AcceuilView : UserControl
    {
        public AcceuilView()
        {
            InitializeComponent();

            datagrid.ItemsSource = new[] {
                new {
                    Titre = "Titre 1",
                },
                 new {
                    Titre = "Titre 2",
                },
                  new {
                    Titre = "Titre 3",
                },
                   new {
                    Titre = "Titre 4",
                },
                    new {
                    Titre = "Titre 5",
                },
                     new {
                    Titre = "Titre 6",
                },
                      new {
                    Titre = "Titre 7",
                }
            };
        }
    }
}
