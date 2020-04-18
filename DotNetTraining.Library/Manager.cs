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

        public int TotalAnnualSalary { get ; set ; }

        public void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
