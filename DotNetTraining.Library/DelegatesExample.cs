using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTraining.Library
{
    public class DelegatesExample
    {
        public string Cancatenate(string firstname, string lastname)
        {
            return $"{firstname} , {lastname}";
        }

        public string Reverse(string firstname, string lastname)
        {
            return $"{lastname} , {firstname}";
        }
    }
}
