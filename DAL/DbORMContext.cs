﻿using System;

using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;


//This is a comment
//ORM DB Context class need to be added with Departments DB Set As well
namespace ORMFrameWork.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DbORMContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments {get;set}
        public DBSet<Customers> Customer{get; set;}
        public DbORMContext():base("con")
        {

        }
    }
}
