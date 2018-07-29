using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
//using SQLite.CodeFirst;

namespace Quotation.Models
{
    public class DataContext : DbContext
    {
        public DataContext(string connectionString)
            : base(connectionString)
        {

        }
        public DataContext(System.Data.Common.DbConnection connection)
            : base(connection, true)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Project>().ToTable("Programmer").HasKey(p => p.ID);
            ////modelBuilder.Entity<ProjectManager>().ToTable("ProjectManager").HasKey(p => p.ID);
            //Database.SetInitializer(new SqliteCreateDatabaseIfNotExists<DataContext>(modelBuilder));
        }

        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<q1765_zb> q1765_zb { get; set; }
        public virtual DbSet<q1765_jsf> q1765_jsf { get; set; }
        public virtual DbSet<q1765_jszlf> q1765_jszlf { get; set; }
        public virtual DbSet<q1765_psf> q1765_psf { get; set; }
        public virtual DbSet<q1765_rdf> q1765_rdf { get; set; }
        public virtual DbSet<q1765_wgcpj> q1765_wgcpj { get; set; }
        public virtual DbSet<q1765_yfcl> q1765_yfcl { get; set; }

    }
}
