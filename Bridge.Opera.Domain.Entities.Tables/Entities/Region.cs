using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Bridge.Opera.Domain.Entities.Tables
{
	public partial class Region
	{
	    public string RegionCode { get; set; }
	    public string Description { get; set; }
	    public decimal? OrderBy { get; set; }
	    public decimal? InsertUser { get; set; }
	    public DateTime? InsertDate { get; set; }
	    public decimal? UpdateUser { get; set; }
	    public DateTime? UpdateDate { get; set; }
	    public string ChainCode { get; set; }
	
		public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
		{
			modelBuilder.Entity<Region>(entity =>
	        {
	            entity.HasKey(e => new { e.ChainCode, e.RegionCode })
	                .HasName("REGION_PK");
	
	            entity.ToTable("REGION");
	
	            entity.Property(e => e.ChainCode)
	                .HasColumnName("CHAIN_CODE")
	                .HasMaxLength(20)
	                .IsUnicode(false)
	                .ValueGeneratedOnAdd();
	
	            entity.Property(e => e.RegionCode)
	                .HasColumnName("REGION_CODE")
	                .HasMaxLength(3)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Description)
	                .IsRequired()
	                .HasColumnName("DESCRIPTION")
	                .HasMaxLength(100)
	                .IsUnicode(false);
	
	            entity.Property(e => e.InsertDate)
	                .HasColumnName("INSERT_DATE")
	                .HasColumnType("DATE");
	
	            entity.Property(e => e.InsertUser)
	                .HasColumnName("INSERT_USER")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.OrderBy)
	                .HasColumnName("ORDER_BY")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.UpdateDate)
	                .HasColumnName("UPDATE_DATE")
	                .HasColumnType("DATE");
	
	            entity.Property(e => e.UpdateUser)
	                .HasColumnName("UPDATE_USER")
	                .HasColumnType("NUMBER");
	        });
		}
	}
}
	