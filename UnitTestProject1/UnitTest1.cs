using NUnit.Framework;
using создание_исходных_данных;

namespace UnitTestProject1.Folder1
{
    public class UnitTest1
    {
        [Test]
        public void Проверка_чтения_значений()
        {
            ExpertZhopa.LoadDataTxt();
            //TODO доделать тесты
            Assert.AreEqual(0,0);
        }

        [Test]
        public void Проверка_чтения_TermNames()
        {
            ExpertZhopa.LoadTermsTxt();
            //TODO доделать тесты
            Assert.AreEqual(0, 0);
        }

        [Test]
        public void Проверка_чтения_TermValues()
        {
            ExpertZhopa.LoadTermValuesTxt();
            //TODO доделать тесты
            Assert.AreEqual(0, 0);
        }
    }
}
