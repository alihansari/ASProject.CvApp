using ASProject.CvApp.Entities.Abstract;
using ASProject.CvApp.Entities.Concrete.BaseClasses;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASProject.CvApp.Entities.Concrete
{
    [Table("Experiences")]
    public class Experience:BaseEntity,IEntity
    {
        
    }
}
