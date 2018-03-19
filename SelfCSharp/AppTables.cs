using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    static class AppTables
    {
        public static IEnumerable<Book> Books { get; private set; }

        // 静的コンストラクター
        static AppTables()
        {
            Books = new List<Book>
            {
                new Book
                {
                    Isbn="978-4-7981-3547-2",
                    Title="独習PHP",
                    Price=3200,
                    Publisher="翔泳社",
                    Published=new DateTime(2016,4,8)
                },

                new Book
                {
                    Isbn="978-4-7981-4402-3",
                    Title="独習ASP.NET",
                    Price=3200,
                    Publisher="翔泳社",
                    Published=new DateTime(2016,1,21)
                },

                new Book
                {
                    Isbn="978-4-7741-9130-0",
                    Title="Angularアプリケーションプログラミング",
                    Price=3200,
                    Publisher="技術評論社",
                    Published=new DateTime(2017,8,4)
                },

                new Book
                {
                    Isbn="978-4-7741-9030-3",
                    Title="C#ポケットリファレンス",
                    Price=1640,
                    Publisher="技術評論社",
                    Published=new DateTime(2016,6,20)
                },

                new Book
                {
                    Isbn="978-4-8222-5355-4",
                    Title="アプリを作ろう！VisualC#入門",
                    Price=2000,
                    Publisher="日経BP社",
                    Published=new DateTime(2017,8,24)
                }
            };
        }
    }
}
