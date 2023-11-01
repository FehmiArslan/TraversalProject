using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Lütfen adınızı giriniz")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen soyanızı giriniz")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Lütfen mail adınızı giriniz")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen Şifrenizi giriniz")]
		public string Password { get; set; }


		[Compare("Password",ErrorMessage ="Şifreler   uyumlu değildir")] //Karşılaştırma için Compare'yi kullandık
		[Required(ErrorMessage = "Lütfen Şifrenizi tekrar giriniz")]
		public string ConfirmPassword { get; set; }

	}

}
