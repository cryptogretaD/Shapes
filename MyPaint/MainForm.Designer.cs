
namespace MyPaint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnTriangle = new System.Windows.Forms.RadioButton();
            this.rbtnRectangle = new System.Windows.Forms.RadioButton();
            this.rbtnSquare = new System.Windows.Forms.RadioButton();
            this.rbtnCircle = new System.Windows.Forms.RadioButton();
            this.btnBorder = new System.Windows.Forms.Button();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActivateFill = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.pbxBorderColor = new System.Windows.Forms.PictureBox();
            this.pbxFillBrush = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbxActions = new System.Windows.Forms.ComboBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBorderColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFillBrush)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(285, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 707);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.rbtnTriangle);
            this.groupBox1.Controls.Add(this.rbtnRectangle);
            this.groupBox1.Controls.Add(this.rbtnSquare);
            this.groupBox1.Controls.Add(this.rbtnCircle);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(260, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Shape";
            // 
            // rbtnTriangle
            // 
            this.rbtnTriangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnTriangle.BackgroundImage = global::MyPaint.Properties.Resources._05triangle;
            this.rbtnTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtnTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnTriangle.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnTriangle.Location = new System.Drawing.Point(145, 32);
            this.rbtnTriangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnTriangle.Name = "rbtnTriangle";
            this.rbtnTriangle.Size = new System.Drawing.Size(84, 48);
            this.rbtnTriangle.TabIndex = 4;
            this.rbtnTriangle.UseVisualStyleBackColor = true;
            this.rbtnTriangle.Click += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnRectangle
            // 
            this.rbtnRectangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnRectangle.BackColor = System.Drawing.SystemColors.Control;
            this.rbtnRectangle.BackgroundImage = global::MyPaint.Properties.Resources._03rectangle;
            this.rbtnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtnRectangle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRectangle.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnRectangle.Location = new System.Drawing.Point(130, 132);
            this.rbtnRectangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnRectangle.Name = "rbtnRectangle";
            this.rbtnRectangle.Size = new System.Drawing.Size(99, 55);
            this.rbtnRectangle.TabIndex = 2;
            this.rbtnRectangle.UseVisualStyleBackColor = false;
            this.rbtnRectangle.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnSquare
            // 
            this.rbtnSquare.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnSquare.BackgroundImage = global::MyPaint.Properties.Resources._02square;
            this.rbtnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtnSquare.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnSquare.Location = new System.Drawing.Point(16, 139);
            this.rbtnSquare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnSquare.Name = "rbtnSquare";
            this.rbtnSquare.Size = new System.Drawing.Size(60, 48);
            this.rbtnSquare.TabIndex = 1;
            this.rbtnSquare.UseVisualStyleBackColor = true;
            this.rbtnSquare.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnCircle
            // 
            this.rbtnCircle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnCircle.BackgroundImage = global::MyPaint.Properties.Resources._01circle;
            this.rbtnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbtnCircle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCircle.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnCircle.Location = new System.Drawing.Point(16, 25);
            this.rbtnCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnCircle.Name = "rbtnCircle";
            this.rbtnCircle.Size = new System.Drawing.Size(60, 55);
            this.rbtnCircle.TabIndex = 0;
            this.rbtnCircle.UseVisualStyleBackColor = true;
            this.rbtnCircle.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // btnBorder
            // 
            this.btnBorder.Location = new System.Drawing.Point(9, 34);
            this.btnBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorder.Name = "btnBorder";
            this.btnBorder.Size = new System.Drawing.Size(88, 28);
            this.btnBorder.TabIndex = 4;
            this.btnBorder.Text = "Border";
            this.btnBorder.UseVisualStyleBackColor = true;
            this.btnBorder.Click += new System.EventHandler(this.btnBorder_Click);
            // 
            // btnFillColor
            // 
            this.btnFillColor.Location = new System.Drawing.Point(164, 34);
            this.btnFillColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(88, 28);
            this.btnFillColor.TabIndex = 4;
            this.btnFillColor.Text = "Fill Color";
            this.btnFillColor.UseVisualStyleBackColor = true;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActivateFill);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.btnBorder);
            this.groupBox2.Controls.Add(this.btnFillColor);
            this.groupBox2.Controls.Add(this.pbxBorderColor);
            this.groupBox2.Controls.Add(this.pbxFillBrush);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(16, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(260, 188);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Pickers";
            // 
            // btnActivateFill
            // 
            this.btnActivateFill.Location = new System.Drawing.Point(164, 82);
            this.btnActivateFill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActivateFill.Name = "btnActivateFill";
            this.btnActivateFill.Size = new System.Drawing.Size(88, 28);
            this.btnActivateFill.TabIndex = 6;
            this.btnActivateFill.Text = "Activate Fill";
            this.btnActivateFill.UseVisualStyleBackColor = true;
            this.btnActivateFill.Click += new System.EventHandler(this.btnActivateFill_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(8, 86);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(88, 22);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // pbxBorderColor
            // 
            this.pbxBorderColor.BackColor = System.Drawing.Color.Black;
            this.pbxBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxBorderColor.Location = new System.Drawing.Point(9, 122);
            this.pbxBorderColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxBorderColor.Name = "pbxBorderColor";
            this.pbxBorderColor.Size = new System.Drawing.Size(87, 49);
            this.pbxBorderColor.TabIndex = 2;
            this.pbxBorderColor.TabStop = false;
            // 
            // pbxFillBrush
            // 
            this.pbxFillBrush.BackColor = System.Drawing.Color.Gainsboro;
            this.pbxFillBrush.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFillBrush.Location = new System.Drawing.Point(164, 122);
            this.pbxFillBrush.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxFillBrush.Name = "pbxFillBrush";
            this.pbxFillBrush.Size = new System.Drawing.Size(87, 49);
            this.pbxFillBrush.TabIndex = 3;
            this.pbxFillBrush.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 447);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 180);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cbxActions
            // 
            this.cbxActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActions.FormattingEnabled = true;
            this.cbxActions.Items.AddRange(new object[] {
            "Calculate Area and Parameter",
            "Delete",
            "Import",
            "Export"});
            this.cbxActions.Location = new System.Drawing.Point(16, 635);
            this.cbxActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxActions.Name = "cbxActions";
            this.cbxActions.Size = new System.Drawing.Size(249, 24);
            this.cbxActions.TabIndex = 7;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(16, 668);
            this.btnAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(251, 28);
            this.btnAction.TabIndex = 8;
            this.btnAction.Text = "Execute";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 737);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.cbxActions);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBorderColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFillBrush)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCircle;
        private System.Windows.Forms.RadioButton rbtnRectangle;
        private System.Windows.Forms.RadioButton rbtnSquare;
        private System.Windows.Forms.PictureBox pbxBorderColor;
        private System.Windows.Forms.PictureBox pbxFillBrush;
        private System.Windows.Forms.Button btnBorder;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btnActivateFill;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbxActions;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.RadioButton rbtnTriangle;
    }
}

