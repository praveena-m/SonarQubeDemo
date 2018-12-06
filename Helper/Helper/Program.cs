namespace Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int aa = 1;
           aa = aa / 23;

            string status = null;
            try
            {
                status = GetStatus();
            }
            catch 
            {
                throw;
            }

            //string newStatus = status + " updated";
        }

        public static string GetStatus()
        {
            return null;
        }
    }
}
