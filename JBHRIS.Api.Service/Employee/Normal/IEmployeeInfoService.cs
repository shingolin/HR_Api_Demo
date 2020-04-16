using JBHRIS.Api.Dto.Employee.Normal;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBHRIS.Api.Service.Employee.Normal
{
    public interface IEmployeeInfoService
    {
        List<EmployeeInfoDto> GetEmployeeInfo(List<string> employeeList);
        List<EmployeeInfoDto> GetEmployeeInfoByDept(List<string> DeptList, DateTime CheckDate);
        List<string> GetPeopleByDept(List<string> DeptList, DateTime CheckDate);
    }
}
