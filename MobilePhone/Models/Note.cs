using MobilePhone.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobilePhone.Models
{
	[Table("MobilePhone.Notes")]
	public class Note : EntityBase
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[DefaultValue("No title")]
		public string Title { get; set; }

		[Required(AllowEmptyStrings = false)]
		public string Content { get; set; }

		public Note() : base()
		{
		}
	}
}
