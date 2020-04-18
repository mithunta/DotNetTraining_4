using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTraining.Library
{
    public class Developer : Person, ISalary
    {

        public string TypeTDeveloper { get; set; }
        public int TotalAnnualSalary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Developer() 
        { 

        }
        public Developer(string firstname) : base()
        {

        }

        public void CalculateSalary()
        {
            
        }
    }
}
