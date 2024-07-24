using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CURD_ASP.net_MVC.Models
{
	public class Transaction
	{
		[Key]
        public int TransactionId { get; set; }
		[Column(TypeName = "nvarchar(12)")]
		public string AccountNumber { get; set; }

		[Column(TypeName ="nvarchar(100)")]
		public string UserName { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		public string BankName { get; set; }

		[Column(TypeName = "nvarchar(11)")]
		public string IFCCode { get; set; }	
		public int Balance { get; set; }
		public DateTime Date { get; set; }
    }
}
