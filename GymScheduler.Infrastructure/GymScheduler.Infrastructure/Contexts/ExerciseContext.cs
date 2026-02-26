using GymScheduler.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GymScheduler.Infrastructure.Contexts
{
    public class ExerciseContext : DbContext
    {
        public ExerciseContext(DbContextOptions<DbContext> options) : base(options)
        {
        }
        public DbSet<Exercise> Exercises { get; set; }
    }
}
