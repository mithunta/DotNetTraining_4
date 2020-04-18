using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTraining.Library
{
    class Manager : Person, ISalary
    {
        public Manager()
        {
            
        }

        public int TotalAnnualSalary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
