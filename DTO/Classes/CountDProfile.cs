using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DTO.Classes
{
    public class CountDProfile : Profile
    {
        public CountDProfile()
        {
            CreateMap<DAL.Models.Audience, Audience>().ReverseMap();
            CreateMap< Audience, DAL.Models.Audience>().ReverseMap();
            CreateMap<DAL.Models.Game, Game>().ReverseMap();
            CreateMap<DAL.Models.Gender, Gender>().ReverseMap();
            CreateMap<DAL.Models.HowKnown, HowKnown>().ReverseMap();
            CreateMap<DAL.Models.Setting, Settings>().ReverseMap();
            CreateMap<DAL.Models.TypeGame, TypeGame>().ReverseMap();
            CreateMap<DAL.Models.UserDetail, UserDetails>().ReverseMap();
            //CreateMap<DAL.Models.User, User>().ReverseMap();

            CreateMap<DAL.Models.User, User>()
                .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Details.FirstName)).ReverseMap();

            ////CreateMap<CommentsToRecipe, DAL.Models.CommentsToRecipe>();

            //CreateMap<DAL.Models.Ingredient, Ingredient>().ReverseMap();

            //CreateMap<DAL.Models.IngredientsToRecipe, IngredientsToRecipe>()
            //    .ForMember(dest => dest.IngredientName,
            //    opt => opt.MapFrom(src => src.Ingredient.Name)).ReverseMap();

            ////CreateMap<IngredientsToRecipe, DAL.Models.IngredientsToRecipe>();

            //CreateMap<DAL.Models.Level, Level>().ReverseMap();

            //CreateMap<DAL.Models.Recipe, Recipe>()
            //    .ForMember(dest => dest.UserName,
            //    opt => opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName))
            //    .ForMember(dest => dest.CategoryName,
            //    opt => opt.MapFrom(src => src.Category.Name))
            //    .ForMember(dest => dest.LevelName,
            //    opt => opt.MapFrom(src => src.Level.Name)).ReverseMap();

            ////CreateMap<Recipe, DAL.Models.Recipe>();

            //CreateMap<DAL.Models.User, User>().ReverseMap();
        }
    }
}
