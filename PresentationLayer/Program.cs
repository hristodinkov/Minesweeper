using ServiceLayer;
namespace PresentationLayer
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
            LocalPlayer Player = new LocalPlayer();
            ApplicationConfiguration.Initialize();
            Application.Run(new Profiles(Player));
        }
       
    }
}