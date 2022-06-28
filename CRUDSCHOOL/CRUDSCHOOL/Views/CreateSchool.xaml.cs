

using System;
using CRUDSCHOOL.Models;
using CRUDSCHOOL.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CRUDSCHOOL.ViewModels;


namespace CRUDSCHOOL.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class CreateSchool : ContentPage
    {
        public CreateSchool()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelCreate();

        }


    }
}

