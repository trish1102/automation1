using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation1.Test
{
    [TestFixture]
    [Parallelizable]
    public class Employee_test: ComonDriver
    {
        [Test,Order(1)]
        public void Createemployee_Test()
        {
            //import Homepage here
            Homepage homepageobj = new Homepage();
            homepageobj.GoToEmployeePage(driver);
            Employeepage employeeobj = new Employeepage();
            employeeobj.CreateEmployee(driver);

        }
        [Test,Order(2)]
        public void Editemployee_test()
        {
            Homepage homepageobj = new Homepage();
            homepageobj.GoToEmployeePage(driver);
            Employeepage employeeobj = new Employeepage();
            employeeobj.EditEmployee(driver);

        }
        [Test,Order(3)]
        public void Deleteemployee_test()
        {
            Homepage homepageobj = new Homepage();
            homepageobj.GoToEmployeePage(driver);
            Employeepage employeeobj = new Employeepage();
            employeeobj.DeleteEmployee(driver);
        }
        

    }
}
