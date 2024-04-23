using System;
namespace MagicVilla_VillaAPI.Models.Dto
{
	public class LoginResponseDTO
	{
		public LocalUser User { set; get; }
        public string Token { set; get; }
    }
}

