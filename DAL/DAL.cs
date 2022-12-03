using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
    public class search_DAL
    {
        ExamDBEntities1 objent = new ExamDBEntities1();

        public List<search_Common> getperson_list()
        {
            var li = objent.tbl_person.Select(x => new search_Common { Id = x.Id, First_name = x.First_name, Middle_name = x.Middle_name, Last_name = x.Last_name,Email_Promotion=x.Email_Promotion,Modified_date=x.Modified_date }).ToList();
            return li;
        }

        public search_Common get_firstname(search_Common objprop)
        {
            var obj = objent.tbl_person.Select(x => new search_Common { Id = x.Id, First_name = x.First_name, Middle_name = x.Middle_name, Last_name = x.Last_name, Email_Promotion = x.Email_Promotion, Modified_date = x.Modified_date }).Where(x => x.First_name == objprop.First_name).FirstOrDefault();
            return obj;
            
        }

        public search_Common get_middlename(search_Common objprop)
        {
            var obj = objent.tbl_person.Select(x => new search_Common { Id = x.Id, First_name = x.First_name, Middle_name = x.Middle_name, Last_name = x.Last_name, Email_Promotion = x.Email_Promotion, Modified_date = x.Modified_date }).Where(x =>x.Middle_name==objprop.Middle_name).FirstOrDefault();
            return obj;

        }

        public search_Common get_lastname(search_Common objprop)
        {
            var obj = objent.tbl_person.Select(x => new search_Common { Id = x.Id, First_name = x.First_name, Middle_name = x.Middle_name, Last_name = x.Last_name, Email_Promotion = x.Email_Promotion, Modified_date = x.Modified_date }).Where(x =>x.Last_name==objprop.Last_name).FirstOrDefault();
            return obj;

        }

        public search_Common get_email(search_Common objprop)
        {
            var obj = objent.tbl_person.Select(x => new search_Common { Id = x.Id, First_name = x.First_name, Middle_name = x.Middle_name, Last_name = x.Last_name, Email_Promotion = x.Email_Promotion, Modified_date = x.Modified_date }).Where(x =>x.Email_Promotion==objprop.Email_Promotion).FirstOrDefault();
            return obj;

        } 







    }
}
