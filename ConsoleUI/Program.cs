using Business.Concretes;
using Entities.Concretes;

Category category1 = new Category();
category1.Name = "Database";
category1.Id = 1;
CategoryManager categoryManager = new CategoryManager();
categoryManager.Add(category1);

Course course = new Course();
course.Id = 1;
course.Name = ".Net";
course.Description = "Kurs gibi kurs";
CourseManager courseManager = new CourseManager();
courseManager.Add(course);

Instructor instructor = new Instructor();
instructor.Id = 1;
instructor.FirstName = "Kadir";
instructor.LastName = "Özdemir";
InstructorManager instructorManager = new InstructorManager();
instructorManager.Add(instructor);
