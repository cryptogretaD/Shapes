using System;
using System.Windows.Forms;

using MyPaint.Models;

namespace MyPaint
{
    public partial class SecondForm : Form
    {
        public Shape Shape { get; set; }

        public SecondForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            lblShapeName.Text = Shape.ToString();
            lblShapeDetails.Text = Shape.ShowResult();
        }
    }
}
