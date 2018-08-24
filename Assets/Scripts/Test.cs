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
            await new WaitForSeconds(1f);

            Log("Awaited!");
		}
	}
}