using System;

namespace DotNetTraining.Library
{
    public abstract class Person
    {
        #region Variable
        private int salary;
        #endregion


        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected string FullName { get; set; }
        private int DummySalary { get; set; }
        #endregion

        #region Constructor
        public Person()
        {
            Console.WriteLine("Default Constructor from the Base");
        }

        public Person(int annualSalary)
        {
            DummySalary = annualSalary;
        }
        #endregion

        #region Methods

        #region Private Methods
        private void GetSalary()
        {
            salary = 100;
        }
        #endregion

        #region Public Methods

        #region Method Overloading or Polymorphism
        public string GetFullName()
        {
            string fullname = FirstName + " " + LastName;

            return fullname;
        }
        
        public string GetFullName(string lastname)
        {
            LastName = lastname;
            string fullname = FirstName + " " + LastName;

            return fullname;
        }
        
        #endregion
        #endregion

        #endregion
    }
}
