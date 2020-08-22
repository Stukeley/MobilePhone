using Microsoft.EntityFrameworkCore;
using MobilePhone.Base;
using System;
using System.Linq;

namespace MobilePhone.Database
{
	public class NotesContext : DbContext
	{
		// Override the method so that DateAdded and DateLastModified are automatically updated
		public override int SaveChanges()
		{
			var entries = ChangeTracker.Entries().Where(e => e.Entity is EntityBase && (e.State == EntityState.Modified || e.State == EntityState.Added));

			foreach (var entry in entries)
			{
				if (entry.Entity is EntityBase entity)
				{
					entity.DateLastModified = DateTime.Now;
					if (entry.State == EntityState.Added)
					{
						entity.DateCreated = DateTime.Now;
					}
				}
			}

			return base.SaveChanges();
		}
	}
}
