using System;

namespace Piranha
{
    public interface IDistributedLockService
    {
        bool TryAcquireLock(string lockId, TimeSpan duration);
        bool ReleaseLock(string lockId);
    }
}
