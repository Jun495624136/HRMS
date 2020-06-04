using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Config_question_second_kindConfiger:EntityTypeConfiguration<Config_question_second_kind>
    {
        public Config_question_second_kindConfiger() 
        {
            this.ToTable(nameof(Config_question_second_kind));
            this.Property(e=>e.First_kind_id).HasMaxLength(2);
            this.Property(e => e.Second_kind_id).HasMaxLength(2);
        }
    }
}
