using DAL.Interface;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class PhotoData:IPhoto
    {

        private readonly DataProjectContext _context;

        public PhotoData(DataProjectContext context)
        {
            _context = context;
        }
        public async Task<List<Photo>> getAllPhotos()
        {
            var photos = await _context.Photo.ToListAsync();
            return photos;
        }
    }
}
