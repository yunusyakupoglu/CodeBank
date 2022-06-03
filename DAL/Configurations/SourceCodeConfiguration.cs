using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class SourceCodeConfiguration : EntityTypeConfiguration<SourceCode>
    {
        public SourceCodeConfiguration()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Title).HasColumnType("NVARCHAR").HasMaxLength(500);
            this.Property(x => x.Content).HasColumnType("NVARCHAR");
            this.HasRequired(x => x.Category).WithMany(x => x.SourceCodes).HasForeignKey(X => X.CategoryId);
        }
    }
}
