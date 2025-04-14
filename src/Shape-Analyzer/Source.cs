using System;
using System.Windows.Forms;

namespace Shape_Analyzer
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            //New
        }

        private void OpenProjectButton_Click(object sender, EventArgs e)
        {
            using(var ofd = new OpenFileDialog() { Filter = "プロジェクトファイル（*.sap）| *.sap"})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Loaded
                }
            }
        }

        private void OpenMapDataButton_Click(object sender, EventArgs e)
        {
            using(var ofd = new OpenFileDialog() { Filter = "地図データ（*.shp）| *.shp" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Loaded
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Save
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            //SaveAs
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
