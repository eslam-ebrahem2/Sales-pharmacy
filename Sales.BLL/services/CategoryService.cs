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
    public class CategoryService
        {



        public static bool addCategory(Category Category)
            {
            bool result = Helper.ExecuteDml($"INSERT INTO CATEGORY (NAME) VALUES (N'{Category.Name}')");
            return result;
            }

        public static List<Category> getallCategory()
            {


            List<Category> catList = new List<Category>();

            var datatable = Helper.ExcuteSelect("SELECT * FROM CATEGORY");


            foreach (DataRow item in datatable.Rows)
                {
                catList.Add(new Category
                    {
                    Name = item["NAME"].ToString(),
                    Id = Convert.ToInt32(item["ID"])
                    });

                }

            return catList;
            }
        // delete
        public static bool deleteCategoryById(int id)
            {
            bool res = Helper.ExecuteDml($"DELETE FROM CATEGORY WHERE ID={id}");

            return res;

            }
        //edit category by id
        public static bool editCategoryById(int id, string name)
            {
            bool res = Helper.ExecuteDml($"UPDATE CATEGORY SET NAME = {name} WHERE ID={id}");

            return res;

            }
        
    // search by name

     public static List<Category> SearchCategory(string name)
            {


            List<Category> catList = new List<Category>();

            var datatable = Helper.ExcuteSelect($"SELECT * FROM CATEGORY WHERE NAME LIKE '%{name}%'");


            foreach (DataRow item in datatable.Rows)
                {
                catList.Add(new Category
                    {
                    Name = item["NAME"].ToString(),
                    Id = Convert.ToInt32(item["ID"])
                    });

                }

            return catList;
            }



        }
    }

