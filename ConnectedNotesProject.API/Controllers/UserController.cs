using ConnectedNotesProject.Bussiness.Abstract;
using ConnectedNotesProject.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectedNotesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<User>
    {
        public UserController(IGenericService<User> genericRepository) : base(genericRepository)
        {
        }
    }
}
