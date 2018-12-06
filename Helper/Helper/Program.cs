using System;

namespace Helper
{
    class Program
    {
        static void Main(string[] args)
        {

            string status = null;
            try
            {
                status = GetStatus();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message);
                throw;
            }

            status = status + " updated";
            System.Diagnostics.Trace.WriteLine(status);
        }

        public static string GetStatus()
        {
            return null;
        }
    }
}
