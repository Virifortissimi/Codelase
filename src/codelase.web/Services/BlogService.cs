using System;
using System.Collections.Generic;
using System.Linq;
using CodeLase.data.DatabaseContext;
using CodeLase.data.Entities;
using CodeLase.web.Interfaces;

namespace CodeLase.web.Services
{
    public class BlogService : IBlogService
    {
        private readonly ApplicationDbContext _context;

        public BlogService(
            ApplicationDbContext context
        )
        {
            _context = context;
        }
        public void AddPost(BlogModel model)
        {
            if (model != null)
            {
                var blogPost = new BlogModel
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    Title = model.Title,
                    Category = model.Category,
                    Body = model.Body
                };
                _context.Blogs.Add(blogPost);
            }
        }

        public List<BlogModel> GetAllPosts()
        {
            return _context.Blogs.ToList();
        }

        public BlogModel GetPost(Guid Id)
        {
            BlogModel model = _context.Blogs.FirstOrDefault(p => p.Id == Id);

            return model;
        }

        public bool RemovePost(Guid Id)
        {
            BlogModel model = _context.Blogs.FirstOrDefault(p => p.Id == Id);

            var blog = new BlogModel
            {
                DeletedAt = DateTime.Now,
                IsDeleted = true
            };
            _context.Blogs.Add(blog);

            return true;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public bool UpdatePost(BlogModel model)
        {
            throw new System.NotImplementedException();
            //if (model != null)
            // {
            //     var blogPost = new BlogPost
            //     {
            //         Id = Guid.NewGuid(),
            //         CreatedAt = DateTime.Now,
            //         IsDeleted = false,
            //         Title = model.Title,
            //         Category = model.Category,
            //         Body = model.Body
            //     };
            //     _context.BlogPosts.Add(blogPost);
            //     // return food.Id;
            // }
        }
    }
}