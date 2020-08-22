using MobilePhone.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MobilePhone.Models
{
	public class PhoneContact : EntityBase
	{
		[Key]
		[Required]
		public string PhoneNumber { get; set; }

		[DefaultValue("Unnamed")]
		public string Name { get; set; }

		[DefaultValue(false)]
		public bool IsFavourite { get; set; }

		[DefaultValue("")]
		public string Notes { get; set; }
	}
}
