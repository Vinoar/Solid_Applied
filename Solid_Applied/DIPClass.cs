using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Applied
{
    

    public interface IStudentAccess
    {
        string GetName();
    }

    public class StudentAccess : IStudentAccess
    {
        public string GetName()
        {
            return "";
        }
    }

    public class StudentFactory
    {
        public static IStudentAccess GetStudentAccess()
        {
            return new StudentAccess();
        }
    }
    public class StudentBusinessLogicWay2
    {
        public string GetName()
        {
            return StudentFactory.GetStudentAccess().GetName();
        }

    }
    public class StudentBusinessLogicWay1
    { 
        readonly IStudentAccess studentAccess;

        // Method #1
        public StudentBusinessLogicWay1(IStudentAccess studentAccess)
        {
            this.studentAccess = studentAccess; 
        }

        public string GetName()
        {
           return this.studentAccess.GetName();
        }

    }


}
