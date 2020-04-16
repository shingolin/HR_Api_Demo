using JBHRIS.Api.Dto.Employee.Normal;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBHRIS.Api.Dal.Employee
{
    public interface IEmployee_Normal_GetEmployeeInfoByDept
    {
        List<EmployeeInfoDto> GetEmployeeInfoByDept(List<string> DeptList, DateTime CheckDate);
    }
}
