using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deedle;

namespace создание_исходных_данных
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ExpertZhopa calcObject;

        private void Form1_Load(object sender, EventArgs e)
        {
            var expertCount = 2;
            var columnsNames = "Эксперты Терм [160,165) [165,170)".Split().ToList();
            calcObject = new ExpertZhopa()
            {
                ExpertCount = expertCount,
                ConstructionMethod = ConstructionMethod.First,
                TermList = new List<string>() { "Низкий", "Высокий" },
                TermValueList = columnsNames,
                MatrixList = new List<List<int>>()
            };
            FormObjectClass.DataGridView = dataGridView1;
            FormObjectClass.Form1 = this;
            FormObjectClass.Panel = panel1;
            FormObjectClass.ExpertZhopa = calcObject;
            FormObjectClass.GenerateList();
            FormObjectClass.SetFromObjectProps();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            FormObjectClass.SetFromObjectProps();
        }
    }
}
