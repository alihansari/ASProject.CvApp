using ASProject.CvApp.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.DTO.DTO.ExperienceDto
{
    public class ExperienceAddDto : IDto
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }
    }
}
