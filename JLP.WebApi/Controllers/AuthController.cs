using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JLP.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        [Route("GetJwtToken")]
        public IActionResult Get(string userName, string pwd)
        {
            if (CheckAccount(userName, out string role))
            {
                //Const.ValidAudience = userName + pwd + DateTime.Now.ToString();
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Nbf,$"{new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()}") ,
                    new Claim (JwtRegisteredClaimNames.Exp,$"{new DateTimeOffset(DateTime.Now.AddMinutes(30)).ToUnixTimeSeconds()}"),
                    new Claim(ClaimTypes.NameIdentifier, userName),
                    new Claim(ClaimTypes.Role,role)
                };
                return Ok(new
                {
                    token = this.CreateToken(claims)
                }); ;
            }
            else
            {
                return BadRequest(new { message = "username or password is incorrect." });
            }
        }

        private string CreateToken(Claim[] claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Const.SecurityKey));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: Const.Domain,
                audience: Const.Domain,
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        /// <summary>
        /// 模拟登陆校验，因为是模拟，所以逻辑很‘模拟’
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        private bool CheckAccount(string userName, out string role)
        {
            role = "user";

            if (string.IsNullOrEmpty(userName))
                return false;

            if (userName.Equals("admin"))
                role = "admin";

            return true;
        }

        [HttpGet]
        [Route("ForBidden")]
        public IActionResult ForBidden()
        {
            return base.Forbid("No Persion");
        }
    }
}