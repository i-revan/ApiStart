﻿using EduHome.Core.Entities;
using EduHome.DataAccess.Context;
using EduHome.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduHome.DataAccess.Repositories.Implementations
{
    public class CourseRepository:Repository<Course>,ICourseRepository
    {
        public CourseRepository(AppDbContext context):base(context)
        {
            
        }
    }
}
