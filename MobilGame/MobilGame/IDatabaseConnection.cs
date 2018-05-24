using System;
using System.Collections.Generic;
using System.Text;

namespace MobilGame
{
   public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
