using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using ORMFrameWork.Models;


namespace ORMFrameWork.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DbORMContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbORMContext():base("con")
        {

        }
    }
}