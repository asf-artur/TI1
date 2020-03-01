using System;
using System.Collections.Generic;
using System.Linq;
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
        public Frame<string, string> Frame;
        public List<List<int>> MatrixList;
        
        public ExpertZhopa()
        {

        }

        public ExpertZhopa(ConstructionMethod constructionMethod, int expertCount, List<string> termList, List<string> termValueList, Frame<string, string> frame)
        {
            ConstructionMethod = constructionMethod;
            ExpertCount = expertCount;
            TermList = termList;
            TermValueList = termValueList;
            Frame = frame;
        }

        public ExpertZhopa(ConstructionMethod constructionMethod, int expertCount, List<string> termList, List<string> termValueList, List<List<int>> matrixList)
        {
            ConstructionMethod = constructionMethod;
            ExpertCount = expertCount;
            TermList = termList;
            TermValueList = termValueList;
            MatrixList = matrixList;
        }

        public void Go()
        {
            
        }
    }
}
