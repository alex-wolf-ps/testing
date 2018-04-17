// <copyright file="HomeController.cs" company="alexwolf.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>

namespace WebApplication1.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using WebApplication1.Models;

    /// <summary>
    /// The home controller
    /// </summary>
    [ProblemFilter]
    public class ContactController : Controller
    {
        /// <summary>
        /// The index method
        /// </summary>
        /// <returns>An action result</returns>
        [HttpGet]
        public IActionResult GetContacts()
        {
            return Json(new { Name = "Alex", Email = "test@test.com" });
        }

        /// <summary>
        /// The index method
        /// </summary>
        /// <returns>An action result</returns>
        public IActionResult About()
        {
            return this.View();
        }
    }
}