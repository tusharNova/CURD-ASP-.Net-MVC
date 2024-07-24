using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CURD_ASP.net_MVC.Models
{
	public class Transaction
	{
		[Key]
        public int TransactionId { get; set; }
		[Column(TypeName = "nvarchar(12)")]
		[DisplayName("Account Number")]
		[Required]
		public string AccountNumber { get; set; }

		[Column(TypeName ="nvarchar(100)")]
		[DisplayName("User Number")]
		[Required]
		public string UserName { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("Bank Name")]
		[Required]
		public string BankName { get; set; }

		[Column(TypeName = "nvarchar(11)")]
		[DisplayName("IFC-Code")]
		[Required]
		public string IFCCode { get; set; }
		[DisplayName("Balance")]
		[Required]
		public int Balance { get; set; }

		public DateTime Date { get; set; }
    }
}
