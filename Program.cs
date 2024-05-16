using System;
using System.IO;
struct UserData
{
    public string Name;
    public int Age;
    public string Email;
}
class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\SEC\Desktop\exp10.txt";
        UserData[] ud=new UserData[3];
        for(int i=0; i<3;i++)
        {
            Console.WriteLine("Enter your name:");
            ud[i].Name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            ud[i].Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your email:");
            ud[i].Email = Console.ReadLine();

            WriteUserDataToFile(filePath, ud[i]);
        }  
        Console.WriteLine("User data has been saved to the file.");
    }

    static void WriteUserDataToFile(string filePath, UserData userData)
    {
        //using (FileStream fs = new FileStream(filePath, FileMode.Create))
        using (StreamWriter writer = File.AppendText(filePath))
        {
            writer.WriteLine($"Name: {userData.Name}");
            writer.WriteLine($"Age: {userData.Age}");
            writer.WriteLine($"Email: {userData.Email}");
        }
    }
}
