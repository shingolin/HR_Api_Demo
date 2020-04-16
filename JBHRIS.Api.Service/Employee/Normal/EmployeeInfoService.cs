using JBHRIS.Api.Dal.Employee;
using JBHRIS.Api.Dto.Employee.Normal;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBHRIS.Api.Service.Employee.Normal
{
    public class EmployeeInfoService : IEmployeeInfoService
    {
        private IEmployee_Normal_GetEmployeeInfo _employee_Normal_GetEmployeeInfo;
        private IEmployee_Normal_GetEmployeeInfoByDept _employee_Normal_GetEmployeeInfoByDept;
        private IEmployee_Normal_GetPeopleByDept _employee_Normal_GetPeopleByDept;

        public EmployeeInfoService(IEmployee_Normal_GetEmployeeInfo employee_Normal_GetEmployeeInfo,IEmployee_Normal_GetEmployeeInfoByDept employee_Normal_GetEmployeeInfoByDept,IEmployee_Normal_GetPeopleByDept employee_Normal_GetPeopleByDept)
        {
            _employee_Normal_GetEmployeeInfo = employee_Normal_GetEmployeeInfo;
            _employee_Normal_GetEmployeeInfoByDept = employee_Normal_GetEmployeeInfoByDept;
            _employee_Normal_GetPeopleByDept = employee_Normal_GetPeopleByDept;
        }
        public List<EmployeeInfoDto> GetEmployeeInfo(List<string> employeeList)
        {
            return _employee_Normal_GetEmployeeInfo.GetEmployeeInfo(employeeList);
        }

        public List<EmployeeInfoDto> GetEmployeeInfoByDept(List<string> DeptList, DateTime CheckDate)
        {
            return _employee_Normal_GetEmployeeInfoByDept.GetEmployeeInfoByDept(DeptList, CheckDate);
        }

        public List<string> GetPeopleByDept(List<string> DeptList, DateTime CheckDate)
        {
            return _employee_Normal_GetPeopleByDept.GetPeopleByDept(DeptList, CheckDate);
        }
    }
}
