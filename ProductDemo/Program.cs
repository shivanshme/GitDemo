using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoComp dc=new DemoComp();
            //dc.sqlDataAdapter1.Fill(dc.stockDataSet11);
            //dc.stockDataSet11.WriteXml("C:\\SoleraFiles\\Product.xml");
            Console.WriteLine();
            //dc.stockDataSet11.WriteXmlSchema("C:\\SoleraFiles\\Product123.xsd");
            //Console.WriteLine("Data exported to XML");
            dc.stockDataSet11.ReadXml("C:\\SoleraFiles\\Product.xml");
            dc.stockDataSet11.ReadXmlSchema("C:\\SoleraFiles\\Product123.xsd");

            Console.WriteLine("Data imported to XML");
            Console.Read();








            //ProductDBManager pd=new ProductDBManager();
            //bool sts = true;
            //while(sts)
            //{
            //    int ch = pd.Menu();
            //    switch(ch)
            //    {
            //        case 1:
            //            pd.AddProduct();
            //            break;
            //        case 2:
            //            pd.EditProduct();
            //            break;
            //        case 3:
            //            pd.RemoveProduct();
            //            break;
            //        case 4:
            //            pd.FindProduct();
            //            break;
            //        case 5:
            //            pd.ProductSummary();
            //            break;
            //        case 6:
            //            sts= false;
            //            break;
            //        default:
            //            Console.WriteLine("wrong choice  ..");
            //            sts = false;
            //            break;
            //    }

            

        }
    }
}
