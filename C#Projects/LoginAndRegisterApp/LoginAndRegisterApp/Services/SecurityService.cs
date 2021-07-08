using LoginAndRegisterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAndRegisterApp.Services
{
    public class SecurityService
    {

  
        usersDAO usersDAO = new usersDAO();

        public SecurityService()
        {
          
        }
        public bool IsValid(UserModel user) 
        {
            return usersDAO.FindUserByNameAndPassword(user);
         
        }

    }
}
