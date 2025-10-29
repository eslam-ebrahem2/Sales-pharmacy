using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sales.DAL.models
    {
    public class Products
        {
        /*............ in DataBase..........
       ID int PRIMARY KEY identity(1,1) ,
       NAME nvarchar(20),
       BYPRICE MONEY,
       SALEPRICE MONEY ,
       QTY FLOAT,
       CATEGORYID INT REFERENCES CATEGORY(ID)
       .......................................*/
        public int? Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public double Qty { get; set; }
        public int CatId { get; set; }  

        }
    }
