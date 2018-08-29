// using Microsoft.AspNetCore.Authentication;
// using Microsoft.AspNetCore.Mvc;

// namespace TesteMVC.Controllers
// {
//     public class AccountController: Controller
//     {
//           public IActionResult Login(string returnUrl = "/")
//         {
//             return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl });
//         }

//         public IActionResult Logout(string returnUrl = "/"){
//             await context.Authentication.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
 
//         // Perform a simple redirect after logout
//         context.Response.Redirect("/");
//         }
//     }
// }