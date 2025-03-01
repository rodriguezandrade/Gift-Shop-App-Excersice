﻿using SS.Mvc.GiftShopApp.Core.Models;
using SS.Mvc.GiftShopApp.Core.Models.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Mvc.GiftShopApp.Core.Repository.Interfaces
{
    public interface IUserRepository
    {
        UserDto GetUserByEmail(string email);
        User GetUserByName(string username);
        UserDto GetIdentity(int userId);
        List<User> GetUsers();

        void AddUser(User user);
    }
}
