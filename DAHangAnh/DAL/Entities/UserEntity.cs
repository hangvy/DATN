using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAHangAnh.DAL.Entities
{
    public class UserEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
    }
}
