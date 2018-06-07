using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbmigrator = new DbMigrator(new Logger());

            var log1 = new Logger();
            var installer  = new Installer(log1);

            dbmigrator.Migrate();
            installer.Install();
        }
    }
}
