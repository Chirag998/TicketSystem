using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DomainModels;

namespace TicketSystem.ServiceLayer
{
   public interface IUserService
    {
        List<User> GetUsers();
        User Login(string username);
        Agent GetAgent(int id);
    }
}
