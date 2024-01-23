using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Bridge.Opera.Domain.Entities.Tables
{
	public partial class GuestLookupAddress
	{
	    public decimal LookupSeqId { get; set; }
	    public string AddressType { get; set; }
	    public string LanguageCode { get; set; }
	    public string Address1 { get; set; }
	    public string Address2 { get; set; }
	    public string Address3 { get; set; }
	    public string Address4 { get; set; }
	    public string City { get; set; }
	    public string State { get; set; }
	    public string Country { get; set; }
	    public string ZipCode { get; set; }
	    public string SpgMailingsYn { get; set; }
	
	    public virtual GuestLookup LookupSeq { get; set; }
	
		public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
		{
			modelBuilder.Entity<GuestLookupAddress>(entity =>
	        {
	            entity.HasNoKey();
	
	            entity.ToTable("GUEST_LOOKUP_ADDRESS");
	
	            entity.HasIndex(e => e.LookupSeqId)
	                .HasName("GUEST_LOOKUP_ADDRESS_FKI");
	
	            entity.Property(e => e.Address1)
	                .HasColumnName("ADDRESS1")
	                .HasMaxLength(80)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Address2)
	                .HasColumnName("ADDRESS2")
	                .HasMaxLength(80)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Address3)
	                .HasColumnName("ADDRESS3")
	                .HasMaxLength(80)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Address4)
	                .HasColumnName("ADDRESS4")
	                .HasMaxLength(80)
	                .IsUnicode(false);
	
	            entity.Property(e => e.AddressType)
	                .IsRequired()
	                .HasColumnName("ADDRESS_TYPE")
	                .HasMaxLength(20)
	                .IsUnicode(false);
	
	            entity.Property(e => e.City)
	                .HasColumnName("CITY")
	                .HasMaxLength(40)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Country)
	                .HasColumnName("COUNTRY")
	                .HasMaxLength(20)
	                .IsUnicode(false);
	
	            entity.Property(e => e.LanguageCode)
	                .IsRequired()
	                .HasColumnName("LANGUAGE_CODE")
	                .HasMaxLength(20)
	                .IsUnicode(false);
	
	            entity.Property(e => e.LookupSeqId)
	                .HasColumnName("LOOKUP_SEQ_ID")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.SpgMailingsYn)
	                .HasColumnName("SPG_MAILINGS_YN")
	                .HasMaxLength(1)
	                .IsUnicode(false);
	
	            entity.Property(e => e.State)
	                .HasColumnName("STATE")
	                .HasMaxLength(40)
	                .IsUnicode(false);
	
	            entity.Property(e => e.ZipCode)
	                .HasColumnName("ZIP_CODE")
	                .HasMaxLength(15)
	                .IsUnicode(false);
	
				if (!types.Contains(typeof(GuestLookup)))
					entity.Ignore(e => e.LookupSeq);
				else
		            entity.HasOne(d => d.LookupSeq)
		                .WithMany()
		                .HasForeignKey(d => d.LookupSeqId)
		                .HasConstraintName("GUEST_LOOKUP_ADDRESS_FK");
	        });
		}
	}
}
	