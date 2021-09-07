using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Binary_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== Serialization and Deserialization =============");
            Person objperson = new Person() { FirstName = "Amar", LastName = "Jagdale" };
            string filPath = "data.save";

        }
    }
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Dataserializer
    {
        //serialization
        public void BinarySerialize(object data, string filePath)
        {
            // check file is exist or not if does exist then we need to delete file first then create new
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath)) File.Delete(filePath);
            fileStream = File.Create(filePath);
            //Create serialize the object

            bf.Serialize(fileStream, data);
            fileStream.Close();
        }


        //Deserialization
        public object BinaryDeserialize(string filePath)
        {
            object obj = null;
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj =bf.Deserialize(fileStream);
                fileStream.Close();
            }
        }
    }
}


