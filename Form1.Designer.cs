namespace ZXC
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Zxc = new TabPage();
            buttonCalculateLinear = new Button();
            textBoxLinearResult = new TextBox();
            label1 = new Label();
            textBoxZLinear = new TextBox();
            textBoxYLinear = new TextBox();
            textBoxXLinear = new TextBox();
            Z = new Label();
            Y = new Label();
            X = new Label();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            textBoxBranchResult = new TextBox();
            label5 = new Label();
            buttonCalculateBranch = new Button();
            comboBoxFunction = new ComboBox();
            label4 = new Label();
            textBoxYBranch = new TextBox();
            textBoxXBranch = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            Zxc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Zxc);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // Zxc
            // 
            Zxc.Controls.Add(buttonCalculateLinear);
            Zxc.Controls.Add(textBoxLinearResult);
            Zxc.Controls.Add(label1);
            Zxc.Controls.Add(textBoxZLinear);
            Zxc.Controls.Add(textBoxYLinear);
            Zxc.Controls.Add(textBoxXLinear);
            Zxc.Controls.Add(Z);
            Zxc.Controls.Add(Y);
            Zxc.Controls.Add(X);
            Zxc.Controls.Add(pictureBox1);
            Zxc.Location = new Point(4, 24);
            Zxc.Name = "Zxc";
            Zxc.Padding = new Padding(3);
            Zxc.Size = new Size(792, 422);
            Zxc.TabIndex = 0;
            Zxc.Text = "Линейный алгоритм";
            Zxc.UseVisualStyleBackColor = true;
            // 
            // buttonCalculateLinear
            // 
            buttonCalculateLinear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCalculateLinear.Location = new Point(18, 231);
            buttonCalculateLinear.Name = "buttonCalculateLinear";
            buttonCalculateLinear.Size = new Size(117, 45);
            buttonCalculateLinear.TabIndex = 8;
            buttonCalculateLinear.Text = "Вычеслить";
            buttonCalculateLinear.UseVisualStyleBackColor = true;
            buttonCalculateLinear.Click += buttonCalculateLinear_Click;
            // 
            // textBoxLinearResult
            // 
            textBoxLinearResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLinearResult.Location = new Point(124, 282);
            textBoxLinearResult.Name = "textBoxLinearResult";
            textBoxLinearResult.ReadOnly = true;
            textBoxLinearResult.Size = new Size(192, 33);
            textBoxLinearResult.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(18, 290);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 6;
            label1.Text = "Результат:";
            // 
            // textBoxZLinear
            // 
            textBoxZLinear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxZLinear.Location = new Point(224, 184);
            textBoxZLinear.Name = "textBoxZLinear";
            textBoxZLinear.Size = new Size(165, 33);
            textBoxZLinear.TabIndex = 5;
            // 
            // textBoxYLinear
            // 
            textBoxYLinear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxYLinear.Location = new Point(224, 141);
            textBoxYLinear.Name = "textBoxYLinear";
            textBoxYLinear.Size = new Size(165, 33);
            textBoxYLinear.TabIndex = 5;
            // 
            // textBoxXLinear
            // 
            textBoxXLinear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxXLinear.Location = new Point(224, 99);
            textBoxXLinear.Name = "textBoxXLinear";
            textBoxXLinear.Size = new Size(165, 33);
            textBoxXLinear.TabIndex = 4;
            // 
            // Z
            // 
            Z.AutoSize = true;
            Z.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Z.Location = new Point(18, 192);
            Z.Name = "Z";
            Z.Size = new Size(189, 25);
            Z.TabIndex = 3;
            Z.Text = "Введите значение Z:";
            // 
            // Y
            // 
            Y.AutoSize = true;
            Y.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Y.Location = new Point(18, 149);
            Y.Name = "Y";
            Y.Size = new Size(189, 25);
            Y.TabIndex = 2;
            Y.Text = "Введите значение Y:";
            // 
            // X
            // 
            X.AutoSize = true;
            X.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            X.Location = new Point(18, 107);
            X.Name = "X";
            X.Size = new Size(189, 25);
            X.TabIndex = 1;
            X.Text = "Введите значение X:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WINWORD_ZWdu2HZx83;
            pictureBox1.Location = new Point(18, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 76);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBoxBranchResult);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(buttonCalculateBranch);
            tabPage2.Controls.Add(comboBoxFunction);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBoxYBranch);
            tabPage2.Controls.Add(textBoxXBranch);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Разветвляющийся алгоритм";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxBranchResult
            // 
            textBoxBranchResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxBranchResult.Location = new Point(125, 275);
            textBoxBranchResult.Name = "textBoxBranchResult";
            textBoxBranchResult.ReadOnly = true;
            textBoxBranchResult.Size = new Size(163, 33);
            textBoxBranchResult.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(19, 283);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 8;
            label5.Text = "Результат:";
            // 
            // buttonCalculateBranch
            // 
            buttonCalculateBranch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCalculateBranch.Location = new Point(19, 220);
            buttonCalculateBranch.Name = "buttonCalculateBranch";
            buttonCalculateBranch.Size = new Size(132, 42);
            buttonCalculateBranch.TabIndex = 7;
            buttonCalculateBranch.Text = "Вычеслить";
            buttonCalculateBranch.UseVisualStyleBackColor = true;
            buttonCalculateBranch.Click += buttonCalculateBranch_Click;
            // 
            // comboBoxFunction
            // 
            comboBoxFunction.FormattingEnabled = true;
            comboBoxFunction.Items.AddRange(new object[] { "cos(x)", "x^2", "e^x" });
            comboBoxFunction.Location = new Point(643, 135);
            comboBoxFunction.Name = "comboBoxFunction";
            comboBoxFunction.Size = new Size(130, 23);
            comboBoxFunction.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(420, 133);
            label4.Name = "label4";
            label4.Size = new Size(217, 25);
            label4.TabIndex = 5;
            label4.Text = "Выберите функцию f(x):";
            // 
            // textBoxYBranch
            // 
            textBoxYBranch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxYBranch.Location = new Point(229, 170);
            textBoxYBranch.Name = "textBoxYBranch";
            textBoxYBranch.Size = new Size(163, 33);
            textBoxYBranch.TabIndex = 4;
            // 
            // textBoxXBranch
            // 
            textBoxXBranch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxXBranch.Location = new Point(229, 125);
            textBoxXBranch.Name = "textBoxXBranch";
            textBoxXBranch.Size = new Size(163, 33);
            textBoxXBranch.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(19, 178);
            label3.Name = "label3";
            label3.Size = new Size(189, 25);
            label3.TabIndex = 2;
            label3.Text = "Введите значение Y:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(19, 133);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 1;
            label2.Text = "Введите значение X:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.WINWORD_py4rj1fxyd;
            pictureBox2.Location = new Point(19, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(362, 92);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Zxc.ResumeLayout(false);
            Zxc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Zxc;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Label X;
        private Label Z;
        private Label Y;
        private TextBox textBoxXLinear;
        private TextBox textBoxZLinear;
        private TextBox textBoxYLinear;
        private TextBox textBoxLinearResult;
        private Label label1;
        private Button buttonCalculateLinear;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox textBoxYBranch;
        private TextBox textBoxXBranch;
        private Label label3;
        private ComboBox comboBoxFunction;
        private Label label4;
        private Button buttonCalculateBranch;
        private TextBox textBoxBranchResult;
        private Label label5;
    }
}
