﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quotation.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuotationEntities : DbContext
    {
        public QuotationEntities()
            : base("name=QuotationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<q1765_jsf> q1765_jsf { get; set; }
        public virtual DbSet<q1765_jszlf> q1765_jszlf { get; set; }
        public virtual DbSet<q1765_psf> q1765_psf { get; set; }
        public virtual DbSet<q1765_rdf> q1765_rdf { get; set; }
        public virtual DbSet<q1765_wgcpj> q1765_wgcpj { get; set; }
        public virtual DbSet<q1765_yfcl> q1765_yfcl { get; set; }
        public virtual DbSet<q1765_zb> q1765_zb { get; set; }
    }
}
