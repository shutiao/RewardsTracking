using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForgingAhead.Models{
	  public class Character{
	  	 [Key]
		 public string Name { get;set; }
		 }
}