using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBHRIS.Api.Bll.Salary.Payroll
{
    public class SalaryCalculateModuleFactory : ISalaryCalculateModuleFactory
    {
        private ILogger _logger;

        public SalaryCalculateModuleFactory(ILogger logger)
        {
            _logger = logger;
        }
        public ISalaryCalculateModule Create(string moduleType)
        {
            _logger.Info("產生模組" + moduleType);
            return null;
        }
    }
}
