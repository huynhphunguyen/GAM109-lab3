using System;



public class Program
{


    static void create(string path)
    {
        
        Directory.CreateDirectory(path);

        string filePath = Path.Combine(path, "data.txt");
        StreamWriter streamWriter = new StreamWriter(path);
        streamWriter.WriteLine("Mssv: 10647");
        streamWriter.WriteLine("Ho va ten: huynh nguyen");
        streamWriter.Dispose();

    }

    static void copy(string soucrePath, string destinationPath)
    {
        if (Directory.Exists(soucrePath) == false)
        {
            Directory.CreateDirectory(destinationPath);

            string[] fileList = Directory.GetFiles(soucrePath);
            foreach (string file in fileList)
            {
                File.Copy(file, destinationPath, true);
            }
        }
    }
    static void Main(string[] args)
    {
        string path1 = "data1";
        string path2 = "data2";
        create(path1);
        copy(path1, path2);
    }
}
