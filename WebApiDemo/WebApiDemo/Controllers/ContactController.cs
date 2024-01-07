using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController:ControllerBase
    {

        [HttpGet("")]
        public List<ContactModel> Get()
        {

            return new List<ContactModel>
            {
                new ContactModel
                {
                    Id = 1 ,FirstName = "Burak",LastName="Doğan"
                }
            };
        }

        




    }
}
