namespace EFTutorials
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;

    public partial class SchoolDBEntities : DbContext
    {
        public SchoolDBEntities()
            : base("name=SchoolDBEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAddress> StudentAddresses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<View_StudentCourse> View_StudentCourse { get; set; }

        public virtual ObjectResult<GetCoursesByStudentId_Result> GetCoursesByStudentId(Nullable<int> studentId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCoursesByStudentId_Result>("GetCoursesByStudentId", studentIdParameter);
        }

        public virtual int sp_DeleteStudent(Nullable<int> studentId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteStudent", studentIdParameter);
        }

        public virtual ObjectResult<Nullable<decimal>> sp_InsertStudentInfo(Nullable<int> standardId, string studentName)
        {
            var standardIdParameter = standardId.HasValue ?
                new ObjectParameter("StandardId", standardId) :
                new ("StandardId", typeof(int));

            var studentNameParameter = studentName != null ?
                new ObjectParameter("StudentName", studentName) :
                new ObjectParameter("StudentName", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("sp_InsertStudentInfo", standardIdParameter, studentNameParameter);
        }

        public virtual int sp_UpdateStudent(Nullable<int> studentId, Nullable<int> standardId, string studentName)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));

            var standardIdParameter = standardId.HasValue ?
                new ObjectParameter("StandardId", standardId) :
                new ObjectParameter("StandardId", typeof(int));

            var studentNameParameter = studentName != null ?
                new ObjectParameter("StudentName", studentName) :
                new ObjectParameter("StudentName", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateStudent", studentIdParameter, standardIdParameter, studentNameParameter);
        }
    }
}

//https://pt.stackoverflow.com/q/358128/101
