using System;


public class Program
{
    static void Main(string[] args)
    {
        string path = "C:\\Users\\nhom\\Documents\\examle.txt";
        using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("Username: myUserName");
                sw.WriteLine("Password: myPassWord");
            }
          }
       using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader sr = new StreamReader(fs))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        }
    }
