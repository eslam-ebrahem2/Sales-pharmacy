using Sales.DAL;
using Sales.DAL.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.BLL.servces
    {
    public class ProductService
        {



        public static bool AddProduct(Products product)
            {
            bool result = Helper.ExecuteDml($"INSERT INTO PRODUCT (NAME,BYPRICE,SALEPRICE,QTY,CATEGORYID) VALUES (N'{product.Name}',{product.Price},{product.SalePrice},{product.Qty},{product.CatId})");
            return result;
            }

        public static List<Products> getallProducts()
            {


            List<Products> prodList = new List<Products>();

            var datatable = Helper.ExcuteSelect("SELECT * FROM PRODUCT");


            foreach (DataRow item in datatable.Rows)
                {
                prodList.Add(new Products
                    {
                    Name = item["NAME"].ToString(),
                    Id = Convert.ToInt32(item["ID"]),
                    Price= Convert.ToInt32(item["BYPRICE"]),
                    SalePrice = Convert.ToInt32(item["SALEPRICE"]),
                    Qty= Convert.ToInt32(item["QTY"]),
                    CatId= Convert.ToInt32(item["CATEGORYID"])
                    });

                }

            return prodList;
            }
        // delete
        public static bool DeleteProductById(int id)
            {
            bool res = Helper.ExecuteDml($"DELETE FROM PRODUCT WHERE ID={id}");

            return res;

            }
        //edit category by id
        public static bool EditProductById(int id, string name, double BYPRICE , double SALEPRICE , double QTY)
            {
            bool res = Helper.ExecuteDml($"UPDATE PRODUCT SET NAME ='{name}',BYPRICE = {BYPRICE},SALEPRICE = {SALEPRICE},QTY={QTY} WHERE ID={id}");

            return res;

            }

        // search by name

        public static List<Products> SearchPRODUCT(string name)
            {


            List<Products> prodList = new List<Products>();

            var datatable = Helper.ExcuteSelect($"SELECT * FROM PRODUCT WHERE NAME LIKE '%{name}%'");


            foreach (DataRow item in datatable.Rows)
                {
                prodList.Add(new Products
                    {
                    Name = item["NAME"].ToString(),
                    Id = Convert.ToInt32(item["ID"]),
                    Price = Convert.ToInt32(item["BYPRICE"]),
                    SalePrice = Convert.ToInt32(item["SALEPRICE"]),
                    Qty = Convert.ToInt32(item["QTY"]),
                    CatId = Convert.ToInt32(item["CATEGORYID"])
                    });

                }

            return prodList;
            }
        public static List<Products> SearchPRODUCTbyid(int id)
            {


            List<Products> prodList = new List<Products>();

            var datatable = Helper.ExcuteSelect($"SELECT * FROM PRODUCT WHERE ID ={id}");


            foreach (DataRow item in datatable.Rows)
                {
                prodList.Add(new Products
                    {
                    Name = item["NAME"].ToString(),
                    Id = Convert.ToInt32(item["ID"]),
                    Price = Convert.ToInt32(item["BYPRICE"]),
                    SalePrice = Convert.ToInt32(item["SALEPRICE"]),
                    Qty = Convert.ToInt32(item["QTY"]),
                    CatId = Convert.ToInt32(item["CATEGORYID"])
                    });

                }

            return prodList;
            }

        public static bool EditProductById()
            {
            throw new NotImplementedException();
            }
        }
    }

