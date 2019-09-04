using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_and_Anya
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Employee
    {
        public int Bank { get; set; }
        public int Ird { get; set; }
        public int PayRate { get; set; }
        public int Hours { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CalcWages()
        {
            return PayRate * Hours;
        }
        public string Display()
        {
            return
                $"Bank no:{Bank}\n" +
                $"Ird no: {Ird}\n" +
                $"Pay Rate: {PayRate}\n" +
                $"Hours Worked: {Hours}\n" +
                $"Name: {Name}\n" +
                $"Age: {Age}\n" +
                $"Wages: {CalcWages()}";

        }
    }

    
}
