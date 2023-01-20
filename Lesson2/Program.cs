using System.Diagnostics;

uint Factarial(uint value)
{
    if (value == 0)
        return 1;

    return value * Factarial(value - 1);
}

uint FactarialIter(uint value)
{
    uint a = 1;

    for(uint i = 1; i <= value; i++)
        a *= i;
    
    return a;
}

uint N = 100000;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
Factarial(N);
stopWatch.Stop();

TimeSpan ts = stopWatch.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}.{4:00}",
    ts.Hours, ts.Minutes, ts.Seconds,
    ts.Milliseconds / 10, ts.Ticks);
Console.WriteLine("RunTime " + elapsedTime);

stopWatch = new Stopwatch();
stopWatch.Start();
FactarialIter(N);
stopWatch.Stop();

ts = stopWatch.Elapsed;
elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}.{4:00}",
    ts.Hours, ts.Minutes, ts.Seconds,
    ts.Milliseconds / 10, ts.Ticks);
Console.WriteLine("RunTime " + elapsedTime);