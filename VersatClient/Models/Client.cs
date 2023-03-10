using Microsoft.Build.Framework;

namespace VersatClient.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required]
        public string Name { get; set; }
        public IEnumerable<Order> Orders { get; set; }

        public Client()
        {
        }

        public Client(int clientId, string name)
        {
            ClientId = clientId;
            Name = name;
        }
    }
}
