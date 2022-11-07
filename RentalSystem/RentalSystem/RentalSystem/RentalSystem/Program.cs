namespace RentalSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Login login = new Login();
            Application.Run(login);
            if(login.Next)
            {
                Application.Run(new MightyMotors(login.CurrentUser));
            }
        }
    }
}