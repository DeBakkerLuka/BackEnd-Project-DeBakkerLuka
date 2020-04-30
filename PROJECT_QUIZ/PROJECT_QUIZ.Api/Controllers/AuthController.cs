using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PROJECT_QUIZ.Models.Models;

namespace PROJECT_QUIZ.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SignInManager<Person> _signInManager;
        private readonly Microsoft.AspNetCore.Identity.UserManager<Person> usermanager;
        private readonly ILogger<AuthController> logger;
        private readonly IPasswordHasher<Person> hasher;
        private readonly IConfiguration configuration;

        public AuthController(SignInManager<Person> signInManager, UserManager<Person> usermanager, ILogger<AuthController> logger, IPasswordHasher<Person> hasher, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            this._signInManager = signInManager;
            this.usermanager = usermanager;
            this.logger = logger;
            this.hasher = hasher;
            this.configuration = configuration;
        }


        [HttpPost("token")]
        [AllowAnonymous]
        public async Task<IActionResult> GenerateJwtToken([FromBody]LoginDTO identityDTO)
        {
            try
            {
                var jwtsvc = new JWTServices<Person>(configuration, logger, usermanager, hasher);
                var token = await jwtsvc.GenerateJwtToken(identityDTO);
                return Ok(token);
            }
            catch (Exception exc)
            {
                logger.LogError($"Exception thrown when creating JWT: {exc}");
            } //Bij niet succesvolle authenticatie wordt een Badrequest (=zo weinig mogelijke info) teruggeven. 
            return BadRequest("Failed to generate JWT token");
        }

        //Authcontroller.cs 
        [HttpPost]
        [Route("login")] //vult de controller basis route aan 
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        { //LoginViewModel met (Required) UserName en Password aanbrengen. 
            var returnMessage = "";
            if (!ModelState.IsValid)
                return BadRequest("Onvolledige gegevens.");
            try
            {
                //geen persistence, geen lockout -> via false, false 
                var result = await _signInManager.PasswordSignInAsync(loginDTO.UserName, loginDTO.Password, false, false);
                if (result.Succeeded)
                {
                    return Ok("Welkom " + loginDTO.UserName);
                }
                throw new Exception("User of paswoord niet gevonden.");
                //zo algemeen mogelijk response. Vertelt niet dat het pwd niet juist is. 
            }
            catch (Exception exc)
            {
                returnMessage = $"Foutief of ongeldig request: {exc.Message}";
                ModelState.AddModelError("", returnMessage);
            }
            return BadRequest(returnMessage); //zo weinig mogelijk (hacker) info 
        }
    }

    

}




