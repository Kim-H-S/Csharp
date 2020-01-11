// 테이블에 컬럼과 로우를 넣고 출력한다.

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

            foreach(DataRow PrintRow in table1.Rows)
            {
                string str;
                if (PrintRow["Male"].ToString() == "True")
                    str = "남자";
                else
                    str = "여자";

                Console.WriteLine("이름:{0} 나이:{1:d2} 성별:{2}", PrintRow["Name"], PrintRow["Age"], str);
            }
        }
    }
}
