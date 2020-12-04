using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DomainModels;

namespace TicketSystem.ServiceLayer
{
    public class UserService : IUserService
    {
        TicketDbEntities db = new TicketDbEntities();

        public Agent GetAgent(int id)
        {
            var details = db.Mappings.Where(x => x.AgentId == id).FirstOrDefault();
            Agent agent = db.Agents.Where(x => x.Id == details.AgentId).FirstOrDefault();
            return agent;
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User Login(string username)
        {
            var user = db.Users.Where(x => x.Emaild==username).FirstOrDefault();

            return user;
        }
    }
}
