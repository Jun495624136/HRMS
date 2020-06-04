using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Salary_standard_detailsConfiger:EntityTypeConfiguration<Salary_standard_details>
    {
        public Salary_standard_detailsConfiger() 
        {
            this.ToTable(nameof(Salary_standard_details));

        }
    }
}
