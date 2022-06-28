using System.Collections.Generic;
using System.Windows.Input;
using CRUDSCHOOL.Models;
using Xamarin.Forms;
using CRUDSCHOOL.Services;
using System;
using Xamarin.Forms.Xaml;


namespace CRUDSCHOOL.ViewModels
{
    public class ViewModelCreate: BaseViewModel
    {

        private string name;

        public string Name
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }

        private DateTime dateFundation;

        public DateTime DateFundation
        {
            get { return this.dateFundation; }
            set { SetValue(ref this.dateFundation, value); }
        }

        public string enabled;

        public string Enabled
        {
            get { return this.enabled; }
            set { SetValue(ref this.enabled, value); }
        }


        public ICommand CreateCommand { get; set; }

        public ViewModelCreate()
        {

            DateFundation = DateTime.Now;

            CreateCommand = new Command(() =>
            {

                var txtValidate = false;

                if (Enabled == "Sí")
                {
                    txtValidate = true;
                }

                var newSchool = new School
                {
                    Name = Name,
                    DateFundation = DateFundation,
                    Enabled = txtValidate,
                };

                SchoolService service = new SchoolService();

                service.Create(newSchool);

                Application.Current.MainPage.Navigation.PopAsync();

            });


        }


    }



}
