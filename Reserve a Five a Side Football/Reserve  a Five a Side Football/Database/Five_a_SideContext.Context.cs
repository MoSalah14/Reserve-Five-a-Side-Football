﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reserve__a_Five_a_Side_Football.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Reserve_a_Five_a_Side : DbContext
    {
        public Reserve_a_Five_a_Side()
            : base("name=Reserve_a_Five_a_Side")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Legaue> Legaues { get; set; }
        public virtual DbSet<Ownar> Ownars { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Stadium> Stadium { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}