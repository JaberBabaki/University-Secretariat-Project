using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnelMangement.clas
{
    class Calculation
    {
        private string degree;
        private string var_per;
        private string Base;
        private DeterminateFactor determinateFactor;
        List<Input> listZareb = new List<Input>();
        public string Degree
        {
            set { degree = value; }
            get { return degree; }
        }
        public string Var_per
        {
            set { var_per = value; }
            get { return var_per; }
        }
        public string bse
        {
            set { Base = value; }
            get { return Base; }
        }
        public Calculation(string degre){
            Degree = degre.Trim(); 
            determinateFactor = new DeterminateFactor();
            determinateFactor.Degree = degre.Trim();
            listZareb  = determinateFactor.getAllZareb();
        }
        public double selectF()
        {
            
            if (Degree == "استاد")
            {
                return calSalarBaseOstad();
            }
            else if (Degree == "مربی")
            {
                return calSalarBaseCoach();
            }
            else if (Degree == "دانشیار")
            {
                return calSalarBaseAssociate();
            }
            else if (Degree == "استادیار")
            {
                return calSalarBaseAssistant();
            }
            else if (Degree == "مربی آموزشیار")
            {
                return calSalarBaseAmozesh();
            }
            return 0;
        }
        public double calSalarBaseCoach(){

            return listZareb[0]. costBase * (100 + (5 * Convert.ToInt16(bse)));
        }
        public double calSalarBaseAmozesh()
        {

            return listZareb[0].costBase * (90 + (5 * Convert.ToInt16(bse)));
        }
        public double calSalarBaseAssociate()
        {

            return listZareb[0].costBase * (145 + (5 * Convert.ToInt16(bse)));
        }
        public double calSalarBaseOstad()
        {

            return listZareb[0].costBase * (170 + (5 * Convert.ToInt16(bse)));
        }
        public double calSalarBaseAssistant()
        {

            return listZareb[0].costBase * (125 + (5 * Convert.ToInt16(bse)));
        }
        public double calAbsorption()
        {
            return listZareb[0].absorption * selectF();
        }
        public double calSpecial()
        {
            return listZareb[0].special * selectF();
        }
        public double calPartical()
        {
           // MessageBox.Show("   " + listZareb[0].partical * selectF());
            return listZareb[0].partical * selectF();
        }
        public double calHelpCost()
        {
            return (( selectF()) * 57) / 100;
        }
        public double calHelpChild()
        {
            return (selectF() * 10) / 100;
        }
    }
}
