using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapisqlsv1.Models;

namespace webapisqlsv1.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class AuthorController : ControllerBase
  {

    private readonly ILogger<AuthorController> _logger;
    private readonly AuthorContext _context;

    public AuthorController(ILogger<AuthorController> logger, AuthorContext context)
    {
      _logger = logger;
      _context = context;
    }

    [HttpGet]
    public IEnumerable<AuthorModel> Get()
    {
      return _context.TblAuthor.ToArray();
    }
  }


}
