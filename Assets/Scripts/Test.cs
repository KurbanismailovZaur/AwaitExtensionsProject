using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Threading;
using UnityEngine.SceneManagement;

namespace Numba
{
	public class Test : MonoBehaviour 
	{
		private async void Awake()
		{

            await MyEnum();
            Log("Awaited!");
        }

        private IEnumerator MyEnum()
        {
            yield return new WaitForSeconds(1f);
            yield return 1;
        }
    }
}