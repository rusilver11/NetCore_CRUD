using NetCore_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_CRUD.Services
{
        public interface IUsersService
        {
            Task<bool> CreateUser(tbl_users.create_user user);
            Task<List<tbl_users>> GetUserList();
            Task<tbl_users> GetUser(int id);
            Task<tbl_users> UpdateUser(int id, tbl_users.create_user user);
            Task<bool> DeleteUser(int id);
        }
}
