// 테이블에 컬럼과 로우를 넣고 출력한다.
// foreach를 이용하여 출력한다.
// PrimaryKey
// DataTable.Rows.Find로 필터링한다.

using System;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1단계
            // DataTable과 DataColumn 만들기
            DataTable table1 = new DataTable("table1");
            DataColumn Col1 = new DataColumn("Name", typeof(string));
            table1.Columns.Add(Col1);
            // 프라이머리 키
            table1.PrimaryKey = new DataColumn[] { Col1 };

            Col1 = new DataColumn("Age", typeof(int));
            table1.Columns.Add(Col1);
            Col1 = new DataColumn("Male", typeof(bool));
            table1.Columns.Add(Col1);

            // 2단계
            // 행 생성 및 입역
            DataRow row = table1.NewRow();
            row["Name"] = "철수";
            row["Age"] = 12;
            row["Male"] = true;
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Name"] = "수지";
            row["Age"] = 11;
            row["Male"] = false;
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Name"] = "차돌";
            row["Age"] = 9;
            row["Male"] = true;
            table1.Rows.Add(row);
            table1.AcceptChanges();

            // DataTable.Rows.Find
            // 프라이머리 키를 찾는다.
            DataRow FindRow = table1.Rows.Find("철수");
            if(FindRow != null)
            {
                string str;
                if (FindRow["Male"].ToString() == "True")
                    str = "남자";
                else
                    str = "여자";

                Console.WriteLine("이름:{0} 나이:{1:d2} 성별:{2}", FindRow["Name"], FindRow["Age"], str);
            }
        }
    }
}
