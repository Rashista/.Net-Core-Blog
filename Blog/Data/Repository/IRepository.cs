using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repository
{
    public interface IRepository
    {
        Post GetPost(int id);
        List<Post> GetAllPosts(int id);
        bool AddPost(Post post);
        bool RemovePost(int id);
        bool UpdatePost(Post post);
    }
}
