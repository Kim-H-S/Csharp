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
            // Control -> 속성 -> RowSpan: 2
            // 해당 컨트롤이 2개의 로우를 사용할 수 있다.

            // Control -> 속성 -> Margin: 0, 0, 0, 0
            // 해당 컨트롤의 마진을 0, 0, 0, 0으로 만든다.
        }



    }
}
