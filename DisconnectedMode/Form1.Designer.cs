namespace DisconnectedMode
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
            btn_GetData = new Button();
            btn_UpdateDatabase = new Button();
            dgv_Instructors = new DataGridView();
            InputName = new TextBox();
            InputDegree = new TextBox();
            InputSalary = new NumericUpDown();
            InputDepartment = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Instructors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputSalary).BeginInit();
            SuspendLayout();
            // 
            // btn_GetData
            // 
            btn_GetData.Location = new Point(775, 14);
            btn_GetData.Margin = new Padding(4, 3, 4, 3);
            btn_GetData.Name = "btn_GetData";
            btn_GetData.Size = new Size(210, 48);
            btn_GetData.TabIndex = 0;
            btn_GetData.Text = "Get Data";
            btn_GetData.UseVisualStyleBackColor = true;
            btn_GetData.Click += btn_GetData_Click;
            // 
            // btn_UpdateDatabase
            // 
            btn_UpdateDatabase.Location = new Point(775, 578);
            btn_UpdateDatabase.Margin = new Padding(4, 3, 4, 3);
            btn_UpdateDatabase.Name = "btn_UpdateDatabase";
            btn_UpdateDatabase.Size = new Size(210, 48);
            btn_UpdateDatabase.TabIndex = 1;
            btn_UpdateDatabase.Text = "Update Database";
            btn_UpdateDatabase.UseVisualStyleBackColor = true;
            btn_UpdateDatabase.Click += btn_UpdateDatabase_Click;
            // 
            // dgv_Instructors
            // 
            dgv_Instructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Instructors.Location = new Point(15, 14);
            dgv_Instructors.Margin = new Padding(4, 3, 4, 3);
            dgv_Instructors.Name = "dgv_Instructors";
            dgv_Instructors.RowHeadersWidth = 51;
            dgv_Instructors.Size = new Size(682, 613);
            dgv_Instructors.TabIndex = 2;
            dgv_Instructors.RowHeaderMouseDoubleClick += dgv_Instructors_RowHeaderMouseDoubleClick;
            // 
            // InputName
            // 
            InputName.Location = new Point(860, 132);
            InputName.Margin = new Padding(4, 3, 4, 3);
            InputName.Name = "InputName";
            InputName.Size = new Size(186, 30);
            InputName.TabIndex = 4;
            // 
            // InputDegree
            // 
            InputDegree.Location = new Point(860, 215);
            InputDegree.Margin = new Padding(4, 3, 4, 3);
            InputDegree.Name = "InputDegree";
            InputDegree.Size = new Size(186, 30);
            InputDegree.TabIndex = 5;
            // 
            // InputSalary
            // 
            InputSalary.DecimalPlaces = 2;
            InputSalary.Location = new Point(858, 308);
            InputSalary.Margin = new Padding(4, 3, 4, 3);
            InputSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            InputSalary.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            InputSalary.Name = "InputSalary";
            InputSalary.Size = new Size(188, 30);
            InputSalary.TabIndex = 6;
            InputSalary.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // InputDepartment
            // 
            InputDepartment.FormattingEnabled = true;
            InputDepartment.Location = new Point(860, 386);
            InputDepartment.Margin = new Padding(4, 3, 4, 3);
            InputDepartment.Name = "InputDepartment";
            InputDepartment.Size = new Size(186, 31);
            InputDepartment.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveBorder;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(705, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveBorder;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(705, 218);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 10;
            label3.Text = "Degree";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveBorder;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(705, 310);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 11;
            label4.Text = "Salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.InactiveBorder;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(705, 386);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 12;
            label5.Text = "Department";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(890, 506);
            btn_delete.Margin = new Padding(4, 3, 4, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(146, 45);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(724, 506);
            btn_update.Margin = new Padding(4, 3, 4, 3);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(146, 45);
            btn_update.TabIndex = 14;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(804, 444);
            btn_add.Margin = new Padding(4, 3, 4, 3);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(146, 45);
            btn_add.TabIndex = 15;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1064, 641);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(InputDepartment);
            Controls.Add(InputSalary);
            Controls.Add(InputDegree);
            Controls.Add(InputName);
            Controls.Add(dgv_Instructors);
            Controls.Add(btn_UpdateDatabase);
            Controls.Add(btn_GetData);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Instructors";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Instructors).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_GetData;
        private Button btn_UpdateDatabase;
        private DataGridView dgv_Instructors;
        private TextBox InputName;
        private TextBox InputDegree;
        private NumericUpDown InputSalary;
        private ComboBox InputDepartment;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
    }
}
