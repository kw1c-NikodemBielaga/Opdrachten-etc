using GameScore.View;

namespace GameScore
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
            if (LoginForm.ShowLogin())  // Alleen inloggen bij opstarten
            {
                Application.Run(new Startscherm());
            }
            else
            {
                MessageBox.Show("Toegang geweigerd. Applicatie wordt afgesloten.", "Geen toegang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}