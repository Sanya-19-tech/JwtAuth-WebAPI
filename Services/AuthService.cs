using JwtAuthDemo.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtAuthDemo.Services
{
    public class AuthService
    {
        private readonly List<UserModel> _users = new()
        {
            new UserModel { Username = "user1", Password = "1234", Role = "User" },
            new UserModel { Username = "admin1", Password = "1234", Role = "Admin" }
        };

        private readonly string _secretKey = "THIS_IS_MY_SUPER_SECRET_KEY_12345";

        public string? Authenticate(LoginModel? login)
        {
            // Handle null login
            if (login == null)
                return null;

            var user = _users.FirstOrDefault(u =>
                u.Username == login.Username &&
                u.Password == login.Password);

            if (user == null)
                return null;

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public string GetSecretKey()
        {
            return _secretKey;
        }
    }
}
