using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using System.IO;
using SQLite;
using safesurferbrowser.Database;
using safesurferbrowser.iOS;
using safesurferbrowser.iOS.Database;

[assembly: Dependency(typeof(SQLiteDb))]
namespace safesurferbrowser.iOS.Database
{
    class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}