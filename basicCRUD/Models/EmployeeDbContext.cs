﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace basicCRUD.Models
{
        public class EmployeeDbContext:DbContext
        {
            public EmployeeDbContext (DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        
        
            public DbSet<Employee> Employees { get; set; }

        }
    

}
