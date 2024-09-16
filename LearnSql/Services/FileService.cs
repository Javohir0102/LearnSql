using LearnSql.Model;
using Microsoft.EntityFrameworkCore;
using STX.EFxceptions.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSql.Services
{
    public class FileService : EFxceptionsContext, IFileService
    {
        public FileService()
        {
            this.Database.Migrate();
        }

        public DbSet<Contact> Contacts { get; set; }

        public async Task<Contact> AddContactAsync(Contact contact)
        {
            FileService fileService = new FileService();
            await fileService.Contacts.AddAsync(contact);
            await fileService.SaveChangesAsync();

            return contact;
        }


        public async Task<List<Contact>> SelectAllContactAsync()
        {
            FileService fileService= new FileService();

            return await fileService.Contacts.ToListAsync();
        }

        public async Task<Contact> UpdateContactAsync(Contact contact)
        {
            FileService fileService = new FileService();
            fileService.Contacts.Update(contact);
            await fileService.SaveChangesAsync();

            return contact;
        }
        public async Task<Contact> DeleteContactAsync(Contact contact)
        {
            FileService fileService = new FileService();
            fileService.Contacts.Remove(contact);
            await fileService.SaveChangesAsync();

            return contact;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConnectionPath = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LearnSqlDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            optionsBuilder.UseSqlServer(stringConnectionPath);
        }
    }
}
