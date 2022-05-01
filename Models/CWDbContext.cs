﻿using System.ComponentModel.DataAnnotations;
using CW2AD.Models;
using Microsoft.EntityFrameworkCore;

namespace CW2AD.Models
{
    public class CWDbContext : DbContext
    {

        public CWDbContext(DbContextOptions<CWDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<DVDCategory> DVDCategories { get; set; }
        public DbSet<DVDTitle> DVDTitles { get; set; }
        public DbSet<DVDCopy> DVDCopies { get; set; }
        public DbSet<LoanType> LoanTypes { get; set; }
        public DbSet<MembershipCategory> MembershipCategories { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<CastMember> CastMembers { get; set; }


        
    }
}