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
        public IConfiguration configuration;
        public FileService(IConfiguration configurationKey)
        {
            configuration = configurationKey;
            this.Database.Migrate();
        }

        public DbSet<Contact> Contacts { get; set; }

        public async Task<Contact> AddContactAsync(Contact contact)
        {
            FileService fileService = new FileService(this.configuration);
            await fileService.Contacts.AddAsync(contact);
            await fileService.SaveChangesAsync();

            return contact;
        }


        public async Task<List<Contact>> SelectAllContactAsync()
        {
            FileService fileService= new FileService(this.configuration);

            return await fileService.Contacts.ToListAsync();
        }

        public async Task<Contact> UpdateContactAsync(Contact contact)
        {
            FileService fileService = new FileService(this.configuration);
            fileService.Contacts.Update(contact);
            await fileService.SaveChangesAsync();

            return contact;
        }
        public async Task<Contact> DeleteContactAsync(Contact contact)
        {
            FileService fileService = new FileService(this.configuration);
            fileService.Contacts.Remove(contact);
            await fileService.SaveChangesAsync();

            return contact;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var stringConnectionPath = this.configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(stringConnectionPath);
        }
    }
}
