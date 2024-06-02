using Microsoft.Maui.Controls;
using Test.Models;

namespace Test
{
    [QueryProperty(nameof(Item), "Item")]
    public partial class DetailsPage : ContentPage
    {
        private Item _item;
        public Item Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged();
                UpdatePageContent();
            }
        }

        public DetailsPage()
        {
            InitializeComponent();
        }

        private void UpdatePageContent()
        {
            if (Item != null)
            {
                image.Source = Item.ImagePath;
                title.Text = Item.Title;
            }
        }
    }
}
