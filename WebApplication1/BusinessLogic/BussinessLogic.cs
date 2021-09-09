using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Entity;

namespace BusinessLogic
{
    public class BussinessLogic : IBusinessLogic
    {
        StudentEntity studentEntity = new StudentEntity();
        List<StudentEntity> entityList = new List<StudentEntity>();
        //{
        //    new StudentEntity{Name="Nirmalya", RollNo=4, Section="A"},
        //    new StudentEntity{Name="Digbijay", RollNo=3, Section="B"},
        //    new StudentEntity{Name="Dibyajyoti", RollNo=2, Section="C"},
        //    new StudentEntity{Name="Rajesh", RollNo=5, Section="D"},
        //    new StudentEntity{Name="Subhashree", RollNo=7, Section="A"}
        //};

        List<StudentEntity> entityList2 = new List<StudentEntity>();
        List<UserDetails> userList = new List<UserDetails>();
        StudentDbContext _dbCntxt; //
        public BussinessLogic(StudentDbContext sdb)
        {
            _dbCntxt = sdb;
        }
        public BussinessLogic()
        {
            
        }
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public int MultiplyTwoNumbers(int a, int b)
        {
            return a * b;
        }

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
        public bool GetFilteredById(UserDetails user)
        {
            userList = _dbCntxt.UserDetails.ToList();
            for(int i = 0; i < userList.Count; i++)
            {
                if ((userList[i].User_id == user.User_id) && (userList[i].Password == user.Password))
                {
                    //Console.WriteLine("login Successfully");
                    return true;
                }
            }
            //return null;
            return false;
        }
        public StudentEntity GetFilteredByRandom()
        {
            entityList = _dbCntxt.StudentEntity.ToList(); //linq
            var num = new Random().Next(0, entityList.Count-1);
            return entityList[num];
        }


        public bool SavesStudentRecord(StudentEntity stdEntity)
        {
            //entityList.Add(stdEntity);
            _dbCntxt.StudentEntity.Add(stdEntity);
            _dbCntxt.SaveChanges();
            return true;
        }
        public bool SavesUserDetailsRecord(UserDetails userEntity)
        {
            //entityList.Add(stdEntity);
            _dbCntxt.UserDetails.Add(userEntity);
            _dbCntxt.SaveChanges();
            userList = _dbCntxt.UserDetails.ToList();
            for(int i=0; i<userList.Count; i++)
            {
                if(userList[i].User_id == userEntity.User_id)
                {
                    return true;
                }
            }
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
