using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proiectDaw.Data;
using proiectDaw.Models;
using proiectDaw.Models.DTOs;

namespace proiectDaw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        //ca sa accesam db avem nevoie de context
        private readonly Context _context;

       
    }
}
