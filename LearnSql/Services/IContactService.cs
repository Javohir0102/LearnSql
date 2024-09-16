using LearnSql.Model;

namespace LearnSql.Services
{
    public interface IContactService
    {
        Task<Contact> AddContactAsync(Contact contact);
        Task<Contact> UpdateContactAsync(Contact contact);
        Task<Contact> RemoveContactAsync(Contact contact);
    }
}