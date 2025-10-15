// access modifier practice 
// school management system

/*

using System;


public class School
{
    public string schoolname = "Abbottabad School";
    protected string principal = "Ehtasham";
    private int totalstrength = 120;
    internal string Location = "Abbottabad";
    protected internal int TeacherCount = 40;


    public void showinfo()
    {
        Console.WriteLine("The name of school: " + schoolname);
        Console.WriteLine("The location of school: " + Location);
        Console.WriteLine("The total teachers of school: " + TeacherCount);
    }


    private void privateinfo()
    {
        Console.WriteLine("The total strength of school is " + totalstrength);
    }


    public void accessprivatedata()
    {
        privateinfo();
    }

    
}

// derived class 


public class ChildSchool : School
{
    public void ShowDerivedAccess()
    {
        Console.WriteLine("From Derived Class:");
        Console.WriteLine("SchoolName: " + schoolname);
        //Console.WriteLine(totalstrength);              
        Console.WriteLine("Principal: " + principal);
        Console.WriteLine("Location: " + Location);
        Console.WriteLine("TeacherCount: " + TeacherCount);
    }
}

internal class Staff
{
    public void showstaff()
    {
        School s = new School();
        Console.WriteLine("From Staff Class (Same Assembly):");
        Console.WriteLine(s.schoolname);      
        // Console.WriteLine(s.totalstrength); 
        // Console.WriteLine(s.principal);     
        Console.WriteLine(s.Location);        
        Console.WriteLine(s.TeacherCount);    
    }
}

public class Program
{
    public static void Main()
    {

        School s = new School();
        s.showinfo();
        s.accessprivatedata();   
        


        Console.WriteLine("++++++++++");

        ChildSchool cs = new ChildSchool();
        cs.ShowDerivedAccess();



        Console.WriteLine("++++++++++");


        Staff st = new Staff();

        st.showstaff();
    }
}




*/
