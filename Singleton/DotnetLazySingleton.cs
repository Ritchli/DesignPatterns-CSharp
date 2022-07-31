using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 通过.net lazy实现的懒汉单例模式
    /// </summary>
    public sealed class DotnetLazySingleton
    {
        private DotnetLazySingleton()
        {

        }

        private static readonly Lazy<DotnetLazySingleton> dotnetlazy = new Lazy<DotnetLazySingleton>(()=>new DotnetLazySingleton());
        public static  DotnetLazySingleton Instance
        {
            get
            {
                return dotnetlazy.Value;
            }
        }

        public void Show()
        {
            Console.WriteLine("通过.net lazy实现的懒汉单例模式");
        }
    }
}
