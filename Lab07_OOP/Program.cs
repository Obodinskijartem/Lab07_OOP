using Lab07_OOP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "subscribers.bin");

        List<Subscriber> subscribers = ReadSubscribers(filePath);

        subscribers.Sort();

        Console.WriteLine("\nВідсортований список абонентів:");
        foreach (var subscriber in subscribers)
        {
            Console.WriteLine(subscriber.ToString());
        }
    }

    static List<Subscriber> ReadSubscribers(string filePath)
    {
        List<Subscriber> subscribers = new List<Subscriber>();

        try
        {
            using (BinaryReader br = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    string name = br.ReadString();
                    string phoneNumber = br.ReadString();
                    string address = br.ReadString();
                    int callMinutesPerMonth = br.ReadInt32();
                    int smsPerMonth = br.ReadInt32();
                    double monthlyFee = br.ReadDouble();
                    bool hasRoaming = br.ReadBoolean();
                    bool hasDataPlan = br.ReadBoolean();

                    Subscriber subscriber = new Subscriber(name, phoneNumber, address, callMinutesPerMonth, smsPerMonth, monthlyFee, 
                    hasRoaming, hasDataPlan);

                    subscribers.Add(subscriber);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при читанні файлу: {ex.Message}");
        }

        return subscribers;
    }
}