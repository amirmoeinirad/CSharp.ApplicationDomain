// Amir Moeini Rad
// October 2025

// Main Concept: Application Domain (AppDomain) in .NET Framework.

// AppDomain provides an isolation boundary for security, reliability, and versioning,
// allowing multiple applications to run within a single process without affecting each other.
// This is a key .NET feature for managing application execution.

// This example only works with .NET Framework, as AppDomain is not supported in .NET Core and later versions.

using System;

namespace ApplicationDomain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("AppDomain in .NET.");
            Console.WriteLine("------------------\n");


            // Get the current application domain.
            AppDomain currentDomain = AppDomain.CurrentDomain;
            Console.WriteLine("Hello from the current AppDomain: {0}", currentDomain.FriendlyName);


            // The AppDomain class represents an application domain,
            // which is an isolated environment where applications execute.
            AppDomain newDomain = AppDomain.CreateDomain("NewAppDomain");

            
            // DoCallBack allows executing code within
            // the context of the specified AppDomain.
            newDomain.DoCallBack(() => 
            {
                Console.WriteLine("\nHello from inside the new AppDomain!");
            });


            // Unload the AppDomain
            AppDomain.Unload(newDomain);


            Console.WriteLine("\nDone.");
        }
    }
}
