using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Runtime.CompilerServices;
using Numba.Awaiting.Engine;

public static class Extensions
{
    #region Yield instruction extensions
    public static TaskAwaiter GetAwaiter(this YieldInstruction instructuion) => ExtensionsHelper.GetAwaiterForInstuction(instructuion);

    public static TaskAwaiter GetAwaiter(this CustomYieldInstruction instructuion) => ExtensionsHelper.GetAwaiterForInstuction(instructuion);
    #endregion

    #region Wait instructions extensions
    public static TaskAwaiter GetAwaiter(this WaitForEndOfFrame waitForEndOfFrame) => GetAwaiter((YieldInstruction)waitForEndOfFrame);

    public static TaskAwaiter GetAwaiter(this WaitForFixedUpdate waitForFixedUpdate) => GetAwaiter((YieldInstruction)waitForFixedUpdate);

    public static TaskAwaiter GetAwaiter(this WaitForSeconds waitForSeconds) => GetAwaiter((YieldInstruction)waitForSeconds);

    public static TaskAwaiter GetAwaiter(this WaitForSecondsRealtime waitForSecondsRealtime) => GetAwaiter((CustomYieldInstruction)waitForSecondsRealtime);

    public static TaskAwaiter GetAwaiter(this WaitUntil waitUntil) => GetAwaiter((CustomYieldInstruction)waitUntil);

    public static TaskAwaiter GetAwaiter(this WaitWhile waitWhile) => GetAwaiter((CustomYieldInstruction)waitWhile);
    #endregion

    public static TaskAwaiter GetAwaiter(this IEnumerator enumerator) => ExtensionsHelper.GetAwaiterForEnumerator(enumerator);

    public static TaskAwaiter<WWW> GetAwaiter(this WWW www) => ExtensionsHelper.GetAwaiterForInstuctionAsResult(www);

    public static TaskAwaiter<AssetBundleRequest> GetAwaiter(this AssetBundleRequest request) => ExtensionsHelper.GetAwaiterForInstuctionAsResult(request);

    public static async void CatchErrors(this Task task) => await task;
}