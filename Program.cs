
using System;
using System.IO;
using System.Threading;

class Program
{
    static string logFolder = @"C:\ReminderService\Logs";
    static string logFile = Path.Combine(logFolder, "ReminderLog.txt");

    static string[] messages =
    {
        "Time to drink water!",
        "Take a short break!",
        "Check your daily tasks!",
        "Keep learning and stay focused!",
        "Time to relax for a moment!"
    };

    static void Main()
    {
        Directory.CreateDirectory(logFolder);

        Console.WriteLine("REMINDER MESSAGE SERVICE");
        Console.WriteLine("------------------------");
        Console.WriteLine("Service Started...");
        Console.WriteLine("Reminder Interval: 5 Minutes");
        Console.WriteLine("Press Enter to Stop the Service.");
        Console.WriteLine();

        int index = 0;
        bool running = true;

        Thread worker = new Thread(() =>
        {
            while (running)
            {
                string message = messages[index];

                string log = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
                    + " : " + message;

                File.AppendAllText(logFile, log + Environment.NewLine);

                Console.WriteLine(log);

                index = (index + 1) % messages.Length;

                for (int i = 0; i < 300 && running; i++)
                {
                    Thread.Sleep(1000);
                }
            }
        });

        worker.Start();

        Console.ReadLine();
        running = false;

        worker.Join();

        Console.WriteLine();
        Console.WriteLine("Reminder Service Stopped.");
    }
}
