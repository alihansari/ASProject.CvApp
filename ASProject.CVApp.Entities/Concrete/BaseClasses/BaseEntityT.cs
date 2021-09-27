using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Entities.Concrete.BaseClasses
{
    public class BaseEntityT
    {
        [Key]
        public int Id { get; set; }
    }
}

