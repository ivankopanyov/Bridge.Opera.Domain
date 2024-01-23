using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Bridge.Opera.Domain.Entities.Tables
{
	public partial class AqCachedMemQTabL
	{
	    public Guid? Msgid { get; set; }
	    public decimal? Subscriber { get; set; }
	    public string Name { get; set; }
	    public decimal? Address { get; set; }
	    public DateTimeOffset? DequeueTime { get; set; }
	    public string TransactionId { get; set; }
	    public string DequeueUser { get; set; }
	    public byte[] Flags { get; set; }
	
		public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
		{
			modelBuilder.Entity<AqCachedMemQTabL>(entity =>
	        {
	            entity.HasNoKey();
	
	            entity.ToTable("AQ$_CACHED$_MEM_Q_TAB_L");
	
	            entity.Property(e => e.Address)
	                .HasColumnName("ADDRESS#")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.DequeueTime)
	                .HasColumnName("DEQUEUE_TIME")
	                .HasColumnType("TIMESTAMP(6) WITH TIME ZONE");
	
	            entity.Property(e => e.DequeueUser)
	                .HasColumnName("DEQUEUE_USER")
	                .HasMaxLength(30)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Flags)
	                .HasColumnName("FLAGS")
	                .HasMaxLength(1);
	
	            entity.Property(e => e.Msgid).HasColumnName("MSGID");
	
	            entity.Property(e => e.Name)
	                .HasColumnName("NAME")
	                .HasMaxLength(30)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Subscriber)
	                .HasColumnName("SUBSCRIBER#")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.TransactionId)
	                .HasColumnName("TRANSACTION_ID")
	                .HasMaxLength(30)
	                .IsUnicode(false);
	        });
		}
	}
}
	