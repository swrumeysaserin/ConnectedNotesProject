using ConnectedNotesProject.Bussiness.Abstract;
using ConnectedNotesProject.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedNotesProject.Bussiness.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserService
    {
        public UserRepository(Context database) : base(database)
        {
        }
    }
}
