using Sales.DAL;
using Sales.DAL.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.BLL.servces {
    public class CategoryService {


        //method add
        public static bool addCategory(Category Category) {
            bool result = Helper.ExecuteDml($"INSERT INTO CATEGORY (NAME) VALUES (N'{Category.Name}')");
            return result;
            }

        public static List<Category> getallCategory() {


            List<Category> catList = new List<Category>();

            var datatable = Helper.ExcuteSelect("SELECT * FROM CATEGORY");


            foreach (DataRow item in datatable.Rows) {
                catList.Add(new Category {
                    Name = item["NAME"].ToString(),
                    Id = Convert.ToInt32(item["ID"])
                    });

                }

            return catList;
            }
        }  // class end 
    }
