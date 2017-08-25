using Microsoft.EntityFrameworkCore;
using ForgingAhead.Models;

using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ForgingAhead.Controllers{
	  public class HomeController : Controller{
       	  	 private readonly ApplicationDbContext _context;
		 public HomeController(ApplicationDbContext context){
		 	_context = context;
			}
		public IActionResult Index(){
		       ViewData["Title"] = "Show All Active";
		       var model = _context.Characters.Where(e => e.IsActive).ToList();	
		       return View("Index",model);
		       }
				
	}
}