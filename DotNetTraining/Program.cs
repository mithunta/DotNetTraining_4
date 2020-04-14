using System;

namespace DotNetTraining
{
    class Program
    {
        private static string lastName="Ashwathappa";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my first application");

            #region Data Type

            #region  Reference Type
            string firstName;
            firstName = "Mithun";

            object obj = true;
            bool testBoolean = (bool)obj;

            dynamic dy = "Dynamic datatype variable";
            string testString = dy;

            var company = "Romete Tiger";
            Console.WriteLine("testBoolean :" + testBoolean);
            #endregion

            #region Value Type
            int age = 40;
            double annualSalary = 1000.0;
            bool employed = true;
            char gender = 'M';

            float monthlySalary = 100.0f;

            #endregion

            #endregion

            #region Comments
            /*
             Comments
             * */
            #endregion

            #region Operators
            // + - = == / * && || 
            //++ 
            #endregion

            #region Preprocessor Directives
#if DEBUG
            firstName = "Mithun";
#else
            firstName = "Test";
#endif
            #endregion

            #region Reserved Keyword
            //Example : string, class, Main, namespace.....
            #endregion

            #region Conditional Statements

            #region Branching
            #region IF ELSE
            if(age <= 40)
            {
                Console.WriteLine("Your age is 40");
            }
            else if(age > 50 && age < 100)
            {
                Console.WriteLine("Your age is 50");
            }
            else
            {
                Console.WriteLine("Your age does fall in the category");
            }
            #endregion

            #region Switch
            switch(age)
            {
                case 40:
                    Console.WriteLine("Your age is 40");
                    break;
                case 50:
                    Console.WriteLine("Your age is 50");
                    break;
                default:
                    Console.WriteLine("Your age does fall in the category");
                    break;

            }
            #endregion
            #endregion

            #region Loops

            #region For Loop & Nested Loop
            for(int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (i == 5)
                    {
                        if (age == 40)
                        {

                        }
                        break;
                    }
                }
                Console.WriteLine("i:{0}",i);
            }
            #endregion

            #region While
            int j = 0;
            while(j < 10)
            {
                if (j == 5)
                {
                    continue;
                }
                Console.WriteLine(j);
                j++;
            }
            #endregion

            #region Do While
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 10);
            #endregion

            #endregion

            #endregion

            Console.WriteLine("First Name :" + firstName);

            #region Call a Method
            string fullName = TestMethod(firstName);
            Console.WriteLine($"fullName: {fullName}");
            #endregion

            

        }

        //AccessModifier(public) MethodType(static) ReturnType(void/string....) MethodName(TestMethod) (string firstName Arguments)
        private static string TestMethod(string firstName)
        {
            Console.WriteLine($"firstName : {firstName}");

            return $"My full Name is {firstName}{lastName}";
        }
    }
}
