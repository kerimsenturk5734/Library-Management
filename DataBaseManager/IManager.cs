using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;

namespace Kütüphane_Otomasyon.DataBaseManager
{
    internal interface IManager
    {
        void select();
        void add();
        void delete();
        void update();
    }
}