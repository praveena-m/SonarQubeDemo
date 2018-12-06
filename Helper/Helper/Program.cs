using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int aa = 1;
            int b = aa / 23;
            string password = "abc@123";

            string status = null;
            try
            {
                status = GetStatus();
            }
            catch (Exception)
            {

                throw;
            }

            string newStatus = status + " updated";
        }

        public static string GetStatus()
        {
            return null;
        }
    }
}
