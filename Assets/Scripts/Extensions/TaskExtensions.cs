using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;

public static class TaskExtensions
{
    public static async void CatchErrors(this Task task) => await task;
}