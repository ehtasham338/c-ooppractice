// encapsuation practice 





/*

using System;
public class Student
{
    private string name;

    private int age;

     public string Name
    {
        get { return name; }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
                Console.WriteLine("Name cannot be empty!");
            else
                name = value;
        }
    }

  public int Age
    {
        get { return age; }

        set
        {
            if (value < 5 || value > 100)
                Console.WriteLine("Invalid age! Please enter between 5 and 100.");
            else
                age = value;
        }
    }
    public void showinfo()
    {
        Console.WriteLine("the nam eof student is "+name);
        Console.WriteLine("the age4 of student is "+age);
    }


}

public class Progarm
{
    static void Main(string[] args)
    {
        Student s1=new Student();
          s1.Name = "Ehtasham";
        s1.Age = 22;


// invalid 
        s1.Name = " ";
        s1.Age = -22;
    }
}

*/