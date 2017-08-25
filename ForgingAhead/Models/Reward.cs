using System.ComponentModel.DataAnnotations;

namespace ForgingAhead.Models{
	  public class Reward{
	  	 [Key]
	  	 public int Id { get;set;}
		 
		 public int Value { get;set;}
		 
		 public string Description { get;set; }
		 
	}
}