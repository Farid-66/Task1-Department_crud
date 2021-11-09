using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_CRUD
{
    class DepartmentService : IDepartmentService
    {
        private Department[] Departments = new Department[0];
        public Department Create(Department department)
        {
            Array.Resize(ref Departments, Departments.Length + 1);
            Departments[Departments.Length - 1] = department;
            return department;
        }

        public bool Delete(int id)
        {
            Departments = Array.FindAll(Departments, e => e.Id != id);
            return true;
        }
        public Department Find(int id)
        {
            Department foundDepartments = Array.Find(Departments, e => e.Id == id);
            return foundDepartments;
        }

        public int FindId(int id)
        {
            if(Departments.Length == 0)
            {
                return 1;
            }

            return Departments[Departments.Length - 1].Id + 1;
        }

        public Department[] Read()
        {
            return this.Departments;
        }

        public Department Update(int id, Department department)
        {
            Department updatedEmployee = Array.Find(Departments, e => e.Id == id);
            updatedEmployee = department;
            return department;
        }

        
    }
}
