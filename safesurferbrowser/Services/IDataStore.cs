using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using safesurferbrowser.Models;

namespace safesurferbrowser.Services
{
    public interface IDataStore
    {
        Task<IEnumerable<AdminSettingsData>> GetContactsAsync();
        Task<AdminSettingsData> GetContact(int id);
        Task AddContact(AdminSettingsData admin);
        Task UpdateContact(AdminSettingsData admin);
        Task DeleteContact(AdminSettingsData admin);
    }
}
