//using EHR.API.Controllers;
//using EHR.BLL.UnitOfWork;
//using EHR.DAL.Entities;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Linq;
//using Xunit;

//namespace EHR.TESTS
//{
//    public class CoursesControllerTest
//    {
//        [Fact]
//        public void Put_Updates_Specified_Items_Credit()
//        {
//            var options = new DbContextOptionsBuilder<SchoolContext>().UseInMemoryDatabase("TextContext").Options;
//            var context = new SchoolContext(options);
//            var unitOfWork = new UnitOfWork(context);
//            var controller = new CoursesController(unitOfWork);

//            var course = context.Courses.First();
//            course.Credits = 10;

//            controller.PutCourse(course.CourseID, course);

//            var updatedCourse = context.Courses.First();

//            Assert.Equal(updatedCourse.Credits, 10);
//        }

//        [Fact]
//        public void Post_Increments_Course_Count_By_One()
//        {
//            var options = new DbContextOptionsBuilder<SchoolContext>().UseInMemoryDatabase("TextContext").Options;
//            var context = new SchoolContext(options);
//            var unitOfWork = new UnitOfWork(context);
//            var controller = new CoursesController(unitOfWork);

//            var startingCount = context.Courses.Count();
//            var course = new Course() { CourseID = 10, Credits = 4, Title = "new" };
//            var result = controller.PostCourse(course);
//            var endingCount = context.Courses.Count();

//            Assert.Equal(startingCount + 1, endingCount);
//        }
//    }
//}
