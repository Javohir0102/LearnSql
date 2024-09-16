using LearnSql.Model;
using LearnSql.Services;

namespace LearnSql
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            FileService fileService = new FileService();
            IContactService contactService = new ContactService(fileService);
            Contact contact = new Contact();

            contact.Id = Guid.NewGuid();
            contact.Name = "Javohir";
            contact.PhoneNumber = "1234567890";

            await contactService.AddContactAsync(contact);
        }
    }
}
