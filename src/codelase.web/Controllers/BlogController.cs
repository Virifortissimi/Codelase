using System;
using System.Collections.Generic;
using AutoMapper;
using CodeLase.data.Entities;
using CodeLase.web.Interfaces;
using CodeLase.web.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CodeLase.web.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _repo;
        private readonly IMapper _mapper;

        public BlogController(
            IBlogService repo,
            IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadBlogDTO>> Index()
        {
            try
            {
                var result = _repo.GetAllPosts();

                var allBlogs = _mapper.Map<IEnumerable<ReadBlogDTO>>(result);
            
                return View(allBlogs);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(CreateBlogDTO model)
        {
            try
            {
                var blogModel = _mapper.Map<BlogModel>(model);
                _repo.AddPost(blogModel);
                _repo.SaveChanges();

                return View();
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
        }
    }
}