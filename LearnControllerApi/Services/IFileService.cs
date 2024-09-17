using LearnSql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSql.Services
{
    public interface IFileService
    {
        Task<Contact> AddContactAsync(Contact contact);
        Task<List<Contact>> SelectAllContactAsync();
        Task<Contact> UpdateContactAsync(Contact contact);
        Task<Contact> DeleteContactAsync(Contact contact);
    }
}
