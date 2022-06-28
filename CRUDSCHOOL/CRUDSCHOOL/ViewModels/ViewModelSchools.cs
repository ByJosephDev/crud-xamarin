using System.Collections.Generic;
using System.Windows.Input;
using CRUDSCHOOL.Models;
using Xamarin.Forms;
using CRUDSCHOOL.Services;
using System;

namespace CRUDSCHOOL.ViewModels
{
    public class ViewModelSchools: BaseViewModel
    {

        private List<School> schools;

        public List<School> Schools
        {
            get { return this.schools; }
            set { SetValue(ref this.schools, value); }
        }


        public ICommand ListCommand { get; set; }
        public ICommand ShowCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand UpdateCommand { get; set; }

        private int schoolid;

        public int txtSchoolId
        {
            get { return this.schoolid; }
            set { SetValue(ref this.schoolid, value); }
        }

        private string name;

        public string txtName
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }

        private DateTime datefundation;

        public DateTime txtDateFundation
        {
            get { return this.datefundation; }
            set { SetValue(ref this.datefundation, value); }
        }

        private bool enabled;

        public bool txtEnabled
        {
            get { return this.enabled; }
            set { SetValue(ref this.enabled, value); }
        }

        private string validate;

        public string txtValidate
        {
            get { return this.validate; }
            set { SetValue(ref this.validate, value); }
        }

        public ViewModelSchools()
        {

            ListCommand = new Command(() =>
            {
                SchoolService service = new SchoolService();
                Schools = service.Get();
            });

            ShowCommand = new Command<int>(
                execute: (int parameter) =>
            {
                int pressed = parameter;

                SchoolService service = new SchoolService();

                School item = service.getSchool(pressed);

                txtSchoolId = item.SchoolId;
                txtName = item.Name;
                txtDateFundation = item.DateFundation;

                txtValidate = item.Enabled ? "Sí" : "No";

            });

            DeleteCommand = new Command(() =>
            {

                var txtValidateUp = false;

                if (txtValidate == "Sí")
                {
                    txtValidateUp = true;
                }

                var School = new School
                {
                    SchoolId = txtSchoolId,
                    Name = txtName,
                    DateFundation = txtDateFundation,
                    Enabled = txtValidateUp,
                };

                SchoolService service = new SchoolService();

                service.Delete(School);


            });

            UpdateCommand = new Command(() =>
            {

                var txtValidateNow = false;

                if (txtValidate == "Sí")
                {
                    txtValidateNow = true;
                }

                var newSchool = new School
                {
                    SchoolId = txtSchoolId,
                    Name = txtName,
                    DateFundation = txtDateFundation,
                    Enabled = txtValidateNow,
                };

                SchoolService service = new SchoolService();

                service.Update(newSchool);

            });


        }

    }
}

