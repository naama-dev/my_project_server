using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class PostData:IPost
    {
        private readonly DataProjectContext _context;

        public PostData(DataProjectContext context)
        {
            _context = context;
        }
        public async Task<List<Post>> getAllPosts()
        {
            var posts = await _context.Post.ToListAsync();
            return posts;
        }
    }
}
