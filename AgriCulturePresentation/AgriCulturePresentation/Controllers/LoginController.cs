using AgriCulturePresentation.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresentation.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
	{
		readonly UserManager<IdentityUser> _userManager;
        readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
		{

			return View();
		}
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password,true,false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
					TempData["ErrorMessage"] = "Kullanıcı adı veya şifre hatalı.";
					return View();
				}
            }
            else
            {
                return View(loginViewModel);
            }

            
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterViewModel registerViewModel)
        {
            IdentityUser identityUser = new()
            {
                UserName=registerViewModel.UserName,
                Email=registerViewModel.Email,
                PhoneNumber=registerViewModel.PhoneNumber

            };
            if(registerViewModel.Password == registerViewModel.PasswordConfirm && ModelState.IsValid) 
            {
                if(registerViewModel.Password != null && registerViewModel.PasswordConfirm != null)
                {
                    var result = await _userManager.CreateAsync(identityUser, registerViewModel.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }

                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else
                {
                    return View(registerViewModel);
                }
                
            }
            

            return View(registerViewModel);
        }

        
    }
}
