using JwtTokenTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtTokenTest.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController:ControllerBase
    {
        
        [HttpGet]
        [Route("GetData")]
        public string GetData() {
            return "Authenticated with JWT";
        }

        [HttpGet]
        [Route("Details")]
        public string Details()
        {
            return "Authenticated with JWT";
        }

        [HttpPost]
        [Route("AddUser")]
        public string AddUser(Users user)
        {
            return "User added with username " + user.Username;
        }
    }
}
