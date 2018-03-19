using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    // 文字列長をカウントするためのCounterクラス

    class Counter
    {
        public int Result { get; private set; }
        public void AddLength(string value)
        {
            Result += value.Length;
        }
    }
}
