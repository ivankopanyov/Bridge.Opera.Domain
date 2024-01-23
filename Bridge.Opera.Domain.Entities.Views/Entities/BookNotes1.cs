using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Bridge.Opera.Domain.Entities.Views
{	
	public partial class BookNotes1
	{
	    public decimal NoteId { get; set; }
	    public string Resort { get; set; }
	    public decimal BookId { get; set; }
	    public string NoteCode { get; set; }
	    public string NoteTitle { get; set; }
	    public string InternalYn { get; set; }
	    public string Notes { get; set; }
	    public DateTime? InsertDate { get; set; }
	    public decimal InsertUser { get; set; }
	    public DateTime? UpdateDate { get; set; }
	    public decimal UpdateUser { get; set; }
	    public string LeadNoteYn { get; set; }
	    public decimal? MasterNoteId { get; set; }
	    public decimal? ExternalId { get; set; }
	    public string NoteDesc { get; set; }
	
		public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
		{
			modelBuilder.Entity<BookNotes1>(entity =>
	        {
	            entity.HasNoKey();
	
	            entity.ToView("BOOK_NOTES");
	
	            entity.Property(e => e.BookId)
	                .HasColumnName("BOOK_ID")
	                .HasColumnType("NUMBER")
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.ExternalId)
	                .HasColumnName("EXTERNAL_ID")
	                .HasColumnType("NUMBER")
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.InsertDate)
	                .HasColumnName("INSERT_DATE")
	                .HasColumnType("DATE")
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.InsertUser)
	                .HasColumnName("INSERT_USER")
	                .HasColumnType("NUMBER")
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.InternalYn)
	                .HasColumnName("INTERNAL_YN")
	                .HasMaxLength(1)
	                .IsUnicode(false)
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.LeadNoteYn)
	                .HasColumnName("LEAD_NOTE_YN")
	                .HasMaxLength(1)
	                .IsUnicode(false)
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.MasterNoteId)
	                .HasColumnName("MASTER_NOTE_ID")
	                .HasColumnType("NUMBER")
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.NoteCode)
	                .HasColumnName("NOTE_CODE")
	                .HasMaxLength(20)
	                .IsUnicode(false)
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.NoteDesc)
	                .HasColumnName("NOTE_DESC")
	                .HasMaxLength(100)
	                .IsUnicode(false);
	
	            entity.Property(e => e.NoteId)
	                .HasColumnName("NOTE_ID")
	                .HasColumnType("NUMBER")
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.NoteTitle)
	                .HasColumnName("NOTE_TITLE")
	                .HasMaxLength(200)
	                .IsUnicode(false)
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.Notes)
	                .HasColumnName("NOTES")
	                .HasMaxLength(2000)
	                .IsUnicode(false)
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.Resort)
	                .IsRequired()
	                .HasColumnName("RESORT")
	                .HasMaxLength(20)
	                .IsUnicode(false)
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.UpdateDate)
	                .HasColumnName("UPDATE_DATE")
	                .HasColumnType("DATE")
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.UpdateUser)
	                .HasColumnName("UPDATE_USER")
	                .HasColumnType("NUMBER")
	                .ValueGeneratedOnAdd();
	        });
		}
	}
}
	