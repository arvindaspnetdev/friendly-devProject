using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRData.PatientModel
{
   public class PatientDataModel
    {
        public List<ShowPatient_Result> Get()
        {
            using (EMREntities context = new EMREntities())
            {
               return context.ShowPatient().ToList();
            }
        }
    }
}
