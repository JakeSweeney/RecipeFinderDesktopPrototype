using System.Diagnostics;
using System.Web.Http;
using System.Web.Http.SelfHost;
namespace RecipeFinderPrototype
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Data.PresetListAddAll();
            Application.Run(new HomePage());
        }
        
    }
}