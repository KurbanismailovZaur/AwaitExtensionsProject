using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Redcode.Awaiting;
public class Test : MonoBehaviour
{
    async void Start()
    {
        await new WaitForSeconds(1);
        print("Works!");
    }
}
