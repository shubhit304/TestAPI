using Test.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Test.WebAPI.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult GetAll()
        {
            var allUsers = _unitOfWork.Users.GetAll();
            return Ok(allUsers);
        }
    }
}
