using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace Redcode.Awaiting.Demo
{
    public class AwaitRotateObjectExample : MonoBehaviour
    {
        private async void Start()
        {
            while (true)
            {
                await new WaitForUpdate();
                transform.Rotate(Vector3.up, 90f * Time.deltaTime);
            }
        }

    }
}