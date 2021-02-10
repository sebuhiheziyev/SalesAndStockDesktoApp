using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_App
{
    class dbLink
    {
        public string Adres = System.IO.File.ReadAllText(@"D:\Stock Desktop App\databaseKey.txt");
    }
}
