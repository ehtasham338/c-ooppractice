// exception handlin abuse 

/*

using System;
public class LoginException : Exception
{
    public LoginException(string message) : base(message)
    {



    }

    public LoginException(string message, Exception inner) : base(message, inner)
    {

    }
}

public class Loginsystem
{
    public  static void Login(string username, string password)
    {
        try
        {

            bool dbFail = false;
            if (dbFail)
            {
                throw new Exception("Database connection failed");
            }


            if (username != "admin" || password != "1234")
            {
                throw new LoginException("Invalid username or password");
            }

            Console.WriteLine("Login successful!");
        }
        catch (Exception ex)
        {

            throw new LoginException("Login failed due to system error.", ex);
        }
    }
}
   

   class Program
{
    static void Main(string[] args)
    {
        try
        {
            
            Loginsystem.Login("admin", "wrongpassword");
        }
        catch (LoginException ex)
        {
            Console.WriteLine("Login Error: " + ex.Message);

            
            if (ex.InnerException != null)
            {
                Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
            }
        }
        finally
        {
            Console.WriteLine("Login process finished.");
        }
    }
}


*/
 
