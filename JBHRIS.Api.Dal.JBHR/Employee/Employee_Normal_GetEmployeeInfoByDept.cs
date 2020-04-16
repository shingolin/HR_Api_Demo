using JBHRIS.Api.Dal.Employee;
using JBHRIS.Api.Dto.Employee.Normal;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBHRIS.Api.Dal.JBHR.Employee
{
    public class Employee_Normal_GetEmployeeInfoByDept : IEmployee_Normal_GetEmployeeInfoByDept
    {
        private IEmployee_Normal_GetEmployeeInfo _employee_Normal_GetEmployeeInfo;
        private IEmployee_Normal_GetPeopleByDept _employee_Normal_GetPeopleByDept;

        public Employee_Normal_GetEmployeeInfoByDept(IEmployee_Normal_GetEmployeeInfo employee_Normal_GetEmployeeInfo, IEmployee_Normal_GetPeopleByDept employee_Normal_GetPeopleByDept)
        {
            _employee_Normal_GetEmployeeInfo = employee_Normal_GetEmployeeInfo;
            _employee_Normal_GetPeopleByDept = employee_Normal_GetPeopleByDept;
        }
        public List<EmployeeInfoDto> GetEmployeeInfoByDept(List<string> DeptList,DateTime CheckDate)
        {
            var deptPeopleList = _employee_Normal_GetPeopleByDept.GetPeopleByDept(DeptList, CheckDate);
            return _employee_Normal_GetEmployeeInfo.GetEmployeeInfo(deptPeopleList);
        }
    }
}
