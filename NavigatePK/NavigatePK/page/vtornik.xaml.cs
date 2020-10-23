using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigatePK.page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vtornik : ContentPage
    {
        public vtornik()
        {
            StackLayout vtornikv = new StackLayout();
            string[] taska = new string[] { "Tõusen", "Söön ",  "Tegelen spordiga", "Söön", "Läks koolis", "Söön" };

            ListView lista = new ListView();
            // определяем источник данных
            lista.ItemsSource = taska;
            lista.ItemSelected += Lista_ItemSelected;
            Content = new StackLayout { Children = { lista } };
        }

        string vremja;
        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string text = e.SelectedItem.ToString();
            if (e.SelectedItemIndex == 0)
            {
                vremja = "7:00";
            }

            if (e.SelectedItemIndex == 1)
            {
                vremja = "10:00";
            }

            if (e.SelectedItemIndex == 2)
            {
                vremja = "12:00";
            }

            if (e.SelectedItemIndex == 3)
            {
                vremja = "14:00";
            }

            if (e.SelectedItemIndex == 4)
            {
                vremja = "18:00";
            }

            if (e.SelectedItemIndex == 5)
            {
                vremja = "19:00";
            }

            if (e.SelectedItemIndex == 6)
            {
                vremja = "20:00";
            }

            await DisplayAlert(text, vremja, "Продолжить");


            StackLayout vtornikv = new StackLayout();

            Button bb = new Button { Text = "Назад" };
            bb.Clicked += Bb_Clicked;
            vtornikv.Children.Add(bb);

            Button bbk = new Button { Text = "Назад" };
            bbk.Clicked += Bbk_Clicked;
            vtornikv.Children.Add(bbk);
        }

        private async void Bbk_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new sreda());
        }

        private async void Bb_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}