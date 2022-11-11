using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTest1
{
    public class Reception     {
        public int ReceptionID { get; set; }
        public DateTime DataRec { get; set; }
        public DateTime DataFinal { get; set; }
        public int DiagnosisID { get; set; }
        public int DocID { get; set; }
        public int PacID { get; set; }
        public int NumRecipe { get; set; }
        public int NumAnalysis { get; set; }
    }
}
