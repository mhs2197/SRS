﻿using System.Collections.Generic;
using UMS.Entity;

namespace UMS.Core.Interfaces
{
    public interface IStudentService: IDomainService<Student>
    {
        bool Delete(string id);
        IEnumerable<Student> GetAllWithCourses();
        Student GetWithCourses(string id);
        Student GetWithDepartment(string id);
        bool InsertWithDepartment(Student student, int departmentId);
        bool UpdateWithDepartment(Student student, int departmentId);
        bool AddCourse(string studentId, int courseId);
        bool RemoveCourse(string studentId, int courseId);
    }
}
