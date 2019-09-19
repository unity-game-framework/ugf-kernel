namespace UGF.Coroutine.Runtime
{
    public delegate void CoroutineHandler<in TResult>(ICoroutine<TResult> coroutine);
}
