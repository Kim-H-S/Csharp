// TableLayoutPanel -> 행 및 열 편집 -> 백분율

using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 사용자가 폼을 로드할떄마다 발생한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // TableLayoutPanel에 '행 및 열 편집'의 요소 2개에 백분율을 40%, 20% 나눠주면 2:1 비율로 나뉜다. 
            // TableLayoutPanel에 '행 및 열 편집'의 모든 요소에 백분율 100%가 넘는 값을 주면 같은 비율로 나뉜다.
        }



    }
}
