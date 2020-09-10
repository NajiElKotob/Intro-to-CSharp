1. Install EntityFramework via NuGet
1.1. Open "Manage NuGet Packages..." (Project menu, Search, Right-click project)
1.2. Under "browse" tab type "entityframework" and choose version 6.x
1.3. Click Install

2. Add your own Class (POCO)
* Very simple basic class with properties (normally this will be converted into a table in database)
e.g.
 class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }


3. Add a DbContext class (found in Entity Framework)
3.1. Add all DbSet (representing tables)
e.g.
    class CrmContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }


4. Open "Package Manager Console" (To communicate with EF lib)
4.1. Type: get-help entityframework
4.2. Use the following in this order

Note: Migration -> moving database structure from code to database

    Enable-Migrations
    Add-Migration Initial
    Update-Database
    Get-Migrations


5.1 To view database
- View > SQL Server Object Explorer > localdb\MSSQLLocalDB
open Databases and select your database

Enjoy EF https://www.entityframeworktutorial.net/entityframework6/introduction.aspx




Ref.
https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15
https://www.sqlshack.com/install-microsoft-sql-server-express-localdb/
