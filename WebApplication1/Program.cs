// <copyright file="Program.cs" company="alexwolf.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>

namespace WebApplication1
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// The program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args">The arguments</param>
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        /// <summary>
        /// The web host builder
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns>A web host</returns>
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}