using Microsoft.Maui.Controls;
using System.Collections.Generic;
using Test.Models;

namespace Test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var items = new List<Item>
            {
                new Item { Title = "Football", ImagePath = "football.jpg" },
                new Item { Title = "Cricket", ImagePath = "cricket.jpg" },
                new Item { Title = "Basketball", ImagePath = "basketball.jpg" },
                new Item { Title = "Volleyball", ImagePath = "volleyball.jpg" }
            };

            collectionView.ItemsSource = items;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var item = button?.BindingContext as Item;
            if (item != null)
            {
                var navigationParameter = new Dictionary<string, object>
                {
                    { "Item", item }
                };

                await Shell.Current.GoToAsync(nameof(DetailsPage), navigationParameter);
            }
        }
    }
}
