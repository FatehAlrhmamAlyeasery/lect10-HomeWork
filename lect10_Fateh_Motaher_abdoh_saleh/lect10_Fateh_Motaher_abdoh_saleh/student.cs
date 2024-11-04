using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lect10_Fateh_Motaher_abdoh_saleh
{
  public  class student
    {
        private int number;
        private string name;
        private string birthdate;
        private string imagepath;
        public void setnumber(int n)
        { number = n; }
        public void setname(string n)
        {
            name = n;
        }
        public void setbirtdate(string bd)
        {
            birthdate = bd;
        }
        public void setimagpath(string imgpath)
        {
            imagepath = imgpath;
        }
        public int getnumber() { return number; }
        public string getname() { return name; }
        public string getbirthdate() { return birthdate; }
        public string getimagepath() { return imagepath; }
    }
}
