using ASProject.CvApp.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
namespace ASProject.CvApp.DTO.DTO.InterestDto
{
    public class InterestListDto : IDto 
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
