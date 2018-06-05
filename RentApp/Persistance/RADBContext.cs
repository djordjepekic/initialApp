﻿using Microsoft.AspNet.Identity.EntityFramework;
using RentApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RentApp.Persistance
{
    public class RADBContext : IdentityDbContext<RAIdentityUser>
    {
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }

        public RADBContext() : base("name=RADB")
        {           
        }

        public static RADBContext Create()
        {
            return new RADBContext();
        }
    }
}