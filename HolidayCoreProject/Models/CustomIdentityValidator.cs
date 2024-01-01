using Microsoft.AspNetCore.Identity;

namespace HolidayCoreProject.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"parola minimum {length} karakter olmalıdır"
			};

		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = $"parola 1 buyuk harf icermelidir"
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = $"parola 1 kucuk harf icermelidir"
			};
		}
	}
}
