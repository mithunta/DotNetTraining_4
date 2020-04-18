using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTraining.Library
{
    public interface ISalary
    {
        int TotalAnnualSalary { get; set; }
        void CalculateSalary();
        
    }
}
