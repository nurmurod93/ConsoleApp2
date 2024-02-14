using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Company
    {
        public string Name { get; set; }
        public decimal Salary { get; init; }

        public Company(string ism, decimal maosh)
        {
            Name = ism;
            Salary = maosh;
        }
    }
}
