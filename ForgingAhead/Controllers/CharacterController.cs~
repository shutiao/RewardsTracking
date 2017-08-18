using Microsoft.AspNetCore.Mvc;
using ForgingAhead.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ForgingAhead.Controllers{
	  public class CharacterController : Controller{
	  	 private readonly ApplicationDbContext _context;
		 public CharacterController(ApplicationDbContext context){
		 	_context = context;
			}
		public IActionResult Index(){
		       var model = _context.Characters.ToList();
		       return View("Index",model);
		       }
		 public IActionResult Create(Character character){
		 	_context.Characters.Add(character);
			_context.SaveChanges();
			return RedirectToAction("Index");
			}
		}
}