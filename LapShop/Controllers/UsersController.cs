using LapShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LapShop.Controllers
{
    public class UsersController : Controller
    {
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;

        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) 
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        public IActionResult Register()
        {
            // user object to get data, password unhashed.
            // from this user model we can create the acctual ApplicationUser.
            RegisterUserModel user = new RegisterUserModel();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserModel model)
        {
            // validate inputs...
            if (!ModelState.IsValid)
            {

                return View("Register", model);
            }

            // create ApplicationUser Object
            ApplicationUser User = new ApplicationUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email
            };
            try
            {
                // CreateAsync.
                // create new user instance, add to Identity System 
                // Hashes the password,
                var result = await _userManager.CreateAsync(User, model.Password);

                if (result.Succeeded)
                {
                    // User creation successful
                    //ViewData["ValidationMessage"] = "User created successfully!";
                    //return View("Register");

                    // set any new user role as a customer
                    var myUser = await _userManager.FindByEmailAsync(User.Email);
                    await _userManager.AddToRoleAsync(myUser, "Customer");

                    // auto login
                    var loginResult = await _signInManager.PasswordSignInAsync(User, model.Password, true, true);
                    if (loginResult.Succeeded)
                    {
                        return Redirect("/Order/orderSuccess");
                    }
                }
                else
                {
                    // User creation failed
                    ViewData["ValidationMessage"] = "User created Failed!";
                    return View("Register", model);
                }
            }
            catch (Exception ex)
            {

            }
            // ModelState is invalid, re-render the view with errors
            return View(model);
        }



        public IActionResult Login(string? returnUrl = null)
        {
            UserModel model = new UserModel() {ReturnUrl = returnUrl,};
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserModel model)
        {

            if (!ModelState.IsValid)
            {
                return View("Login", model);
            }

            ApplicationUser User = new ApplicationUser()
            {
                Email = model.Email,
                UserName = model.Email,

            };

            try
            {

                var loginResult = await _signInManager.PasswordSignInAsync(User.Email, model.Password, true, true);

                // success login
                if (loginResult.Succeeded)
                {
                    // go to returnUrl if exist.
                    if (string.IsNullOrEmpty(model.ReturnUrl))
                        return Redirect("~/");
                    else 
                        return Redirect(model.ReturnUrl);
                }
            }
            catch (Exception ex)
            {

            }
            return View(new UserModel());

        }

        public  async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }
        public IActionResult AccessDenided()
        {

            return View();
        }
        
    }
}
