using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;

namespace ForgingAhead.Models{
	  public class Character{
	  	 [Key]
		 public int Id { get;set;}
	  	 
		 public string Name { get;set; }

		 [Required]
		 [Display(Name = "Is Active")]
		 public bool IsActive { get;set; }

		 [Range(1,20)]
		 public int Level { get;set; }
		 
		 		 
		 public List<Reward> Rewards { get; set; } = new List<Reward>();

		 public int TotalRewards { get { return Rewards.Sum(e => e.Value); } }
	}
}