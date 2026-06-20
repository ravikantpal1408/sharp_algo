namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instanceObj;
        private static readonly object _lockObj = new();


        private Singleton()
        {

        }

        public static Singleton getInstance()
        {
            lock (_lockObj)
            {
                if (_instanceObj == null)
                {
                    _instanceObj = new Singleton();
                }

                return _instanceObj;
            }
        }
    }

    public class SingletonDoubleCheckLock
    {

        private static volatile SingletonDoubleCheckLock _instanceObj;
        private static readonly object _lock = new object();

        private SingletonDoubleCheckLock() { }

        public static SingletonDoubleCheckLock GetInstance()
        {
            // First Check: If it's not null, skip the lock entirely (Huge performance win!)
            if (_instanceObj == null)
            {
                lock (_lock)
                {
                    // Second Check: Now that we have the lock, 
                    // make sure another thread didn't beat us to it.
                    if (_instanceObj == null)
                    {
                        _instanceObj = new SingletonDoubleCheckLock();
                    }
                }
            }
            return _instanceObj;
        }
    }
}