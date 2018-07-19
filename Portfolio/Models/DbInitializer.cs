using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Photoshops.Any())
            {
                context.AddRange(
                new Photoshop { Name = "TBox App Logo", ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/95976366426549.5b15f283cb3a0.jpg", ImageDescription = "Logo design for the tbox app", IsPersonal = false },
                new Photoshop { Name = "The Godfather", ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/1400/d4267c57027647.59c56ff56ce4e.jpg", ImageDescription = "Godfather mockup poster", IsPersonal = true },
                new Photoshop { Name = "Dust Studios LA Pt.1", ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/1400/eb9fc367504115.5b3c0c786ca9d.jpg", ImageDescription = "Inside Pamphlet Version 2 that showcases Stage Two", IsPersonal = false },
                new Photoshop { Name = "Dust Studios LA Pt.2", ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/1400/a82a4f67504115.5b3c0c786d6b9.jpg", ImageDescription = "Inside Pamphlet Version 2 that showcases Stage Two", IsPersonal = false },
                new Photoshop { Name = "Dust Studios LA Pt.3", ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/1400/524c7167504115.5b3c0c786cfeb.jpg", ImageDescription = "Front of Pamphlet", IsPersonal = false },
                new Photoshop { Name = "JRR Tolkien", ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/cc3b3357027647.59c56ff53682a.jpg", ImageDescription = "'Little By Litte One Travels Far'", IsPersonal = true });
                context.SaveChanges();
            }
         
        }
    }
}
