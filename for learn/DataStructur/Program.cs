

using System.Globalization;
using Windows.UI.Xaml;

namespace DataStructur
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string url = "https://www.instagram.com/reel/Dd5A9Liqctg/?utm_source=ig_web_copy_link&stkn=MzRlODBiNWFlZA==";
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Click 1 :");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                OpenUrlInDefaultBrowser(url);
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting.");
            }










        }
        public static void OpenUrlInDefaultBrowser(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while trying to open the URL: {ex.Message}");
            }
        }
    }
}







