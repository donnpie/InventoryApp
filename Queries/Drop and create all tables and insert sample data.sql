/*
Runs all the scripts required to create tables and populate with demo data
CAUTION!!! This script will delete all data in the database! Use with caution

You need to enable SQLCMD mode before running this script (Query>SQLCMD Mode)
If there are spaces in the file name or path, wrap the full path and file name in ""

Run through console like so: sqlcmd -S serverName\instanceName -i C:\Scripts\Script1.sql
*/

-- Delete tables in reverse order
DROP TABLE IF EXISTS InventoryIn;
DROP TABLE IF EXISTS InventoryOut;
DROP TABLE IF EXISTS Stores;
DROP TABLE IF EXISTS Products;
DROP TABLE IF EXISTS Brands;
DROP TABLE IF EXISTS GenericProductNames;
DROP TABLE IF EXISTS Groups;
DROP TABLE IF EXISTS Categories;

-- Create tables
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Create table - Categories.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Create table - Groups.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Create table - GenericProductNames.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Create table - Brands.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Create table - Products.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Create table - Stores.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Create table - InventoryIn.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Create table - InventoryOut.sql"

-- Insert sample data
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Insert sample data into Categories.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Insert sample data into Groups.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Insert sample data into GenericProductNames.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Insert sample data into Brands.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Insert sample data into Products.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Insert sample data into Stores.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Insert sample data into InventoryIn.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Insert sample data into InventoryOut.sql"

-- Create views
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Create view - InventoryInView.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Create view - InventoryOutView.sql"
:r "C:\Users\donnp\source\repos\Inventory app\Queries\Create view - ProductView.sql"