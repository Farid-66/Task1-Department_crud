using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_CRUD
{
    interface IDepartmentService
    {
        Department Create(Department department);
        Department[] Read();
        Department Update(int id, Department department);
        Department Find(int id);
        bool Delete(int id);
    }
}
