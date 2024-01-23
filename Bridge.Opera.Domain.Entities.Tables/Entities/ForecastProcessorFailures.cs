using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Bridge.Opera.Domain.Entities.Tables
{
	public partial class ForecastProcessorFailures
	{
	    public string EventType { get; set; }
	    public string EventId { get; set; }
	    public string ErrorMessage { get; set; }
	    public DateTime TimeFailed { get; set; }
	    public string EventParameters { get; set; }
	
		public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
		{
			modelBuilder.Entity<ForecastProcessorFailures>(entity =>
	        {
	            entity.HasNoKey();
	
	            entity.ToTable("FORECAST_PROCESSOR_FAILURES");
	
	            entity.Property(e => e.ErrorMessage)
	                .IsRequired()
	                .HasColumnName("ERROR_MESSAGE")
	                .HasMaxLength(2000)
	                .IsUnicode(false);
	
	            entity.Property(e => e.EventId)
	                .IsRequired()
	                .HasColumnName("EVENT_ID")
	                .HasMaxLength(20)
	                .IsUnicode(false);
	
	            entity.Property(e => e.EventParameters)
	                .HasColumnName("EVENT_PARAMETERS")
	                .HasMaxLength(2000)
	                .IsUnicode(false);
	
	            entity.Property(e => e.EventType)
	                .IsRequired()
	                .HasColumnName("EVENT_TYPE")
	                .HasMaxLength(1)
	                .IsUnicode(false);
	
	            entity.Property(e => e.TimeFailed)
	                .HasColumnName("TIME_FAILED")
	                .HasColumnType("DATE");
	        });
		}
	}
}
	