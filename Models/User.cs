using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace photo_fs_api.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public short Role { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; }
    }

    public class UserInput
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public short Role { get; set; }

        public string CreatedAt { get; set; }

        public bool IsActive { get; set; }
    }
}
