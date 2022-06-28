using System;
using System.Collections.Generic;
using CRUDSCHOOL.Services;
using Xamarin.Forms;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms.Xaml;
using CRUDSCHOOL.ViewModels;

namespace CRUDSCHOOL.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListSchools : ContentPage
    {
        public ListSchools()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelSchools();


        }


    }

}

