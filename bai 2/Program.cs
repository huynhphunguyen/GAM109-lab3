using System;

public class Program
{
    static void Main(string[] args)
    {
        string username = "nguyen";
        string password = "212321";
        string time = "23/1/2100";

        var sw = new StringWriter();
        sw.WriteLine("Username: " + username);
        sw.WriteLine("Password: " + password);

        var content = sw.ToString();
        //"Username: 1\nPassword: 123\n"
        var sr = new StringReader(content);
        string line1 = sr.ReadLine();
        Console.WriteLine("Line1: " + line1);
        string line2 = sr.ReadLine();
        Console.WriteLine("line2: " + line2);
        Console.WriteLine(sr.ReadLine());
    }
}