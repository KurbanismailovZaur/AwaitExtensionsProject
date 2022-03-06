using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace Redcode.Awaiting.Demo
{
    public class AwaitRepeatPrintExample : MonoBehaviour
    {
        private async void Start()
        {
            await PrintMessage(1f, 3, "Hello Await Extensions!");
            print("Awaiting completed.");
        }

        private async Task PrintMessage(float delay, int count, string message)
        {
            while (count-- != 0)
            {
                await Task.Delay(1000);
                print(message);
            }
        }
    }
}