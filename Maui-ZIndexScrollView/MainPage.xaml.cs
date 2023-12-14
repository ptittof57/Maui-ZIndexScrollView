using Maui_ZIndexScrollView.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Maui_ZIndexScrollView
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private ObservableCollection<Item> items;
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Item> Items
        {
            get { return this.items; }
            set
            {
                this.items = value;
                this.OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
            this.InitItems();
        }


        private void InitItems()
        {
            this.Items = new ObservableCollection<Item>();
            for(int i = 0; i < 100; i++)
            {
                this.Items.Add(new Item { Text = $"Item : {i}" });
            }
        }
    }
}
