using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneWorld.Model;
using System.Data.Entity.ModelConfiguration;

namespace OneWorld.Data.Configuration
{
  public class SupplierConfiguration:EntityTypeConfiguration<Supplier>
    {
        public SupplierConfiguration():this("dbo")
        {
            
        }
        public SupplierConfiguration(string schema)
        {
            //Table
            ToTable("Supplier",schema);

            //PK
            HasKey(p => p.Id);

            //CompanyName
            Property(p => p.CompanyName).HasColumnName("CompanyName").HasColumnType("nvarchar").HasMaxLength(40).IsRequired();

            Property(p => p.CompanyName).IsRequired();
        }
    }
}
