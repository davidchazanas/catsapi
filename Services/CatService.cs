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
    public class CatService : IService
    {
        private readonly CatContext _context;

        public CatService(CatContext ctx) {
            _context = ctx;
        }
        
        public async Task<ActionResult<IEnumerable<Cat>>> GetCats()
        {          
            return await _context.Gatos?.ToListAsync();
        }

    }
}