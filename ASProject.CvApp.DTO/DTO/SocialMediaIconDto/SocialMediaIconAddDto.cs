using ASProject.CvApp.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.DTO.DTO.SocialMediaIconDto
{
    public class SocialMediaIconAddDto:IDto
    {
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }
    }
}
