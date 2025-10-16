//non Serializable practice

/*


using System;
using System.IO;
using System.Text.Json;

[Serializable]
public class Person
{
    public string name { get; set; }
    public int id { get; set; }

    [NonSerialized] public int paswword; 

    public void ShowInfo()
    {
        Console.WriteLine("The name of person is " + name.ToUpper());
    }
}

public class Program
{
    static void Main()
    {
        Person p = new Person
        {
            name = "Ehtasham",
            id = 123,
            paswword = 2025
        };

        

        // serialized 

        string json = JsonSerializer.Serialize(p);
        File.WriteAllText("Person.json", json);

        Console.WriteLine("Object serialized successfully (JSON):");
        Console.WriteLine(json);



// deserialize 

        string jsonFromFile = File.ReadAllText("Person.json");
        Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonFromFile);

        Console.WriteLine("\nDeserialized Person Name: " + deserializedPerson.name);
        Console.WriteLine("Deserialized Person ID: " + deserializedPerson.id);
        Console.WriteLine("Deserialized Person Rank: " + deserializedPerson.rank); 
    }
}


*/
