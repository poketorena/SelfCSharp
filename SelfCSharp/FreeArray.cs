using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    class FreeArray
    {
        private int _size; // 配列サイズ
        private int[] _list; // 配列本体

        // コンストラクター（フィールドを初期化）
        public FreeArray(int size)
        {
            this._size = size;
            this._list = new int[size];
        }

        // インデクサー
        public int this[int index]
        {
            set
            {
                this._list[this.GetIndex(index)] = value;
            }
            get
            {
                return this._list[this.GetIndex(index)];
            }
        }

        // インデックス値を再計算するprivateメソッド
        private int GetIndex(int index)
        {
            // 0未満の値は強制的に0で再設定
            if (index < 0)
            {
                return 0;
            }

            // 元のインデックス値と配列サイズの剰余でインデックス値を再設定
            // （配列サイズが3で指定地が4ならば、新しいインデックス値は1）
            return index % this._size;
        }
    }
}
