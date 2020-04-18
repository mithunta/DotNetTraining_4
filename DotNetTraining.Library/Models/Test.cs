using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTraining.Library.Models
{
    // Internal Access Modifier Usage
    class Test : Person
    {
        public Test()
        {
            //Person p = new Person();
            string name = FullName;
            
        }
    }

    class TestInternalAccessModifier
    {
        public TestInternalAccessModifier()
        {
           // Person p = new Person(1000);
            
        }
    }
}
