using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace Redcode.Awaiting.Demo
{
    public class AwaitWebRequest : MonoBehaviour
    {
        private async void Start()
        {
            var request = UnityWebRequest.Get("google.com");
            await request.SendWebRequest();

            print(request.downloadHandler.text);
            print("Awaiting completed!");
        }
    }
}