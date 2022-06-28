using CRUDSCHOOL.Droid.Implementations;
using System.IO;
using CRUDSCHOOL.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace CRUDSCHOOL.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment
                .GetFolderPath(System.Environment
                .SpecialFolder.Personal), databaseFileName);
        }
    }
}

