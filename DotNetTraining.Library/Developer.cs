using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTraining.Library
{
    public class Developer : Person, ISalary
    {
        private string firstname;

        public string TypeTDeveloper { get; set; }
        public int TotalAnnualSalary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Test { get; private set; }
        public Developer() 
        { 

        }
        public Developer(string firstname) : base(firstname)
        {
            Test = firstname;
            Console.WriteLine("Developer Constructor");
        }

        public void CalculateSalary()
        {
            
        }

        public override void GetAddress()
        {
            Console.WriteLine("Child Class overriding");
        }
    }
}
