﻿using DataAccess.Abstracts;
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
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            using (CourseAcademyDbContext context = new CourseAcademyDbContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Delete(Category entity)
        {
            using (CourseAcademyDbContext context = new CourseAcademyDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            using (CourseAcademyDbContext context = new CourseAcademyDbContext())
            {
                return context.Set<Category>().SingleOrDefault(filter);
            }
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            using (CourseAcademyDbContext context = new CourseAcademyDbContext())
            {

                return filter == null ? context.Set<Category>().ToList() : context.Set<Category>().Where(filter).ToList();
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



        public void Update(Category entity)
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
