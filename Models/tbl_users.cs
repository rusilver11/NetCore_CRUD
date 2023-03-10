using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_CRUD.Models
{
    public class tbl_users
    {
        public long UserId { get; set; }
        public string NamaLengkap { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public char Status { get; set; }

        public class create_user
        {
            public string NamaLengkap { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public char Status { get; set; }
        }
    }
}
