using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASProject.CvApp.Web.Models
{
    public class AppUserUpdateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="İsim Gereklidir.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad Gereklidir.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Adres Gereklidir.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email Gereklidir.")]
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Telefon Gereklidir.")]
        public string PhoneNumber { get; set; }
        public IFormFile Picture { get; set; }
        public string ShortDescription { get; set; }
    }
}
