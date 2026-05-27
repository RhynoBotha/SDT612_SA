namespace SectionC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOutput = new Label();
            label1 = new Label();
            txtCode = new TextBox();
            label2 = new Label();
            txtMake = new TextBox();
            label3 = new Label();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            tblMobilePhones = new ListBox();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(304, 25);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(65, 28);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 103);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 1;
            label1.Text = "Mobile Code:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(280, 104);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(264, 27);
            txtCode.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(144, 162);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "Make:";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(280, 162);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(264, 27);
            txtMake.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(144, 231);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 5;
            label3.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(275, 229);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(269, 27);
            txtQuantity.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(154, 321);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 44);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(298, 320);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 45);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(449, 319);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 46);
            btnFind.TabIndex = 9;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // tblMobilePhones
            // 
            tblMobilePhones.FormattingEnabled = true;
            tblMobilePhones.Location = new Point(604, 61);
            tblMobilePhones.Name = "tblMobilePhones";
            tblMobilePhones.Size = new Size(448, 304);
            tblMobilePhones.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 450);
            Controls.Add(tblMobilePhones);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(txtMake);
            Controls.Add(label2);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Mobile Stock Capture Window";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Label label1;
        private TextBox txtCode;
        private Label label2;
        private TextBox txtMake;
        private Label label3;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
        private ListBox tblMobilePhones;
    }
}
