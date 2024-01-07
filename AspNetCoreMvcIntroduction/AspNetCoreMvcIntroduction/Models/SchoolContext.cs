using AspNetCoreMvcIntroduction.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Models
{
    public class SchoolContext:DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {
            //connection string mapping vb configler burada
        }



        public DbSet<Student> Students { get; set; }




    }
}
