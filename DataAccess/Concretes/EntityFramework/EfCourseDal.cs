﻿using DataAccess.Abstracts;
using Entities.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : ICourseDal
    {
        public void Add(Course entity)
        {
            using (CourseAcademyDbContext context = new CourseAcademyDbContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Delete(Course entity)
        {
            using (CourseAcademyDbContext context = new CourseAcademyDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            using (CourseAcademyDbContext context = new CourseAcademyDbContext())
            {
                return context.Set<Course>().SingleOrDefault(filter);
            }
        }

        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            using (CourseAcademyDbContext context = new CourseAcademyDbContext())
            {

                return filter == null ? context.Set<Course>().ToList() : context.Set<Course>().Where(filter).ToList();
                //if (filter == null)
                //{
                //    return context.Set<Course>().ToList();
                //    // select * from course
                //}
                //else
                //{
                //    return context.Set<Course>().Where(filter).ToList();
                //    // select CourseId from Courses
                //    // where (courseId >5)=filter=(c=>c.CourseId>5)
                //}

            }
        }



        public void Update(Course entity)
        {
            using (CourseAcademyDbContext context = new CourseAcademyDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
