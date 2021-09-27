using ASProject.CvApp.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.DTO.DTO.AppUserListDto
{
    public class AppUserPasswordDto:IDto
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
