﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Finex.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FinexAlmondzEntities : DbContext
    {
        public FinexAlmondzEntities()
            : base("name=FinexAlmondzEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CardTypeMaster> CardTypeMasters { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DocumentTypeMaster> DocumentTypeMasters { get; set; }
        public DbSet<DocumentUpload> DocumentUploads { get; set; }
        public DbSet<LossTypeMaster> LossTypeMasters { get; set; }
        public DbSet<OTP> OTPs { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<StatusMaster> StatusMasters { get; set; }
        public DbSet<UserMaster> UserMasters { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<CityMaste> CityMastes { get; set; }
        public DbSet<CountryMaster> CountryMasters { get; set; }
        public DbSet<StateMaster> StateMasters { get; set; }
        public DbSet<PolicyMaster> PolicyMasters { get; set; }
        public DbSet<MailTemplate> MailTemplates { get; set; }
        public DbSet<ClaimReverseFeed> ClaimReverseFeeds { get; set; }
        public DbSet<CardLossPolicyMapping> CardLossPolicyMappings { get; set; }
        public DbSet<IntimationTransaction> IntimationTransactions { get; set; }
    }
}