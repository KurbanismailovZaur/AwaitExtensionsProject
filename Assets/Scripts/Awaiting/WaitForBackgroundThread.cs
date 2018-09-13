using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Runtime.CompilerServices;
using System;

/// <summary>
/// This class can be awaited.
/// Run code after awaiting in background thread.
/// </summary>
public class WaitForBackgroundThread
{
    public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
    {
        var task = new Task(() => { });
        task.Start();

        return task.ConfigureAwait(false).GetAwaiter();
    }
}