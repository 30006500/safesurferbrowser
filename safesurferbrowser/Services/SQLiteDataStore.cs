using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using safesurferbrowser.Database;
using safesurferbrowser.Models;
using System.IO;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace safesurferbrowser.Services
{
    public class SQLiteDataStore : IDataStore
    {
        private SQLiteAsyncConnection _connection;
        public SQLiteDataStore(ISQLiteDb db)
        {
            _connection = db.GetConnection();
            _connection.CreateTableAsync<AdminSettingsData>();
        }
        public async Task<IEnumerable<AdminSettingsData>> GetContactsAsync()
        {
            return await _connection.Table<AdminSettingsData>().ToListAsync();
        }
        public async Task DeleteContact(AdminSettingsData admin)
        {
            await _connection.DeleteAsync(admin);
        }
        public async Task AddContact(AdminSettingsData admin)
        {
            await _connection.InsertAsync(admin);
        }
        public async Task UpdateContact(AdminSettingsData admin)
        {
            await _connection.UpdateAsync(admin);
        }
        public async Task<AdminSettingsData> GetContact(int id)
        {
            return await _connection.FindAsync<AdminSettingsData>(id);
        }
    }

}
