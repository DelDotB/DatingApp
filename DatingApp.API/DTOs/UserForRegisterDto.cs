using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; 
		  }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify passwd between 4-8 chars")]
        public string  Password { get; set; }

        [Required]
		  public string Gender { get; set; }

        [Required]
		  public string KnownAs { get; set; }

        [Required]
		  public DateTime DateOfBirth { get; set; }

        [Required]
		  public string City { get; set; }

        [Required]
		  public string Country { get; set; }

		  public DateTime Created { get; set; }
		  
		  public DateTime LastActive { get; set; }

		  public UserForRegisterDto()
		  {
				Created = DateTime.Now;
				LastActive = DateTime.Now;
		  }

    }
}