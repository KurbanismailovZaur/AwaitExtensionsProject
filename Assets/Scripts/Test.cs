using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Threading;

namespace Numba.Await
{
	public class Test : MonoBehaviour 
	{
		private async void Awake()
		{
            await new WaitForSeconds(1f);

            Log($"Main Thread: {Thread.CurrentThread.ManagedThreadId}");

            await new WaitForBackgroundThread();

            Log($"Background Thread {Thread.CurrentThread.ManagedThreadId}");

            await new WaitForUpdate();

            Log($"Main Thread: {Thread.CurrentThread.ManagedThreadId}");

            await new WaitForBackgroundThread();

            Log($"Background Thread {Thread.CurrentThread.ManagedThreadId}");
        }

        private void Update()
        {
            Log("Update");
        }
    }
}