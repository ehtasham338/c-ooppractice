// stack aprctice 
/*

using System;
using System.Collections.Generic;
public class Item
{

    public string itemname { get; set; }
    public int quantity { get; set; }
    public int price { get; set; }
    public override string ToString()
    {
        return $"Name: {itemname}, Quantity: {quantity}, Price: {price}";
    }





}

public class Program
{
    static void Main(string[] args)
    {

        Stack<Item> items = new Stack<Item>();


        // add item in stack 

         items.Push(new Item { itemname = "Pen", quantity = 10, price = 20 });
        items.Push(new Item { itemname = "Notebook", quantity = 5, price = 100 });
        items.Push(new Item { itemname = "Eraser", quantity = 15, price = 10 });


        
        Console.WriteLine(" After Push Operations:");
        foreach (Item i in items)
        {
            Console.WriteLine(i);
        }
        

            Console.WriteLine("\n Peek item");
        Console.WriteLine(items.Peek());


        // remove item stack 

        Console.WriteLine("Pop Remove Top Item:");
         Item removed = items.Pop();
        Console.WriteLine("Removed Item: " + removed);





        Console.WriteLine("Items left in stack:");
        foreach (Item i in items)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine($"Total Items in Stack Now: {items.Count}");

        
        

        items.Clear();
        Console.WriteLine(" Stack Cleared!");
        Console.WriteLine("Remaining Count: " + items.Count);




    }
}

*/