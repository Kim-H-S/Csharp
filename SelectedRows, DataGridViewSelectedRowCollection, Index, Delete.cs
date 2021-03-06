// DataGridView.SelectedRows
// DataGridViewSelectedRowCollection
// DataGridViewSelectedRowCollection[i].Index
// DataRow.Delete

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable Table1 = new DataTable("table1");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1단계
            // DataTable과 DataColumn 만들기
            //DataTable Table1 = new DataTable("table1");
            DataColumn Col1 = new DataColumn("Name", typeof(string));
            Table1.Columns.Add(Col1);
            // 프라이머리 키
            Table1.PrimaryKey = new DataColumn[] { Col1 };

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

            foreach (DataRow PrintRow in Table1.Rows)
            {
                string str;
                if (PrintRow["Male"].ToString() == "True")
                    str = "남자";
                else
                    str = "여자";

                Console.WriteLine("이름:{0} 나이:{1:d2} 성별:{2}", PrintRow["Name"], PrintRow["Age"], str);
            }
        }

        /// <summary>
        /// '입력 버튼' 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInput_Click(object sender, EventArgs e)
        {
            // DataTable.NewRow
            // DataRow를 생성한다.
            DataRow row = Table1.NewRow();
            // TextBox.Text
            // string형
            row["Name"] = txtName.Text;
            // int.Parse            // = 컨버트투int
            // int로 형변환한다.
            row["Age"] = int.Parse(txtAge.Text);
            // RadioButton.Checked
            // 라디오버튼이 체크되어 있다.
            if (rdoMale.Checked)
                row["Male"] = true;
            else
                row["Male"] = false;
            // DataTable.Rows.Add
            // 테이블에 로우를 추가한다.
            Table1.Rows.Add(row);
        }

        /// <summary>
        /// '삭제 버튼' 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // 삭제 2가지 방법

            // 선택한 행 가져오기
            // DataGridView.SelectedRows
            // 선택된 컬렉션을 가져온다.
            DataGridViewSelectedRowCollection Rows = dataGridView1.SelectedRows;
            // DataGridViewSelectedRowCollection[i].Index
            // 데이터그리드뷰에 있는 실제 인덱스를 가져온다.
            // [0].Index
            // DataGridView가 1개 밖에 안들어가서 1번째 요소를 가져온다.
            int SelectedRowIndex = Rows[0].Index;
            DataRow Row = Table1.Rows[SelectedRowIndex];
            // DataRow.Delete
            // 로우를 삭제한다.
            Row.Delete();
            // 커밋
            Table1.AcceptChanges();


        }
    }
}
