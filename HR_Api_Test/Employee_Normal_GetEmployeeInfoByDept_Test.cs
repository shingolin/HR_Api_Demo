using JBHRIS.Api.Dal.JBHR.Employee;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Api_Test
{
      [TestClass]
    public class Employee_Normal_GetEmployeeInfoByDept_Test
    {
        [TestMethod]
        public void GetEmployeeInfoByDept_Test()
        {
            var jBHRContext = TestConfig.GetJBHRContext();
            Employee_Normal_GetEmployeeInfo employee_Normal_GetEmployeeInfo = new Employee_Normal_GetEmployeeInfo(jBHRContext);
            Employee_Normal_GetPeopleByDept employee_Normal_GetPeopleByDept = new Employee_Normal_GetPeopleByDept(jBHRContext);
            Employee_Normal_GetEmployeeInfoByDept employee_Normal_GetEmployeeInfoByDept = new Employee_Normal_GetEmployeeInfoByDept(employee_Normal_GetEmployeeInfo, employee_Normal_GetPeopleByDept);
            var data = employee_Normal_GetEmployeeInfoByDept.GetEmployeeInfoByDept(new System.Collections.Generic.List<string> { "s1002", "1235" }, new DateTime(2019, 12, 31));
            Assert.AreEqual(14, data.Count, "取得筆數確認");
        }
    }
}
