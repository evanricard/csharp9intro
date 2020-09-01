using System;
using System.Threading.Tasks;

await MyAsyncMethod();
Console.WriteLine("Hello World!");

async Task MyAsyncMethod()
{
    await Task.Yield();
}
