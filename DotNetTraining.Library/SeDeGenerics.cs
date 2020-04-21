using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace DotNetTraining.Library
{
    public class SeDeGenerics
    {
        public string Serialization<T>(T langauges)
        {
            string json = JsonConvert.SerializeObject(langauges);

            Console.WriteLine(json);

            return json;
        }
        public T DeSerialization<T>(string json)
        {
            T langauges = JsonConvert.DeserializeObject<T>(json);

            return langauges;

        }


        public string SerializationUsers(List<Users> users)
        {
            string json = JsonConvert.SerializeObject(users);

            Console.WriteLine(json);

            return json;
        }

        public string SerializationAuthors(List<Authors> authors)
        {
            string json = JsonConvert.SerializeObject(authors);

            Console.WriteLine(json);

            return json;
        }


    }

    
}
