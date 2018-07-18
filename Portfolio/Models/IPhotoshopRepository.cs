using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public interface IPhotoshopRepository
    {
        IEnumerable<Photoshop> GetAllPhotoshop();
        Photoshop GetPhotoshopById(int psdId);
    }
}
