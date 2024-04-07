using System.Collections.Generic;
using System.Web.Mvc;
using FabrikamFiber.DAL.Models;

namespace FabrikamFiber.Web.ViewModels
{
   

    public class EmployeeReportViewModel : Controller
    {
        public IEnumerable<EmployeeSummary> Employees { get; set; }

        public string GetCustomerSummary(Customer customer)
        {
            if (customer == null || customer.Address == null)
            {
                return "Customer information is not available";
            }
            return string.Format("{0}, {1}", customer.FullName, customer.Address.City);
        }
    }
}
