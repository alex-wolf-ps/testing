// <copyright file="ErrorViewModel.cs" company="alexwolf.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>

namespace WebApplication1.Models
{
    /// <summary>
    /// The error class
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets the request id
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets the show request
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(this.RequestId);
    }
}