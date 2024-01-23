using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Bridge.Opera.Domain.Entities.Tables
{
	public partial class OperaRepQueueTable
	{
	    public string QName { get; set; }
	    public Guid Msgid { get; set; }
	    public string Corrid { get; set; }
	    public decimal? Priority { get; set; }
	    public decimal? State { get; set; }
	    public DateTime? Delay { get; set; }
	    public decimal? Expiration { get; set; }
	    public DateTime? TimeManagerInfo { get; set; }
	    public decimal? LocalOrderNo { get; set; }
	    public decimal? ChainNo { get; set; }
	    public decimal? Cscn { get; set; }
	    public decimal? Dscn { get; set; }
	    public DateTime? EnqTime { get; set; }
	    public decimal? EnqUid { get; set; }
	    public string EnqTid { get; set; }
	    public DateTime? DeqTime { get; set; }
	    public decimal? DeqUid { get; set; }
	    public string DeqTid { get; set; }
	    public decimal? RetryCount { get; set; }
	    public string ExceptionQschema { get; set; }
	    public string ExceptionQueue { get; set; }
	    public decimal? StepNo { get; set; }
	    public decimal? RecipientKey { get; set; }
	    public Guid? DequeueMsgid { get; set; }
	
		public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
		{
			modelBuilder.Entity<OperaRepQueueTable>(entity =>
	        {
	            entity.HasKey(e => e.Msgid)
	                .HasName("SYS_C0037406");
	
	            entity.ToTable("OPERA_REP_QUEUE_TABLE");
	
	            entity.HasIndex(e => e.TimeManagerInfo)
	                .HasName("AQ$_OPERA_REP_QUEUE_TABLE_T");
	
	            entity.HasIndex(e => new { e.QName, e.Corrid })
	                .HasName("OPERAREPCORRID_IDX");
	
	            entity.HasIndex(e => new { e.QName, e.State, e.EnqTime, e.StepNo, e.ChainNo, e.LocalOrderNo })
	                .HasName("AQ$_OPERA_REP_QUEUE_TABLE_I");
	
	            entity.Property(e => e.Msgid)
	                .HasColumnName("MSGID")
	                .ValueGeneratedNever();
	
	            entity.Property(e => e.ChainNo)
	                .HasColumnName("CHAIN_NO")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.Corrid)
	                .HasColumnName("CORRID")
	                .HasMaxLength(128)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Cscn)
	                .HasColumnName("CSCN")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.Delay)
	                .HasColumnName("DELAY")
	                .HasColumnType("TIMESTAMP(6)");
	
	            entity.Property(e => e.DeqTid)
	                .HasColumnName("DEQ_TID")
	                .HasMaxLength(30)
	                .IsUnicode(false);
	
	            entity.Property(e => e.DeqTime)
	                .HasColumnName("DEQ_TIME")
	                .HasColumnType("TIMESTAMP(6)");
	
	            entity.Property(e => e.DeqUid)
	                .HasColumnName("DEQ_UID")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.DequeueMsgid).HasColumnName("DEQUEUE_MSGID");
	
	            entity.Property(e => e.Dscn)
	                .HasColumnName("DSCN")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.EnqTid)
	                .HasColumnName("ENQ_TID")
	                .HasMaxLength(30)
	                .IsUnicode(false);
	
	            entity.Property(e => e.EnqTime)
	                .HasColumnName("ENQ_TIME")
	                .HasColumnType("TIMESTAMP(6)");
	
	            entity.Property(e => e.EnqUid)
	                .HasColumnName("ENQ_UID")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.ExceptionQschema)
	                .HasColumnName("EXCEPTION_QSCHEMA")
	                .HasMaxLength(30)
	                .IsUnicode(false);
	
	            entity.Property(e => e.ExceptionQueue)
	                .HasColumnName("EXCEPTION_QUEUE")
	                .HasMaxLength(30)
	                .IsUnicode(false);
	
	            entity.Property(e => e.Expiration)
	                .HasColumnName("EXPIRATION")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.LocalOrderNo)
	                .HasColumnName("LOCAL_ORDER_NO")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.Priority)
	                .HasColumnName("PRIORITY")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.QName)
	                .HasColumnName("Q_NAME")
	                .HasMaxLength(30)
	                .IsUnicode(false);
	
	            entity.Property(e => e.RecipientKey)
	                .HasColumnName("RECIPIENT_KEY")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.RetryCount)
	                .HasColumnName("RETRY_COUNT")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.State)
	                .HasColumnName("STATE")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.StepNo)
	                .HasColumnName("STEP_NO")
	                .HasColumnType("NUMBER");
	
	            entity.Property(e => e.TimeManagerInfo)
	                .HasColumnName("TIME_MANAGER_INFO")
	                .HasColumnType("TIMESTAMP(6)");
	        });
		}
	}
}
	