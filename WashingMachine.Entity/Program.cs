using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace WashingMachine.Entity
{
    class Program
    {
        private delegate void InvokeDelegate();

        static void Main(string[] args)
        {
            DateTime time;

            time = DateTime.Now;
            Console.WriteLine("Test 1");
            Console.WriteLine(time);

            time = DateTime.Today;
            Console.WriteLine("Test 2");
            Console.WriteLine(time);

            Console.ReadKey();
        }










        static async Task NoMain()
        {
            AppDomain.CurrentDomain.UnhandledException += (s, e) => Log("*** Crash! ***", "UnhandledException");
            TaskScheduler.UnobservedTaskException += (s, e) => Log("*** Crash! ***", "UnobservedTaskException");

            await RunTests();

            // Let async tasks complete...
            Thread.Sleep(500);
            GC.Collect(3, GCCollectionMode.Forced, true);
        }

        private static async Task RunTests()
        {
            try
            {
                // crash
                // _1_VoidNoWait();

                // crash 
                // _2_AsyncVoidAwait();

                // OK
                // _3_AsyncVoidAwaitWithTry();

                // crash - no await
                // _4_TaskNoWait();

                // crash - no await
                // _5_TaskAwait();

                // OK
                // await _4_TaskNoWait();

                // OK
                await _5_TaskAwait();
            }
            catch (Exception ex) { Log("Exception handled OK");}
            // crash - no try
            // await _4_TaskNoWait();

            // crash - no try
            // await _5_TaskAwait();
        }

        // Unsafe
        static void _1_VoidNoWait()
        {
            ThrowAsync();
        }

        // Unsafe
        static async void _2_AsyncVoidAwait()
        {
            await ThrowAsync();
        }

        // Safe
        static async void _3_AsyncVoidAwaitWithTry()
        {
            try { await ThrowAsync(); }
            catch (Exception ex) { Log("Exception handled OK"); }
        }

        // Safe only if caller uses await (or Result) inside a try
        static Task _4_TaskNoWait()
        {
            return ThrowAsync();
        }

        // Safe only if caller uses await (or Result) inside a try
        static async Task _5_TaskAwait()
        {
            await ThrowAsync();
        }

        // Helper that sets an exception asnychronously
        static Task ThrowAsync()
        {
            TaskCompletionSource<Task> tcs = new TaskCompletionSource<Task>();
            ThreadPool.QueueUserWorkItem(_ => tcs.SetException(new Exception("ThrowAsync")));
            return tcs.Task;
        }
        internal static void Log(string message, [CallerMemberName] string caller = "")
        {
            Console.WriteLine("{0}: {1}", caller, message);
        }
    }
}
