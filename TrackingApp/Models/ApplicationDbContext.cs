﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Microsoft.EntityFrameworkCore;
using UIKit;
using TrackingApp.Models;

namespace TrackingApp.Models
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<HoursSpent>().HasData(
            //        new HoursSpent { Id = 1, Name = "Jacob", Hours = 5, ProjectId = 1 }

            //        );
            //builder.Entity<Note>().HasData(
            //        new Note { Id = 1, Title = "New Note", Text = "This one is good", ProjectId = 1 },
            //        new Note { Id = 2, Title = "Receipt Note", Text = "This is good too", ProjectId = 1 }
            //        );
            //builder.Entity<Expense>().HasData(
            //        new Expense { Id = 1, Title = "Shingles", Cost = 25, ProjectId = 1 }
            //        );
            builder.Entity<Project>().HasData(
                    new Project { Id = 1, Title = "Roof", Mileage = 45, Budget = 5000, BudgetUsed = 1300 }
                    );
            //builder.Entity<Receipt>().HasData(
            //        new Receipt { Id = 1, Store = "Menards", Total = 100, ProjectId = 1 }
            //        );
            ;
        }

        public DbSet<Project> Projects { get; set; }

        //public DbSet<Expense> Expenses { get; set; }

        //public DbSet<Note> Notes { get; set; }

        //public DbSet<HoursSpent> HoursSpent { get; set; }

        //public DbSet<Receipt> Receipts { get; set; }
    }
}