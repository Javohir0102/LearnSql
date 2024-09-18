using LearnSql.Model;
using LearnSql.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearnControllerApi.Controllers
{
    [ApiController]
    [Route("api/contacts")]
    public class ContactsController : ControllerBase
    {
        public IContactService contactService;
        public ContactsController(IContactService contactService)
        {
            this.contactService = contactService;
        }
        [HttpGet]
        public async Task<List<Contact>> GetAllContactsAsync()
        {
            return await contactService.GetAllContactsAsync();
        }

        [HttpPost]
        public async Task<Contact> PostMessage([FromBody] Contact contact)
        {
            return await contactService.AddContactAsync(contact);
        }

        [HttpPut]
        public async Task<Contact> PutMessage([FromBody] Contact contact)
        {
            return await contactService.UpdateContactAsync(contact);
        }

        [HttpDelete]
        public async Task<Contact> DeleteContact([FromBody] Contact contact)
        {
            return await contactService.RemoveContactAsync(contact);
        }
    }
}
