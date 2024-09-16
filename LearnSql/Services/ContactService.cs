using LearnSql.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSql.Services
{
    public class ContactService : IContactService
    {
        private FileService fileServiceDb;
        public ContactService(FileService recivedFileService)
        {
            fileServiceDb = recivedFileService;
        }
        public async Task<Contact> AddContactAsync(Contact contact)
        {
            try
            {
                if (contact == null)
                {
                    throw new NullContactException("Bo'sh qiymat kiritilgan.");
                }
                return await fileServiceDb.AddContactAsync(contact);

            }
            catch (DbUpdateException ex)
            {
                throw new ContactStoreException( "Baza uxladi. biz bilan boglaning bu holatda", ex);
            }
        }

        public Task<Contact> RemoveContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> UpdateContactAsync(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
