using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Redcode.Awaiting.Demo
{
    public class AwaitSeconds : MonoBehaviour
    {
        private async void Start()
        {
            await new WaitForSeconds(1f);
            print("Awaiting 1 second completed!");
        }
    }
}