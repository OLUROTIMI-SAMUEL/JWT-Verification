using Application.Contract;
using Application.DTO;
using BCrypt.Net;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    internal class UserRepository : IUser
    {
        private readonly AppDbContext appDbContext;
        private readonly IConfiguration configuration;

        public UserRepository(AppDbContext appDbContext, IConfiguration configuration)
        {
            this.appDbContext = appDbContext;
            this.configuration = configuration;
        }
        public async Task<LoginResponse> LoginUserAsync(LoginDTO loginDTO)
        {
            //  throw new NotImplementedException();

            //  var getUser = await appDbContext.Users.FirstOrDefaultAsync(u => u.Email == loginDTO.Email);
            var getUser = await FindUserByEmail(loginDTO.Email!);
            if (getUser == null) return new LoginResponse(false, "User Not Found Sorry");

            bool checkPassword = BCrypt.Net.BCrypt.Verify(loginDTO.Password, getUser.Password);
            if (checkPassword)
                return new LoginResponse(true, "Login Successfull", GenerateJWTToken(getUser));
            else
                return new LoginResponse(false, "Invalid Credentials");
            
        }

        private string GenerateJWTToken(ApplicationUser user)
        {
            // throw new NotImplementedException();
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!));
           var credentails = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var userClaims = new[]
            {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.Email),
            };
            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                claims: userClaims,
                expires: DateTime.Now.AddDays(5),
                signingCredentials: credentails

            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private async Task< ApplicationUser> FindUserByEmail(string email) =>
            await appDbContext.Users.FirstOrDefaultAsync(u => u.Email == email);

        public async Task<RegistrationResponse> RegisterUserAsync(RegisterUserDTO registrationUserDTO)
        {
            // throw new NotImplementedException();

            var getUser = await FindUserByEmail(registrationUserDTO.Email!);

            if (getUser != null)
                return new RegistrationResponse(false, "User already exist");
            appDbContext.Users.Add(new ApplicationUser()
            {
                Name = registrationUserDTO.Name,
                Email = registrationUserDTO.Email,
                Password = BCrypt.Net.BCrypt.HashPassword (registrationUserDTO.Password)
            });
            await appDbContext.SaveChangesAsync();
            return new RegistrationResponse(true, "Registration completed");
        }
    }
}
