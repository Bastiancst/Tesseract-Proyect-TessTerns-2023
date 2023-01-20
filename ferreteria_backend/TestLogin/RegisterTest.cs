using AutoMapper;
using Azure;
using ferreteria_backend;
using ferreteria_backend.Controllers;
using ferreteria_backend.Data;
using ferreteria_backend.Models;
using ferreteria_backend.Models.DTO;
using ferreteria_backend.Repository;
using ferreteria_backend.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Reflection.Metadata;
using Azure.Identity;



namespace Testing
{
    public class RegisterandLoginTest

    {
        private readonly UserRepository _userRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        
        public RegisterandLoginTest()
        {
            _userRepository = new UserRepository(_db, _roleManager, _userManager, _mapper);
        }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestRegister()
        {

            var register = _userRepository.Register(new RegisterationRequestDTO { Email = "testeregister@gmail.com", Password = "Test.123", Role = "admin" });
            Assert.IsNotNull(register.IsCompleted);
        }
        [Test]
        public void TestLogin()
        {
            var login = _userRepository.Login(new LoginRequestDTO { Email = "testeregister@gmail.com", Password = "Test.123" });
            Assert.IsNotNull(login.IsCompleted);
        }
    }
}
