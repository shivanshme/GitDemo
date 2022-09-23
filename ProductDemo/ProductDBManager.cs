using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDemo
{
    public class ProductDBManager
    {

        //Program for Disconnected DataBase CRUD operations




        DemoComp dc = null;

        public ProductDBManager()
        {
            dc= new DemoComp();

            //To 
            dc.sqlDataAdapter1.Fill(dc.stockDataSet11);
        }

        public int Menu()
        {
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.Edit Product");
            Console.WriteLine("3.Delete Product");
            Console.WriteLine("4.Find Product");
            Console.WriteLine("5.Product Summary");
            Console.WriteLine("6.Exit");
            Console.WriteLine("Please Enter your choice...");
            int ch=int.Parse(Console.ReadLine());
            return ch;
        }
        public void AddProduct()
        {
            int pid;
            string pname;
            float price;
            int qty;
            Console.WriteLine("Enter the product ID: \t");
            pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the product name: \t");
            pname = (Console.ReadLine()); 
            Console.WriteLine("Enter the product price: \t");
            price= float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the product Quantity: \t");
            qty = int.Parse(Console.ReadLine());
            
            DataRow dr= dc.stockDataSet11.Tables[0].NewRow();
            dr[0] = pid;
            dr[1] = pname;
            dr[2] = price;
            dr[3] = qty;

            dc.stockDataSet11.Tables[0].Rows.Add(dr);

            //temporary to actual db use update
            //actual to temporary db use fill
            dc.sqlDataAdapter1.Update(dc.stockDataSet11);
            Console.WriteLine("Data inserted Successfully!!");
        }
        public void EditProduct()
        {
            int pid;
            string pname;
            float price;
            int qty;
            Console.WriteLine("Enter the product ID: \t");
            pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the product name: \t");
            pname = (Console.ReadLine());
            Console.WriteLine("Enter the product price: \t");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the product Quantity: \t");
            qty = int.Parse(Console.ReadLine());

            DataRow dr = dc.stockDataSet11.Tables[0].Rows.Find(pid);
            if(dr != null)
            {
                dr[1] = pname;
                dr[2] = price;
                dr[3] = qty;
                dc.sqlDataAdapter1.Update(dc.stockDataSet11);
                Console.WriteLine("Data updated Successfully!!");
            }
            else
            {
                Console.WriteLine("Record not found!!");
            }
            
            //temporary to actual db use update
            //actual to temporary db use fill
        }
        public void RemoveProduct()
        {
            int pid;
            
            Console.WriteLine("Enter the product ID: \t");
            pid = int.Parse(Console.ReadLine());
           

            DataRow dr = dc.stockDataSet11.Tables[0].Rows.Find(pid);
            if (dr != null)
            {
                dr.Delete();
                dc.sqlDataAdapter1.Update(dc.stockDataSet11);
                Console.WriteLine("Record deleted Successfully!!");
            }
            else
            {
                Console.WriteLine("Record not found!!");
            }
            //temporary to actual db use update
            //actual to temporary db use fill
        }
        public void FindProduct()
        {
            int pid;

            Console.WriteLine("Enter the product ID: \t");
            pid = int.Parse(Console.ReadLine());


            DataRow dr = dc.stockDataSet11.Tables[0].Rows.Find(pid);
            if(dr != null)
            {

                Console.WriteLine("ID\tName\tPrice\tQuantity");
                Console.WriteLine(".........................................");
                Console.WriteLine($"{dr[0]}\t{dr[1]}\t{dr[2]}\t{dr[3]}");
                Console.WriteLine("Record Found Successfully!!");
            }
            else
            {
                Console.WriteLine("Record Not found..");
            }
        }
        public void ProductSummary()
        {
            //DataRow dr = dc.stockDataSet11.Tables[0].Rows.Find(pid);
            if (dc.stockDataSet11.Tables[0].Rows.Count>0)
            {
                Console.WriteLine("ID\tName\tPrice\tQuantity");
                Console.WriteLine(".........................................");
                foreach(DataRow dr in dc.stockDataSet11.Tables[0].Rows)
                {
                    Console.WriteLine($"{dr[0]}\t{dr[1]}\t{dr[2]}\t{dr[3]}");
                }
                Console.WriteLine("Record Found Successfully!!");
            }
            else
            {
                Console.WriteLine("No data is Record Not found..");
            }
        }
    }
}
