using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace Redcode.Awaiting.Demo
{
    public class AwaitBackgroundThread : MonoBehaviour
    {
        private async void Start()
        {
            print($"This message was printed in main thread [ID: {Thread.CurrentThread.ManagedThreadId}].");

            // After this line all instructions will be executed in background thread.
            // It is not allowed to use Unity API in background thread.
            await new WaitForBackgroundThread();

            print($"Run HeavyCalculation method in background thread [ID: {Thread.CurrentThread.ManagedThreadId}].");
            var result = HeavyCalculations();

            // After this line all instructions will be executed in main thread.
            // You can use Unity API after this line.
            await new WaitForUpdate();

            print($"Calculated value: {result}. Thread [ID: {Thread.CurrentThread.ManagedThreadId}]");
        }

        private double HeavyCalculations()
        {
            // Emulate heavy calculations.
            Task.Delay(3000).Wait();
            return new System.Random().NextDouble();
        }
    }
}