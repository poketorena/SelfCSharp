using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    struct MyStruct
    {
        public string Message;
        public int Value;

        public MyStruct(string message, int value)
        {
            this.Message = message;
            this.Value = value;
        }
    }
}
