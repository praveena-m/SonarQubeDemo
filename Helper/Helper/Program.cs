// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Helper
{
    using System;

    /// <summary>
    /// Program Class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Get the status from service.
        /// </summary>
        /// <returns>Returns null</returns>
        public static string GetStatus()
        {
            return null;
        }

        /// <summary>
        /// Add method to add two numbers
        /// </summary>
        /// <param name="a">param 1</param>
        /// <param name="b">param 2</param>
        /// <returns>returns sum of 2 numbers</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">run args</param>
        private static void Main(string[] args)
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
    }
}
