using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace safesurferbrowser.Database
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
