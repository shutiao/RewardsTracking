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
		       // ViewData is a property of the controller
		       ViewData["Title"] = "Charatcers";
		       return View("Index",model);
		       }
		       
		 [HttpGet]
		 public IActionResult Create(){
		 	ViewData["Title"] = "Create";
		 	return View("Create");
			}
		       		       
		 public IActionResult Create(Character character){
		 	if(_context.Characters.Any(e => e.Name == character.Name))
				ModelState.AddModelError("Name","Name is already in use.");
		 	ViewData["Title"] = "Create";
			if(!ModelState.IsValid)
				return View(character);
		 	_context.Characters.Add(character);
			_context.SaveChanges();
			return RedirectToAction("Index");
			}
			
		[Route("Character/{id}/Details")]		
		public IActionResult Details(int id){
		       ViewData["Title"] = id + "'s Detail";
		       var model = _context.Characters.FirstOrDefault(e => e.Id == id);
		       return View("Details",model);
		       }
		      
		public IActionResult Edit(int id){
		       ViewData["Title"] = "Edit " + id;
		       var model = _context.Characters.FirstOrDefault(e => e.Id == id);
		       return View("Edit",model);
		       }

		public IActionResult Update(Character character){
		       ViewData["Title"] = "Update" + character.Name;
		       _context.Entry(character).State = EntityState.Modified;
		       _context.SaveChanges();	       
		       return RedirectToAction("Index");
		       }
		      
		public IActionResult Delete(string name){
		       ViewData["Title"] = "Delete " + name;
		       var entityD = _context.Characters.FirstOrDefault(e=>e.Name == name);
		       if(entityD != null){
		       		  _context.Characters.Remove(entityD);	
				  _context.SaveChanges();
				  }
			return RedirectToAction("Index");
			}
	}
}