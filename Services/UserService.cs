using NetCore_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_CRUD.Services
{
    public class UserService : IUsersService
    {
        private readonly IDbService _dbService;

        public UserService(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<bool> CreateUser(tbl_users.create_user user)
        {
            
                await _dbService.EditData(
                    "INSERT INTO public.tbl_users (namalengkap, username, password, status) VALUES (@NamaLengkap, @UserName, @Password, @Status)",
                    user);

            return true;
        }

        public async Task<List<tbl_users>> GetUserList()
        {
            var userList = await _dbService.GetAll<tbl_users>("SELECT * FROM public.tbl_users", new { });
            return userList;
        }


        public async Task<tbl_users> GetUser(int id)
        {
            var userList = await _dbService.GetAsync<tbl_users>("SELECT * FROM public.tbl_users where userid=@id", new { id });
            return userList;
        }

        public async Task<tbl_users> UpdateUser(int id, tbl_users.create_user user)
        {
            await _dbService.EditData(
                    $"Update public.tbl_users SET namalengkap=@NamaLengkap, username=@UserName, password=@Password, status=@Status WHERE userid = {id}",
                    user);

            var userList = await _dbService.GetAsync<tbl_users>("SELECT * FROM public.tbl_users where userid = @id", new { id });

            return userList;
        }

        public async Task<bool> DeleteUser(int id)
        {
            await _dbService.EditData("DELETE FROM public.tbl_users WHERE userid = @id", new { id });
            return true;
        }
    }
}
