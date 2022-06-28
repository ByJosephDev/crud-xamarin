
using System;
using CRUDSCHOOL.Services;
using Xamarin.Forms;

namespace CRUDSCHOOL.Views
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();



            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CreateSchool());
            };

            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListSchools());
            };

        }

    }
}

