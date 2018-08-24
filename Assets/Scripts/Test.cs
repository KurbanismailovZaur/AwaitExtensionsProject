using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using Numba.Await.Extensions;

namespace Numba.Await
{
	public class Test : MonoBehaviour 
	{
		private async void Awake()
		{
            await MyEnumerator();

            Log("Awaited!");
		}

        private IEnumerator MyEnumerator()
        {
            yield return new WaitForSeconds(1f);
            yield return 0;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
        }
    }
}