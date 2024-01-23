using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Bridge.Opera.Domain.Entities.Views
{	
	public partial class OrmsBookingClasstypesDtls
	{
	    public string ClassType { get; set; }
	    public string AttributeCode { get; set; }
	    public string AttributeDesc { get; set; }
	    public decimal? SellSequence { get; set; }
	
		public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
		{
			modelBuilder.Entity<OrmsBookingClasstypesDtls>(entity =>
	        {
	            entity.HasNoKey();
	
	            entity.ToView("ORMS_BOOKING_CLASSTYPES_DTLS");
	
	            entity.Property(e => e.AttributeCode)
	                .HasColumnName("ATTRIBUTE_CODE")
	                .HasMaxLength(40)
	                .IsUnicode(false);
	
	            entity.Property(e => e.AttributeDesc)
	                .HasColumnName("ATTRIBUTE_DESC")
	                .HasMaxLength(2000)
	                .IsUnicode(false);
	
	            entity.Property(e => e.ClassType)
	                .HasColumnName("CLASS_TYPE")
	                .HasColumnType("CHAR(2)");
	
	            entity.Property(e => e.SellSequence)
	                .HasColumnName("SELL_SEQUENCE")
	                .HasColumnType("NUMBER");
	        });
		}
	}
}
	