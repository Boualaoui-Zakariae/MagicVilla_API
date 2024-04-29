using System;
namespace MagicVilla_Web.Models.Dto
{
	public class RegistrationRequestDTO
	{
        public string UserName { set; get; }
        public string Name { set; get; }
        public string Password { set; get; }
        public string Role { set; get; }
    }
}

