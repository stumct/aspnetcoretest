using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnASPNETCore.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "555-555-5555";
        }
        
        public string Address()
        {
            return "USA";
        }
    }
}
