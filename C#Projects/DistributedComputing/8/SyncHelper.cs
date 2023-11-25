using System.Threading;

class SyncHelper
{
    private Semaphore semaphore = new Semaphore(0, 1);
    private Mutex mutex = new Mutex();

    public void WaitSemaphore()
    {
        semaphore.WaitOne();
    }

    public void ReleaseSemaphore()
    {
        semaphore.Release();
    }

    public void WaitMutex()
    {
        mutex.WaitOne();
    }

    public void ReleaseMutex()
    {
        mutex.ReleaseMutex();
    }
}
