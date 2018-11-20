using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using DatingApp.API.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IDatingRepository _repo;
		private readonly IMapper _mapper;
		public UsersController(IDatingRepository repo, IMapper mapper)
		{
			_mapper = mapper;
			_repo = repo;
		}

		[HttpGet]
		public async Task<IActionResult> GetUsers()
		{
			return Ok(_mapper.Map<IEnumerable<UserForListDto>>(await _repo.GetUsers()) );
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetUser(int id)
		{
			return Ok(_mapper.Map<UserForDetailsDto>(await _repo.GetUser(id)) );
		}

	}
}