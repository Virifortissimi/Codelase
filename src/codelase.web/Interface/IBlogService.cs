using System;
using System.Collections.Generic;
using codelase.data.Entities;
using codelase.web.Models.ApplicationModels;

namespace codelase.web.Interface
{
    public interface IBlogService
    {
        void AddPost(BlogModel model);

        IEnumerable<BlogPost> GetAllPosts();

        BlogPost GetPost(Guid Id);

        bool RemovePost(Guid Id);

        bool UpdatePost(BlogModel model);

        bool SaveChanges();
    }
}