using AutoMapper;
using CodeLase.data.Entities;
using CodeLase.web.Models.DTOs;

namespace CodeLase.web.Profiles
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            //Source --> Target
            CreateMap<BlogModel, ReadBlogDTO> ();
            CreateMap<CreateBlogDTO, BlogModel> ();
        }
    }
}