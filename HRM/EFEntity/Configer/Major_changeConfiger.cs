using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Major_changeConfiger:EntityTypeConfiguration<Major_change>
    {
        public Major_changeConfiger() 
        {
            this.ToTable(nameof(Major_change));
            this.Property(e => e.First_kind_id).HasMaxLength(2);
            this.Property(e => e.Second_kind_id).HasMaxLength(2);
            this.Property(e => e.Third_kind_id).HasMaxLength(2);
            this.Property(e => e.Major_id).HasMaxLength(2);
            this.Property(e => e.Major_kind_id).HasMaxLength(2);
            this.Property(e => e.New_first_kind_id).HasMaxLength(2);
            this.Property(e => e.New_major_id).HasMaxLength(2);
            this.Property(e => e.New_third_kind_id).HasMaxLength(2);
            this.Property(e => e.New_second_kind_id).HasMaxLength(2);
            this.Property(e => e.New_major_kind_id).HasMaxLength(2);
        }
    }
}
