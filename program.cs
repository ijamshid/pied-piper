namespace PDP;

class a
{
    static void Main(string[] args)
    {
        Console.Write("Username:");
        string? username = Console.ReadLine();
        Console.Write("Password:");
        string? password = Console.ReadLine();

        try
        {
            ValidName(username);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        try
        {
            ValidName(password);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        if (username.Length != 0 && password.Length != 0)
        {
            Console.WriteLine("welcome to the system");
            Console.WriteLine("session has finished");
        }

    }
    static void ValidName(string name)
    {
        if (name is null)
        {
            throw new NullReferenceException("name should not be null");
        }
    }

}