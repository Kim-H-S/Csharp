// TableLayoutPanel

using System;
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
            // TableLayoutPanel에 '마지막 행 제거', '마지막 열 제거'를 적절히 사용해서 행과 열을 맞춘다.
            // TableLayoutPanel에 '행 및 열 편집'의 절대 픽셀을 적절히 줘서 크기를 맞춰준다.
            // TableLayoutPanel 안에 TableLayoutPanel를 만들 수 있다.
        }



    }
}
