using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exam_piit.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public int Status { get; set; }
    }
}