using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Common;
using DAL;

namespace BLL
{
    public class person_BLL
    {
        search_DAL objdal = new search_DAL();

        public List<search_Common> getperson_list()
        {
          return objdal.getperson_list();
        }

        public search_Common get_firstname(search_Common objprop)
        {
            return objdal.get_firstname(objprop); 

        }

        public search_Common get_middlename(search_Common objprop)
        {
            return objdal.get_middlename(objprop);

        }

        public search_Common get_lastname(search_Common objprop)
        {
            return objdal.get_lastname(objprop);

        }

        public search_Common get_email(search_Common objprop)
        {
           
            return objdal.get_email(objprop);   
        }

    }
}
