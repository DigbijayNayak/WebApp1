using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public interface IBusinessLogic
    {
        public StudentEntity GetFilteredStudentRecord(int rollNo);
        public StudentEntity GetFilteredByRandom();

        public bool SavesStudentRecord(StudentEntity stdEntity);
        
        public List<StudentEntity> GetFilteredByName(string name);

    }
}
