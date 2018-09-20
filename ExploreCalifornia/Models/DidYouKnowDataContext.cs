using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExploreCalifornia.Models
{
    public class DidYouKnow
    {
        public long Id { get; set; }
        public string Description { get; internal set; }
    }

    public class DidYouKnowDataContext : DbContext
    {
        public DbSet<DidYouKnow> DidYouKnows { get; set; }
        static Random rnd = new Random();

        public DidYouKnowDataContext(DbContextOptions<DidYouKnowDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public IEnumerable<DidYouKnow> GetDidYouKnows()
        {
            //Dont use this for a lot of rows, you will regret it :) 
            return DidYouKnows.OrderBy(r => Guid.NewGuid()).Take(1);
        }
        
    }
}
