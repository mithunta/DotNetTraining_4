using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTraining.Library
{
    public static class GeneralExtension
    {
        public static string CharToFullStringExtension(this string s)
        {
            if(s == "M" )
            {
                return "Male";
            }
            else if(s == "F" )
            {
                return "Female";
            }
            return "Unknow";
        }
    }
}
