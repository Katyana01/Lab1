namespace lab1
{
    public class Lab_first
    {
        int A;
        const long B = 6;
        uint[] C = new uint[10];
        //”твержденными типами перечислени€ €вл€ютс€ byte, sbyte, short, ushort, int, uint, long или ulong.
        enum D
        {
            first = 1,
            second = 2
        }
        public void lab2_2()
        {
            A = 2;
            A += (int)B;
            A /= (int)B;
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Lab_first lab = new Lab_first();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}