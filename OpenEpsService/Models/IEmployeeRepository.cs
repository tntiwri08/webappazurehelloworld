using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenEpsService.Models
{
    public interface IEmployeeRepository : IDisposable
    {
        IQueryable<Employee> All { get; }
        Employee Find(int? id);
        void InsertOrUpdate(Employee employee);
        void Delete(int id);
        void Save();
    }

}