using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Api_Demo
{

    public class Rootobject
    {
        public Logging Logging { get; set; }
        public Moduleregister ModuleRegister { get; set; }
        public Salarycalculatemodules SalaryCalculateModules { get; set; }
        public string AllowedHosts { get; set; }
    }

    public class Logging
    {
        public Loglevel LogLevel { get; set; }
    }

    public class Loglevel
    {
        public string Default { get; set; }
        public string Microsoft { get; set; }
        public string MicrosoftHostingLifetime { get; set; }
    }

    public class Moduleregister
    {
        public string SourceDir { get; set; }
        public Module[] Module { get; set; }
    }

    public class Module
    {
        public string SourcePath { get; set; }
        public string Interface { get; set; }
        public string ConcreteClass { get; set; }
        public string Description { get; set; }
    }

    public class Salarycalculatemodules
    {
        public string BasicSalary { get; set; }
    }

}
