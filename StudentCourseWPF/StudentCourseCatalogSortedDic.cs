﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseWPF
{
    class StudentCourseCatalogSortedDic : StudentCatalog
    {
        SortedDictionary<int, Student> students = new SortedDictionary<int, Student>();

        public StudentCourseCatalogSortedDic()
        {
          
        }

        public void AddStudent(int s_id, Student s)
        {
            students.Add(s_id, s);
        }

        public void RemoveStudent(int s_id)
        {
            students.Remove(s_id);
        }

        public void ModifyGrade(int s_id, Student s_new)
        {
            if (students.ContainsKey(s_id))
            {
                students[s_id] = s_new;
            }
        }

        public string printStudents()
        {
            string returnStr = "";
            foreach (KeyValuePair<int, Student> student in students)
            {
                Student s = student.Value;
                returnStr = returnStr + "\n " + s.ToString();
            }
            return returnStr;
        }

        public string printStudentsSorted()
        {
            return printStudents();
        }

       
    }
}
