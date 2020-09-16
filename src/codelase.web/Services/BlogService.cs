using System;
using System.Collections.Generic;
using System.Linq;
using codelase.data.DatabaseContexts.ApplicationDbContext;
using codelase.data.Entities;
using codelase.web.Interface;
using codelase.web.Models.ApplicationModels;

namespace codelase.web.Services
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
                var blogPost = new BlogPost
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.Now,
                    IsDeleted = false,
                    Title = model.Title,
                    Category = model.Category,
                    Body = model.Body
                };
                _context.BlogPosts.Add(blogPost);
                // return food.Id;
            }
        }

        public IEnumerable<BlogPost> GetAllPosts()
        {
            IEnumerable<BlogPost> model = _context.BlogPosts.ToList();

            return model;
        }

        public BlogPost GetPost(Guid Id)
        {
            BlogPost model = _context.BlogPosts.FirstOrDefault(p => p.Id == Id);

            return model;
        }

        public bool RemovePost(Guid Id)
        {
            BlogPost model = _context.BlogPosts.FirstOrDefault(p => p.Id == Id);

            var blogPost = new BlogPost
            {
                DeletedAt = DateTime.Now,
                IsDeleted = true
            };
            _context.BlogPosts.Add(blogPost);

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