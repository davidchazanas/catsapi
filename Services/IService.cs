using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.StaticFiles;
using catsapi.Models;

namespace catsapi.Services
{
    public interface IService 
    {
        public Task<ActionResult<IEnumerable<Cat>>> GetCats();
    }
}

