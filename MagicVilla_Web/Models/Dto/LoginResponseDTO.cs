using System;
namespace MagicVilla_Web.Models.Dto
{
	public class LoginResponseDTO
	{
		public UserDTO User { set; get; }
        public string Token { set; get; }
    }
}

