using Newtonsoft.Json;
using System;
using System.IO; 
using System.Timers;
using Timer = System.Timers.Timer;

public  class MyTimer
{
    private static DateTime startTime;
    private static Timer timer;
    private static List<int> values = new List<int>(); 
    private static string folderPath = @"..\..\..\TrackingDb";
    private static string filePath = $@"{folderPath}\Time.json";
    
    static MyTimer()
    {
        timer = new Timer();
        timer.Elapsed += TimerElapsed;

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
    }

    public static void Start(double interval)
    {
        timer.Interval = interval;
        startTime = DateTime.Now;
        
        timer.Start();
    }

    public static void Stop()
    {
        timer.Stop();
        SaveData();
    }

    public static void AddValue(int value)
    {
        values.Add(value);
    }

    private static void TimerElapsed(object sender, ElapsedEventArgs e)
    {
       
        Random random = new Random();
        int newValue = random.Next(1, 100);
        AddValue(newValue);

        Console.WriteLine("Timer elapsed at: " + DateTime.Now.ToString("HH:mm:ss"));
    }

  
    public static void SaveData()
    {
        try
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            string jsonData = JsonConvert.SerializeObject(elapsedTime);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(jsonData);
            }

            Console.WriteLine("Data saved to file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving data: " + ex.Message);
        }
    }

}
