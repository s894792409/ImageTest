using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ImageTest.Models
{
    public class ImageTestContext : DbContext
    {
        public ImageTestContext (DbContextOptions<ImageTestContext> options)
            : base(options)
        {
        }

        public DbSet<ImageTest.Models.UserInfo> UserInfo { get; set; }
    }
}
