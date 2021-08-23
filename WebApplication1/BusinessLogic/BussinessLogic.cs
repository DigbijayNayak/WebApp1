using System;
using System.Collections.Generic;
using Entity;

namespace BusinessLogic
{
    public class BussinessLogic
    {
        StudentEntity studentEntity = new StudentEntity();
        List<StudentEntity> entityList = new List<StudentEntity>
        {
            new StudentEntity{Name="Nirmalya", RollNo=4, Section="A"},
            new StudentEntity{Name="Digbijay", RollNo=3, Section="B"},
            new StudentEntity{Name="Dibyajyoti", RollNo=2, Section="C"},
            new StudentEntity{Name="Rajesh", RollNo=5, Section="D"},
            new StudentEntity{Name="Subhashree", RollNo=7, Section="A"}
        };

        List<StudentEntity> entityList2 = new List<StudentEntity>();


        public StudentEntity GetFilteredStudentRecord(int rollNo)
        {
            for(int i=0; i < entityList.Count; i++)
            {
                if(entityList[i].RollNo == rollNo)
                {
                    return entityList[i];
                }
            }
            return null;
        }
        public StudentEntity GetFilteredByRandom()
        {
            var num = new Random().Next(0, 4);
            return entityList[num];
        }

        public bool SavesStudentRecord(StudentEntity stdEntity)
        {
            entityList.Add(stdEntity);
            return false;
        }
        public List<StudentEntity> GetFilteredByName(string name)
        {
            List<StudentEntity> Students = new List<StudentEntity>();
            for(int i = 0; i < entityList.Count; i++)
            {
                if (entityList[i].Name.ToLower().Contains(name.ToLower()))
                {
                    //return entityList[i];
                    entityList2.Add(entityList[i]);

                }
                
            }
            return entityList2;
        }

      
    }
}
