﻿using Microsoft.EntityFrameworkCore;

namespace CURD_ASP.net_MVC.Models
{
	public class TransactionDbContext :DbContext
	{
		public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options) 
		{ }

		public DbSet<Transaction> Transactions { get; set; }
	}
}
