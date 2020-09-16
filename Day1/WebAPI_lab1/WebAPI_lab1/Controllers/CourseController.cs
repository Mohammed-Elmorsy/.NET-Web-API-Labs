using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using WebAPI_lab1.Models;

namespace WebAPI_lab1.Controllers
{
    public class CourseController: ApiController
    {
        public static List<Course> courses = new List<Course>()
        {
            new Course(){ Id=1,Name="C#",Description="intro to c#",Duration=40 },
            new Course(){ Id=2,Name="WebAPI",Description="CRUD operations",Duration=25 },
            new Course(){ Id=3,Name="MVC",Description="Model binding",Duration=45 },
            new Course(){ Id=4,Name="SQL",Description="ERD and mapping",Duration=35 }
        };

        public IHttpActionResult Get()
        {
            if (courses == null)
                return NotFound();
            else
                return Ok(courses);
        }

        public IHttpActionResult DeleteCourse(int id)
        {
            Course crs = courses.Find(c => c.Id == id);
            if (crs == null)
                return NotFound();
            else
                courses.Remove(crs);
                return Ok(courses);
        }

        public IHttpActionResult Put(int id, Course course)
        {
            Course crs = courses.Find(c => c.Id == id);
            if (crs == null)
                return NotFound();
            else if (id != course.Id)
                return BadRequest();
            else
            {
                crs.Name = course.Name;
                crs.Description = course.Description;
                crs.Duration = course.Duration;
                return StatusCode(HttpStatusCode.NoContent);
                //return ResponseMessage(new HttpResponseMessage() { StatusCode = HttpStatusCode.NoContent });
            }
        }

        public IHttpActionResult Post(Course course)
        {
            if (course == null)
                return NotFound();
            else
            {
                courses.Add(course);
                return StatusCode(HttpStatusCode.Created);
            }
        }

        public IHttpActionResult GetById(int id)
        {
            Course crs = courses.Find(c => c.Id == id);
            if (crs == null)
                return NotFound();
            else
                return Ok(crs);
        }

        [Route("api/course/{name:alpha}")]
        public IHttpActionResult GetByName(string name)
        {
             List<Course> crs = courses.FindAll(c => c.Name == name);
            if (crs == null || name == null)
                return NotFound();
            else
                return Ok(crs);
        }

    }
}