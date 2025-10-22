
/*
using System;

class Student
{
    public string Name;
    public int Id;

    
    public override bool Equals(object obj)
    {
        
        if (obj == null || GetType() != obj.GetType())
            return false;

        
        Student other = (Student)obj;

        
        return this.Name == other.Name && this.Id == other.Id;
    }


    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Id);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student { Name="Ali", Id=1 };
        Student s2 = new Student { Name="Ali", Id=1 };

        Console.WriteLine(s1.Equals(s2)); 
    }
}

*/
