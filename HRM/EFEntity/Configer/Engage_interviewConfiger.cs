using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Engage_interviewConfiger:EntityTypeConfiguration<Engage_interview>
    {
        public Engage_interviewConfiger() 
        {
            this.ToTable(nameof(Engage_interview));
            this.Property(e => e.Human_major_kind_id).HasMaxLength(2);
            this.Property(e => e.Human_major_id).HasMaxLength(2);
        }
    }
}
