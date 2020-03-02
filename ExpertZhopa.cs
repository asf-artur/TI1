using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Deedle;

namespace создание_исходных_данных
{
    public class ExpertZhopa
    {
        public ConstructionMethod ConstructionMethod;
        public int ExpertCount;
        public List<string> TermList;
        public List<string> TermValueList;
        public List<ExpertDataClass> Experts;

        public ExpertZhopa()
        {
        }

        public void LoadDataTxt()
        {
            using (var streamReader = new StreamReader("text.txt"))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                }
            }
        }

        public void Go()
        {
            
        }
    }
}
