/*
using System;

public class Collage
{
    


    private string[] names = new string[5];
    private int[] ages = new int[5];

    


    public string this[int index]
    {


        get { return $"Name: {names[index]}, Age: {ages[index]}"; }
    }



    
    public void AddStudent(int index, string name, int age)
    {
        names[index] = name;

        ages[index] = age;
    }
}




public class Pro

{
    static void Main(string[] args)
    {
        Collage ce = new Collage();

        ce.AddStudent(0, "Ehtasham", 22);
        ce.AddStudent(1, "Hamza", 23);
        ce.AddStudent(2, "Ali", 24);



        Console.WriteLine(ce[0]);
        Console.WriteLine(ce[1]);
        Console.WriteLine(ce[2]);
    }
}




using System;
public class student {

    public string[] name=new string[3];

    public string this{int index}
    {
        get{return  names[index];}
        set{name[index] =value;}

    }





}

class Program
{
    static void Main()
    {
        StudentList s = new StudentList();


        s[0]="ehtashm";
        s[1]="hamza";
        s[3]="khan";

        
        Console.WriteLine(s[0]);  
        Console.WriteLine(s[1]);
        console.WrietLine(s[3]);
    }
    
    
    
    }
*/
