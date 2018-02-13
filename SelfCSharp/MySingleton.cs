using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    class MySingleton
    {
        private static MySingleton instance = new MySingleton();

        private MySingleton() { }

        // あらかじめ用意しておいたインスタンスを取得
        public static MySingleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
