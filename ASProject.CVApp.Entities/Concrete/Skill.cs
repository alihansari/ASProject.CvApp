﻿using ASProject.CvApp.Entities.Abstract;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Entities.Concrete
{
    [Table("Skills")]
    public class Skill:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string  Description { get; set; }
    }
}
