using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Redcode.Awaiting.Demo
{
    public class AwaitEnumerator : MonoBehaviour
    {
        private async void Start()
        {
            await TickEnumerator();
            print("Awaiting completed!");
        }

        private IEnumerator TickEnumerator()
        {
            for (int i = 0; i < 3; i++)
            {
                yield return new WaitForSeconds(1f);
                print("Tick!");
            }
        }
    }
}