using System;
using System.Collections.Generic;
using CodeLase.data.Entities;

namespace CodeLase.web.Interfaces
{
    public interface IBlogService
    {
        void AddPost(BlogModel model);

        List<BlogModel> GetAllPosts();

        BlogModel GetPost(Guid Id);

        bool RemovePost(Guid Id);

        bool UpdatePost(BlogModel model);

        bool SaveChanges();
    }
}