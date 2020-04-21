using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTraining.Library
{
    public class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Users()
        {

        }

        public void GetUserInformation()
        {

        }
        private void _GetFullName()
        {

        }
    }

    public class Authors
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
