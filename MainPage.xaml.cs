using System.Collections.ObjectModel;

namespace mobilki
{
    
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> listaZakupow = new();

        public MainPage()
        {
            InitializeComponent();
            itemsList.ItemsSource = listaZakupow;
        }

        private void addButton_Clicked(object sender, EventArgs e)
        {
            string tekst = entryItem.Text;

            if (!string.IsNullOrEmpty(tekst))
            {
                listaZakupow.Add(tekst);
                entryItem.Text = string.Empty;
            }
        }
    }
}
