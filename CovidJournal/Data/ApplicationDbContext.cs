using CovidJournal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidJournal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CovidUser> CovidUser { get; set; }
        public DbSet<CovidEntry> CovidEntry { get; set; }
        public DbSet<Symptoms> Symptoms { get; set; }
    }
}
