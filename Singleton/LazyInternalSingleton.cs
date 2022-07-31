using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 内部类实现的饿汉模式
    /// </summary>
    public sealed class LazyInternalSingleton
    {
        static LazyInternalSingleton()
        {

        }
        private LazyInternalSingleton()
        {

        }

        public static LazyInternalSingleton Instance
        {
            get
            {
                return InteralClass.Instance;
            }
        }

        private class InteralClass
        {
            internal static readonly LazyInternalSingleton Instance = new LazyInternalSingleton();
        }

        public void Show()
        {
            Console.WriteLine("内部类实现的饿汉模式");
        }
    }
}
