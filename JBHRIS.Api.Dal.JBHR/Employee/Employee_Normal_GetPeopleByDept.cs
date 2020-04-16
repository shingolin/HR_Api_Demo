using JBHRIS.Api.Dal.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JBHRIS.Api.Dal.JBHR.Employee
{
    public class Employee_Normal_GetPeopleByDept : IEmployee_Normal_GetPeopleByDept
    {
        private JBHRContext _context;

        public Employee_Normal_GetPeopleByDept(JBHRContext context)
        {
            _context = context;
        }
        public List<string> GetPeopleByDept(List<string> DeptList,DateTime CheckDate)
        {
            return _context.Basetts.Where(p => DeptList.Contains(p.Dept) && CheckDate >= p.Adate && CheckDate <= p.Ddate.Value).Select(p => p.Nobr).Distinct().ToList();
        }
    }
}
