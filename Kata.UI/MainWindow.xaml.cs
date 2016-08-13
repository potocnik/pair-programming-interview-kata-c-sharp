using Kata.Implementation;
using Kata.Implementation.Models;
using System.Collections.Generic;
using System.Windows;

namespace Kata.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IRegister _register;

        public MainWindow()
        {
            _register = new Register(new List<CatalogueItem>
            {
                new CatalogueItem { Name = 'A', Price = 50 },
                new CatalogueItem { Name = 'B', Price = 30 },
                new CatalogueItem { Name = 'C', Price = 20 },
                new CatalogueItem { Name = 'D', Price = 15 }
            });
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, RoutedEventArgs e)
        {
            
            if (txtGoods.Text.Trim().Equals(string.Empty))
            {
                txtTotal.Text = "Please supply goods";
                return;
            }
            txtTotal.Text = string.Format("£{0}", _register.Price(txtGoods.Text));
        }
    }
}
