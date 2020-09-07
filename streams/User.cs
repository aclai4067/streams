using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streams
{
    public class RootObject
    {
        public User[] Users { get; set; }
    }

    public class User
    {
        public string AccountNumber { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }

        [JsonProperty(PropertyName = "Paperless")]
        public bool isPaperless { get; set; }
    }
}
