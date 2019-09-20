namespace UGF.Coroutines.Runtime
{
    public interface ICoroutine<out TResult> : ICoroutine
    {
        TResult Result { get; }

        new event CoroutineHandler<TResult> Completed;
    }
}
