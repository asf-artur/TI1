using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace создание_исходных_данных
{
    public class FormObjectClass
    {
        public static DataGridView DataGridView;
        public static Panel Panel;
        public static Form1 Form1;
        public static ExpertZhopa ExpertZhopa;

        public static void SetFromObjectProps()
        {
            if (DataGridView.ColumnCount != 0)
                DataGridView.Width = DataGridView.ColumnCount * DataGridView.Columns[0].Width + 10;
            DataGridView.Height = (DataGridView.RowCount + 2) * DataGridView.Rows[0].Height;
            //Form1.Width = DataGridView.Width + 50;
            //Form1.Height = DataGridView.Height + 30;
            //Panel.Width = DataGridView.Width;
            //Panel.Height = DataGridView.Height + 10;
        }
        public static void GenerateColumnsDgv(List<string> expertNames)
        {
            var columnNames = ExpertZhopa.TermValueList;
            var rowNames = expertNames;
            foreach (var columnName in columnNames)
            {
                var tempColumn = new DataGridViewColumn
                {
                    HeaderText = columnName,
                    Name = columnName,
                    CellTemplate = new DataGridViewTextBoxCell(),
                    ReadOnly = false,
                    Resizable = DataGridViewTriState.False,
                    Width = 60
                };
                if (columnName == columnNames[0] || columnName == columnNames[1])
                {
                    tempColumn.ReadOnly = true;
                    tempColumn.Width = 90;
                }
                DataGridView.Columns.Add(tempColumn);
            }
            DataGridView.Rows.AddRange(rowNames.Select(x =>
            {
                var tempRow = new DataGridViewRow
                {
                    Resizable = DataGridViewTriState.False
                };
                var cell = new DataGridViewTextBoxCell
                {
                    Value = x
                };
                tempRow.Cells.Add(cell);
                return tempRow;
            }).ToArray());
        }

        public static void GenerateList()
        {
            var expertCount = ExpertZhopa.ExpertCount;
            var termList = ExpertZhopa.TermList;
            var expertNames = new List<string>();
            foreach (var enums in Enumerable.Range(1, expertCount).Select(x => $"Экс{x}"))
            {
                for (var i = 0; i < termList.Count; i++)
                {
                    expertNames.Add(enums);
                }
            }

            var column1 = new List<string>();
            for (var i = 0; i < expertCount; i++)
            {
                foreach (var enums in termList)
                {
                    column1.Add(enums);
                }
            }

            GenerateColumnsDgv(expertNames);
            var ie = column1.GetEnumerator();
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                ie.MoveNext();
                row.Cells[1].Value = ie.Current;
                foreach (DataGridViewTextBoxCell cell in row.Cells)
                {
                    if (cell != row.Cells[1] && cell != row.Cells[0])
                    {
                        cell.Value = 0;
                    }
                }
            }
            ie.Dispose();
        }
    }
}
