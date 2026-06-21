namespace Singleton
{

    public class Singleton
    {
        private static Singleton _instance;
        private Singleton() { }
        public static Singleton getInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    public class SingletonSynchronized
    {
        private static SingletonSynchronized _instanceObj;
        private static readonly object _lockObj = new();


        private SingletonSynchronized()
        {

        }

        public static SingletonSynchronized getInstance()
        {
            lock (_lockObj)
            {
                if (_instanceObj == null)
                {
                    _instanceObj = new SingletonSynchronized();
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
            if (_instanceObj == null)
            {
                lock (_lock)
                {

                    if (_instanceObj == null)
                    {
                        _instanceObj = new SingletonDoubleCheckLock();
                    }
                }
            }
            return _instanceObj;
        }
    }




    public sealed class SingletonBillBugh
    {

        private static SingletonBillBugh CreateInstance()
        {
            return new SingletonBillBugh();
        }


        private static readonly Lazy<SingletonBillBugh> _lazy = new Lazy<SingletonBillBugh>(CreateInstance);


        private SingletonBillBugh()
        {
            Console.WriteLine("SingletonBillBugh initialized.");
        }


        public static SingletonBillBugh Instance
        {
            get
            {
                return _lazy.Value;
            }
        }
    }


}