using System;
using System.Collections;
using System.Collections.Generic;

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
            if (age <= 40)
            {
                Console.WriteLine("Your age is 40");
            }
            else if (age > 50 && age < 100)
            {
                Console.WriteLine("Your age is 50");
            }
            else
            {
                Console.WriteLine("Your age does fall in the category");
            }
            #endregion

            #region Switch
            switch (age)
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
            for (int i = 0; i < 10; i++)
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
                Console.WriteLine("i:{0}", i);
            }
            #endregion

            #region While
            int j = 0;
            while (j < 10)
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

            #region Call a Method
            string fullName = TestMethod(firstName);
            Console.WriteLine($"fullName: {fullName}");
            #endregion

            #region Arrays

            string[] firstNames = new string[4];

            firstNames[0] = "Mithun";
            firstNames[1] = "Swathi";
            firstNames[2] = "Alp";
            firstNames[3] = "Adetayo";

            foreach(string fn in firstNames)
            {
                Console.WriteLine("First Name:" + fn);
            }

            object[] objs = new object[4];
            objs[0] = "Test1";
            objs[1] = "Test2";
            objs[2] = "Test3";
            objs[3] = "Test4";

            int[] ages = new int[4];
            ages[0] = 1;
            ages[1] = 1;
            ages[2] = 1;
            ages[3] = 1;

            int[] numbers = new int[10];
            for(int i = 0; i < 10; i++)
            {
                numbers[i] = i;
            }
            #endregion

            #region Collections
            List<string> firstNamess = new List<string>();
            firstNamess.Add("Test1");
            firstNamess.Add("Test1"); 
            firstNamess.Add("Test2");
            firstNamess.Add("Test3");
            firstNamess.Add("Test4");

            firstNamess.Insert(2, "Test5");
            int index = firstNamess.IndexOf("Test1");
            firstNamess.RemoveAt(3);
            firstNamess.Remove("Test4");

            firstNamess.Sort();

            firstNamess.Clear();

            List<int> agess = new List<int>();
            agess.Add(1);
            agess.Add(2);
            agess.Add(3);
            agess.Add(4);

            Hashtable hashtable = new Hashtable();
            hashtable.Add("FieldA", "Error 1");
            hashtable.Add(1, "Test1");
            hashtable.Add("A", "Test1");
            hashtable.Add("C", "Test2");

            foreach(KeyValuePair<string, string> ht in hashtable.Values)
            {
                Console.WriteLine(ht.Key + " " + ht.Value);
            }
            string valA = hashtable["A"].ToString();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> ht in dictionary)
            {
                Console.WriteLine(ht.Key + " " + ht.Value);
            }

            Queue q = new Queue();

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
