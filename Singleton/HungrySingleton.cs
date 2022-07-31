namespace Singleton
{

    /// <summary>
    /// 双重验证的懒汉模式
    /// </summary>
    public sealed class HungrySingleton
    {
        private static HungrySingleton? instance = null;
        private static object obj = new object();

        public static HungrySingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new HungrySingleton();
                        }
                    }
                }

                return instance;
            }
        }

        private HungrySingleton()
        {

        }

        public void Show()
        {
            Console.WriteLine("双重验证的饿汉单例模式");
        }
    }
}