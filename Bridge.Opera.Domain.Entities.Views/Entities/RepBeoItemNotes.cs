using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Bridge.Opera.Domain.Entities.Views
{	
	public partial class RepBeoItemNotes
	{
	    public decimal ResourceBookId { get; set; }
	    public decimal ResourceEventId { get; set; }
	    public decimal ResourceResourceId { get; set; }
	    public string Internal { get; set; }
	    public string ResourceNoteTitle { get; set; }
	    public string ResourceNotes { get; set; }
	
		public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
		{
			modelBuilder.Entity<RepBeoItemNotes>(entity =>
	        {
	            entity.HasNoKey();
	
	            entity.ToView("REP_BEO_ITEM_NOTES");
	
	            entity.Property(e => e.Internal)
	                .HasColumnName("INTERNAL")
	                .HasMaxLength(1)
	                .IsUnicode(false);
	
	            entity.Property(e => e.ResourceBookId)
	                .HasColumnName("RESOURCE_BOOK_ID")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.ResourceEventId)
	                .HasColumnName("RESOURCE_EVENT_ID")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.ResourceNoteTitle)
	                .HasColumnName("RESOURCE_NOTE_TITLE")
	                .HasMaxLength(200)
	                .IsUnicode(false);
	
	            entity.Property(e => e.ResourceNotes)
	                .HasColumnName("RESOURCE_NOTES")
	                .HasMaxLength(2000)
	                .IsUnicode(false);
	
	            entity.Property(e => e.ResourceResourceId)
	                .HasColumnName("RESOURCE_RESOURCE_ID")
	                .HasColumnType("NUMBER");
	        });
		}
	}
}
	