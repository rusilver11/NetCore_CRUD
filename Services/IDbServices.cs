﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_CRUD.Services
{
        public interface IDbService
        {
            Task<T> GetAsync<T>(string command, object parms);
            Task<List<T>> GetAll<T>(string command, object parms);
            Task<int> EditData(string command, object parms);
        }
}
