using CRMDomain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMData
{
   public class CRMContext :DbContext
   {
       #region Brand
       public DbSet<Brand> Brands { get; set; }

       #endregion

       #region Branch
       public DbSet<Branch> Branchs { get; set; }
       #endregion

       #region Event
       public DbSet<Event> Events { get; set; }
       #endregion

       #region Memeber
       public DbSet<Member> Memebers { get; set; }
       #endregion

       #region Vehicle
       public DbSet<Vehicle> Vehicles { get; set; }
       #endregion
       public virtual void Commit()
       {
           base.SaveChanges();
       }


       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

       }
   }
}
