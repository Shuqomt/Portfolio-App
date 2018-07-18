using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class PhotoshopRepository : IPhotoshopRepository
    {
        private List<Photoshop> _photoshop; //initalized in the constructor
        
        public PhotoshopRepository()  //constructor.
        {
            if(_photoshop == null)
            {
                InitializePhotoshop();
            }
       
        }

        private void InitializePhotoshop()
        {
            _photoshop = new List<Photoshop>
            {
                new Photoshop {Id=1, Name="TBox App Logo", ImageUrl="https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/95976366426549.5b15f283cb3a0.jpg", ImageDescription="Logo design for the tbox app", IsPersonal=false},
                new Photoshop {Id=2, Name="The Godfather", ImageUrl="https://mir-s3-cdn-cf.behance.net/project_modules/1400/d4267c57027647.59c56ff56ce4e.jpg", ImageDescription="Godfather mockup poster", IsPersonal=true},
                new Photoshop {Id=3, Name="Dust Studios LA Pt.1", ImageUrl="https://mir-s3-cdn-cf.behance.net/project_modules/1400/eb9fc367504115.5b3c0c786ca9d.jpg", ImageDescription="Inside Pamphlet Version 2 that showcases Stage Two", IsPersonal=false},
                new Photoshop {Id=4, Name="Dust Studios LA Pt.2", ImageUrl="https://mir-s3-cdn-cf.behance.net/project_modules/1400/a82a4f67504115.5b3c0c786d6b9.jpg", ImageDescription="Inside Pamphlet Version 2 that showcases Stage Two", IsPersonal=false},
                new Photoshop {Id=5, Name="Dust Studios LA Pt.3", ImageUrl="https://mir-s3-cdn-cf.behance.net/project_modules/1400/524c7167504115.5b3c0c786cfeb.jpg", ImageDescription="Front of Pamphlet", IsPersonal=false},
                new Photoshop {Id=6, Name="JRR Tolkien", ImageUrl="https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/cc3b3357027647.59c56ff53682a.jpg", ImageDescription="'Little By Litte One Travels Far'", IsPersonal=true},
            };

        }
        public IEnumerable<Photoshop> GetAllPhotoshop()
        {
            return _photoshop;        }

        public Photoshop GetPhotoshopById(int psdId)
        {
            return _photoshop.FirstOrDefault(p => p.Id == psdId);
        }
    }
}
 