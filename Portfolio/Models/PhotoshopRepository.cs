using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class PhotoshopRepository :IPhotoshopRepository
    {
        private readonly AppDbContext _appDbContext;

        public PhotoshopRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Photoshop> GetAllPhotoshop()
        {
            return _appDbContext.Photoshops;
        }

        public Photoshop GetPhotoshopById(int psdId)
        {
            return _appDbContext.Photoshops.FirstOrDefault(p => p.Id == psdId);
        }
    }
}
