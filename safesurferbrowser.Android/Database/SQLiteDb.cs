using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using safesurferbrowser.Database;
using safesurferbrowser.Droid;
using safesurferbrowser.Droid.Database;

using SQLite;
using Xamarin.Forms;


[assembly: Dependency(typeof(SQLiteDb))]
namespace safesurferbrowser.Droid.Database
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}