﻿using System;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var emp = new Employee();
                Console.WriteLine(emp.GetName());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
   
}
