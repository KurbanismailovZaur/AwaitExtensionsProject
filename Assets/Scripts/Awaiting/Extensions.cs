using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Runtime.CompilerServices;
using Numba.Awaiting.Engine;

public static class Extensions
{
    public static ManualAwaiter GetAwaiter(this YieldInstruction instructuion) => ExtensionsHelper.GetAwaiterForInstuction(instructuion);

    public static ManualAwaiter GetAwaiter(this CustomYieldInstruction instructuion) => ExtensionsHelper.GetAwaiterForInstuction(instructuion);

    public static ManualAwaiter GetAwaiter(this IEnumerator enumerator) => ExtensionsHelper.GetAwaiterForEnumerator(enumerator);

    public static ManualAwaiter<WWW> GetAwaiter(this WWW www) => ExtensionsHelper.GetAwaiterWithResultForInstuction(www);

    public static ManualAwaiter<AssetBundleRequest> GetAwaiter(this AssetBundleRequest request) => ExtensionsHelper.GetAwaiterWithResultForInstuction(request);

    public static async void CatchErrors(this Task task) => await task;
}