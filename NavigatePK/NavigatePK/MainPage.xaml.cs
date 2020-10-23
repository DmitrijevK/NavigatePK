using NavigatePK.page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigatePK
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            StackLayout bib = new StackLayout();

            Button esmBtn = new Button { Text= "Пн." };
            esmBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(esmBtn);
            Button teisBtn = new Button { Text = "Вт." };
            teisBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(teisBtn);
            Button kolmBtn = new Button { Text = "Ср." };
            kolmBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(kolmBtn);
            Button neljBtn = new Button { Text = "Чт." };
            neljBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(neljBtn);
            Button redBtn = new Button { Text = "Пт." };
            redBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(redBtn);
            Button sbBtn = new Button { Text = "Сб." };
            sbBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(sbBtn);
            Button vsmBtn = new Button { Text = "Вс." };
            vsmBtn.Clicked += new EventHandler(Btn_clik);
            bib.Children.Add(vsmBtn);

            Content = bib;
        }

        private async void Btn_clik(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)
            {
                case "Пн.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new esmasp());
                    break;
            }
            switch (btn.Text)
            {
                case "Вт.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new vtornik());
                    break;
            }
            switch (btn.Text)
            {
                case "Ср.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new vtornik());
                    break;
            }

            switch (btn.Text)
            {
                case "Чт.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new vtornik());
                    break;
            }

            switch (btn.Text)
            {
                case "Пт.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new vtornik());
                    break;
            }

            switch (btn.Text)
            {
                case "Сб.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new vtornik());
                    break;
            }

            switch (btn.Text)
            {
                case "Вс.":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new vtornik());
                    break;
            }
        }
    }
}
