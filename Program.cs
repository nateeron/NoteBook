using Microsoft.Extensions.Configuration;
using System.IO;
using System.Windows.Forms;
namespace NoteBook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IConfiguration Configuration { get; private set; }
        [STAThread]
        static void Main()
        {
            // Set the path for the appsettings.json file
            string appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            // Check if the appsettings.json file exists
            if (!File.Exists(appSettingsPath))
            {
                // Create the appsettings.json file with default content
                var defaultSettings = new
                {
                    ConnectionStrings = new
                    {
                        SQLiteConnection = "Data Source=notebook.db;Version=3;",
                        vscode = @"C:\Users\Dev\AppData\Local\Programs\Microsoft VS Code\Code.exe"
                    }
                };

                // Serialize the default settings to JSON
                string json = System.Text.Json.JsonSerializer.Serialize(defaultSettings, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });

                // Write the JSON string to the file
                File.WriteAllText(appSettingsPath, json);
            }


            // Set up the configuration to read from appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); // Make it non-optional if you want it to throw an error if missing

            Configuration = builder.Build();

            // Initialize application settings
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(Configuration));
        }
    }
}