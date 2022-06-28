using CRUDSCHOOL.DataContext;
using CRUDSCHOOL.Interfaces;
using CRUDSCHOOL.Views;
using Xamarin.Forms;

namespace CRUDSCHOOL
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();
            GetContext().Database.EnsureCreated();
            MainPage = new NavigationPage(new MainPage());
        }

        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

