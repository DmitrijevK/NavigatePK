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
            ScrollView scrollView = new ScrollView { Content = bib };   

            ImageButton esmBtn = new ImageButton { Source= "pn.png" };
            bib.Children.Add(esmBtn);
            esmBtn.Clicked += EsmBtn_Clicked;
            ImageButton teisBtn = new ImageButton { Source = "vv.png" };
            bib.Children.Add(teisBtn);
            teisBtn.Clicked += TeisBtn_Clicked;
            ImageButton kolmBtn = new ImageButton { Source = "aa.png" };
            bib.Children.Add(kolmBtn);
            kolmBtn.Clicked += KolmBtn_Clicked;
            ImageButton neljBtn = new ImageButton { Source = "dd.png" };
            bib.Children.Add(neljBtn);
            neljBtn.Clicked += NeljBtn_Clicked;
            ImageButton redBtn = new ImageButton { Source = "xx.png" };
            bib.Children.Add(redBtn);
            redBtn.Clicked += RedBtn_Clicked;
            ImageButton sbBtn = new ImageButton { Source = "ps.png" };
            bib.Children.Add(sbBtn);
            sbBtn.Clicked += SbBtn_Clicked;
            ImageButton vsmBtn = new ImageButton { Source = "ff.png" };
            bib.Children.Add(vsmBtn);
            vsmBtn.Clicked += VsmBtn_Clicked;

            InitializeComponent();
            Content = scrollView;
        }

        private async void VsmBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new voscresenie());
        }

        private async void SbBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new subbota());
        }

        private async void RedBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new pjatnitsa());
        }

        private async void NeljBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new chetverk());
        }

        private async void KolmBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new sreda());
        }

        private async void TeisBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new vtornik());
        }

        private async void EsmBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new esmasp());
        }
    }
}
