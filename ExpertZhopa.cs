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

        public static List<List<int>> LoadDataTxt()
        {
            var dataList = new List<List<int>>();
            for (var i = 0; i < 8; i++)
            {
                dataList.Add(new List<int>());
            }
            using (var streamReader = new StreamReader("text.txt"))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    var mas = line.Replace(" ", "").Select(x => Convert.ToInt32(x.ToString())).ToList();
                    if (mas.Count == 5)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            dataList[i].Add(mas[i]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            dataList[i+5].Add(mas[i]);
                        }
                    }
                }
            }

            return dataList;
        }

        public static List<string> LoadTermsTxt()
        {
            using (var streamReader = new StreamReader("TermNames.txt", Encoding.Unicode))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadToEnd().Replace("\r", "");
                    var mas = line.Split().ToList();
                    return mas;
                }
            }

            return new List<string>();
        }

        public static List<string> LoadTermValuesTxt()
        {
            using (var streamReader = new StreamReader("TermValues.txt", Encoding.Unicode))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadToEnd().Replace("\r", "");
                    var mas = line.Split().ToList();
                    return mas;
                }
            }

            return new List<string>();
        }

        public static void AddToMatrix()
        {

        }

        public void Go()
        {
            
        }
    }
}
