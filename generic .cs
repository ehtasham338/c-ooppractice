/*


// generic practice 


using System;


public class Box<T>{


public T Item { get; set; }

    public void showitem()
    {
        Console.WriteLine("store item:"Item);

    }



}
public class Book {


    public string title { get; set; }
    public override string ToString() => "Book: " + title;
}


public class Pen
{
    public string colour { get; set; }

    public override string ToString() => "Pen: " + colour;

}


public class Program
{
    static void Main(string[] args)

    {
        Box<Book> strbox = new Box<Book>();
        strbox.Item = new Book { title = "C# Programming" };
        strbox.showitem();


        Box<Pen> penBox = new Box<Pen>();
        penBox.Item = new Pen { colour = "Blue" };
        penBox.showitem();
        





    }


}

*/