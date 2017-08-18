using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForgingAhead.Models{
	  public class Character{
	  	 [Key]
		 public string Name { get;set; }
		 [Display(Name = "Is Active")]
		 public bool IsActive { get;set; }
		 public int Level { get;set; }
		 }
}