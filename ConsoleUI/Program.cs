using Business.Concretes;
using DataAccess.Concretes.EntityFramework;

CourseManager courseManager = new CourseManager(new EfCourseDal());
foreach (var course in courseManager.GetAll())
{
    Console.WriteLine(course.Name);
}