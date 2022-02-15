using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Module08Lesson12ApiDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Module08Lesson12ApiDB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory httpClientFactory;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            this.httpClientFactory = httpClientFactory; // this makes it so you can go to URLs
        }

        public async Task OnGet()
        {
            await CreateContact();
            await GetAllContacts();
        }

        private async Task CreateContact()
        {
            ContactModel contact = new ContactModel
            {
                FirstName = "John",
                LastName = "Doe",
            };

            contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "John@iamJohn.com" });
            contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "me@John.com" });
            contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" });
            contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1234" });

            var client = this.httpClientFactory.CreateClient();
            var response = await client.PostAsync(
                "https://localhost:44369/api/Contacts",
                new StringContent(JsonSerializer.Serialize(contact), Encoding.UTF8, "application/json"));
        }

        private async Task GetAllContacts()
        {
            var client = this.httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44369/api/Contacts");

            List<ContactModel> contacts;

            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                string responseText = await response.Content.ReadAsStringAsync();
                contacts = JsonSerializer.Deserialize<List<ContactModel>>(responseText, options);
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
