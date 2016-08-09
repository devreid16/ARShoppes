using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ARShoppes.Models;

namespace ARShoppes.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var customers = new List<Customer>
            {
            new Customer{FName="Carson",LName="Alexander",PurchaseDate=DateTime.Parse("2005-09-01")},
            new Customer{FName="Meredith",LName="Alonso",PurchaseDate=DateTime.Parse("2002-09-01")},
            new Customer{FName="Arturo",LName="Anand",PurchaseDate=DateTime.Parse("2003-09-01")},
            new Customer{FName="Gytis",LName="Barzdukas",PurchaseDate=DateTime.Parse("2002-09-01")},
            new Customer{FName="Yan",LName="Li",PurchaseDate=DateTime.Parse("2002-09-01")},
            new Customer{FName="Peggy",LName="Justice",PurchaseDate=DateTime.Parse("2001-09-01")},
            new Customer{FName="Laura",LName="Norman",PurchaseDate=DateTime.Parse("2003-09-01")},
            new Customer{FName="Nino",LName="Olivetto",PurchaseDate=DateTime.Parse("2005-09-01")}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
            new Product{ProductID=1050,ProductUpc=022255588890,ProductDesc="Coats",ProductQty=30,ProductPrice=100.00m},
            new Product{ProductID=4022,ProductUpc=033366699900,ProductDesc="Blouses",ProductQty=23,ProductPrice=20.00m},
            new Product{ProductID=4041,ProductUpc=044455566670,ProductDesc="TShirts",ProductQty=43,ProductPrice=10.00m},
            new Product{ProductID=1045,ProductUpc=055566677780,ProductDesc="Shoes",ProductQty=45,ProductPrice=50.00m},
            new Product{ProductID=3141,ProductUpc=066677788890,ProductDesc="Pants",ProductQty=24,ProductPrice=30.00m},
            new Product{ProductID=2021,ProductUpc=077788899000,ProductDesc="Skirts",ProductQty=33,ProductPrice=25.00m},            
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var purchases = new List<Purchase>
            {
            new Purchase{CustomerID=1,ProductID=1050},
            new Purchase{CustomerID=1,ProductID=4022},
            new Purchase{CustomerID=1,ProductID=4041},
            new Purchase{CustomerID=2,ProductID=1045},
            new Purchase{CustomerID=2,ProductID=3141},
            new Purchase{CustomerID=2,ProductID=2021},
            new Purchase{CustomerID=3,ProductID=1050},
            new Purchase{CustomerID=4,ProductID=1050},
            new Purchase{CustomerID=4,ProductID=4022},
            new Purchase{CustomerID=5,ProductID=4041},
            new Purchase{CustomerID=6,ProductID=1045},
            new Purchase{CustomerID=7,ProductID=3141},
            };

            purchases.ForEach(s => context.Purchases.Add(s));
            context.SaveChanges();

            var departments = new List<Department>
            {
            new Department {DepartmentID=100,DeptName="Shoes",MgrFName="Steve",MgrLName="Jones",DeptSales=20334.00m},
            new Department {DepartmentID=200,DeptName="SportsWear",MgrFName="Mark",MgrLName="Staple",DeptSales=30150.00m},
            new Department {DepartmentID=300,DeptName="Womens",MgrFName="Leslie",MgrLName="Long",DeptSales=15049.00m},
            new Department {DepartmentID=400,DeptName="Mens",MgrFName="Kim",MgrLName="King",DeptSales=10500.00m},            
            };

            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
            new Employee{DepartmentID=100,EmpTitle="Manager",EmpLName="Alexander",EmpHireDate=DateTime.Parse("2001-09-01")},
            new Employee{DepartmentID=200,EmpTitle="SalesPerson",EmpLName="Alonso",EmpHireDate=DateTime.Parse("2002-09-01")},
            new Employee{DepartmentID=300,EmpTitle="StockPerson",EmpLName="Anand",EmpHireDate=DateTime.Parse("2003-09-01")},
            new Employee{DepartmentID=400,EmpTitle="Manager",EmpLName="Barzdukas",EmpHireDate=DateTime.Parse("2002-09-01")},
            new Employee{DepartmentID=100,EmpTitle="SalesPerson",EmpLName="Li",EmpHireDate=DateTime.Parse("2012-09-01")},
            new Employee{DepartmentID=200,EmpTitle="StockPerson",EmpLName="Justice",EmpHireDate=DateTime.Parse("2011-09-01")},
            new Employee{DepartmentID=300,EmpTitle="Manager",EmpLName="Norman",EmpHireDate=DateTime.Parse("2003-09-01")},
            new Employee{DepartmentID=400,EmpTitle="SalesPerson",EmpLName="Olivetto",EmpHireDate=DateTime.Parse("2005-09-01")},
            new Employee{DepartmentID=200,EmpTitle="Manager",EmpLName="Justice",EmpHireDate=DateTime.Parse("2011-09-01")},
            new Employee{DepartmentID=200,EmpTitle="SalesPerson",EmpLName="Justice",EmpHireDate=DateTime.Parse("2011-09-01")}
            };                            
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}