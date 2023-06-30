
using System.Diagnostics;

using Chronometer;

Chronometers chronometers = new Chronometers();

string command = "";

while ((command = Console.ReadLine()) != "exit")
{
    if(chronometers.Laps.Count == 0)
    {
        Console.WriteLine("Laps: no laps");
    }

    if (command == "start")
    {
        chronometers.Start();
    }
    else if (command == "stop")
    {
        chronometers.Stop();
    }
    else if (command == "lap")
    {
        Console.WriteLine(chronometers.Lap());
    }
    else if (command == "laps")
    {
        for (int i = 0; i < chronometers.Laps.Count; i++)
        {
            Console.WriteLine($"{i}. {chronometers.Laps[i]}");
        }
        
    }
    else if (command == "time")
    {

        TimeSpan ts = chronometers.stopWatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds,
        ts.Milliseconds);
        Console.WriteLine(elapsedTime);
    }
    else if (command == "reset")
    {
        chronometers.Reset();
    }


}