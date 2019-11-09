using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photo_fs_api.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int UserId { get; set; }

        public int ShootId { get; set; }

        public string Path { get; set; }

    }
}
