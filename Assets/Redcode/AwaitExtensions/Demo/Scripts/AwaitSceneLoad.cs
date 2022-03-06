using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace Redcode.Awaiting.Demo
{
    public class AwaitSceneLoad : MonoBehaviour
    {
        [SerializeField]
        private string _sceneName;

        private async void Start()
        {
            await SceneManager.LoadSceneAsync(_sceneName);
        }
    }
}