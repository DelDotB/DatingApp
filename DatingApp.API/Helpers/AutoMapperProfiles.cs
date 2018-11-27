using System.Linq;
using AutoMapper;
using DatingApp.API.DTOs;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
	public class AutoMapperProfiles : Profile
	{
		public AutoMapperProfiles()
		{
			CreateMap<User, UserForListDto>()
			.ForMember(dest => dest.PhotoUrl, opt =>
			{
				opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
			})
			.ForMember(dest => dest.Age, opt => {
				opt.MapFrom(d => d.DateOfBirth.CalculateAge());
			});
			
			CreateMap<User, UserForDetailsDto>()
			.ForMember(dest => dest.PhotoUrl, opt =>
			{
				opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
			})
			.ForMember(dest => dest.Age, opt => {
				opt.MapFrom(d => d.DateOfBirth.CalculateAge());
			});
			CreateMap<Photo, PhotosForDetailsDto>();
			CreateMap<UserForUpdateDto, User>();
			CreateMap<Photo, PhotoForReturnDto>();
			CreateMap<PhotoForCreationDto, Photo>();
			CreateMap<UserForRegisterDto, User>();
		}
	}
}