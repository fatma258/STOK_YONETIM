using RecapProject1.Entities;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using  System.Collections.Generic;
using RecapProject1.Entities;

namespace RecapProject1
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } 
        // Your context has been configured to use a 'NorthwindContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RecapProject1.NorthwindContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'NorthwindContext' 
        // connection string in the application configuration file.
        

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class DbContext
    //{
    //    private string v;

    //    public DbContext(string v)
    //    {
    //        this.v = v;
    //    }
    //}

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}