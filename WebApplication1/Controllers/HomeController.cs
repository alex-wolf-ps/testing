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
    public class HomeController : Controller
    {
        /// <summary>
        /// The index method
        /// </summary>
        /// <returns>An action result</returns>
        public IActionResult Index()
        {
            return this.View();
        }
    }
}