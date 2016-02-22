namespace StudentCourseWPF
{
    // Works as a supertype
    public interface StudentCatalog
    {
        void AddStudent(int s_id, Student s);

        void RemoveStudent(int s_id);

        void ModifyGrade(int s_id, Student s_new);

        string printStudents();

        string printStudentsSorted();

    }
}