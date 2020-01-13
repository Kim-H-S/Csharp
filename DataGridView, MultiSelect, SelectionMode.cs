// DataGridView
// DataGridView.MultiSelect
// SelectionMode

using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1단계
            // DataTable과 DataColumn 만들기
            DataTable Table1 = new DataTable("table1");
            DataColumn Col1 = new DataColumn("Name", typeof(string));
            Table1.Columns.Add(Col1);

            Col1 = new DataColumn("Age", typeof(int));
            Table1.Columns.Add(Col1);
            Col1 = new DataColumn("Male", typeof(bool));
            Table1.Columns.Add(Col1);

            // 2단계
            // 행 생성 및 입역
            DataRow row = Table1.NewRow();
            row["Name"] = "철수";
            row["Age"] = 12;
            row["Male"] = true;
            Table1.Rows.Add(row);

            row = Table1.NewRow();
            row["Name"] = "수지";
            row["Age"] = 11;
            row["Male"] = false;
            Table1.Rows.Add(row);

            row = Table1.NewRow();
            row["Name"] = "차돌";
            row["Age"] = 9;
            row["Male"] = true;
            Table1.Rows.Add(row);
            dataGridView1.DataSource = Table1;
            // 한 행만 선택
            dataGridView1.MultiSelect = false;
            // DataGridView -> 속성 -> SelectionMode = FullRowSelect
            // 행에 포함된 셀을 클릭하면 전체 행이 선택된다.
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
