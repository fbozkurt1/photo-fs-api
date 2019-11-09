using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photo_fs_api.Models
{
    public class ContactRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        
        public string Message { get; set; }

        public DateTime CreatedAt { get; set; }


    }

    public class ContactRequestInput
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public string CreatedAt { get; set; }

    }
}
