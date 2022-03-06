using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Threading;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using Redcode.Awaiting;

namespace Redcode
{
    public class Test : MonoBehaviour
    {
        [SerializeField]
        private Transform _cube;

        [SerializeField]
        private CanvasGroup _canvasGroup;

        private void Start()
        {
        }
    }
}