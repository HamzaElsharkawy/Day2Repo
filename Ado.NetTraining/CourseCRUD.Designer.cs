namespace Ado.NetTraining
{
    partial class CourseCRUD
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
            dgv_courses = new DataGridView();
            NameInput = new TextBox();
            DurationInput = new NumericUpDown();
            IdInput = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TopicInput = new ComboBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DurationInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IdInput).BeginInit();
            SuspendLayout();
            // 
            // dgv_courses
            // 
            dgv_courses.ColumnHeadersHeight = 29;
            dgv_courses.Location = new Point(97, 12);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.RowHeadersWidth = 51;
            dgv_courses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_courses.Size = new Size(600, 240);
            dgv_courses.TabIndex = 0;
            dgv_courses.RowHeaderMouseDoubleClick += dgv_courses_RowHeaderMouseDoubleClick;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(434, 301);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(144, 27);
            NameInput.TabIndex = 2;
            // 
            // DurationInput
            // 
            DurationInput.Location = new Point(145, 373);
            DurationInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            DurationInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DurationInput.Name = "DurationInput";
            DurationInput.Size = new Size(144, 27);
            DurationInput.TabIndex = 12;
            DurationInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // IdInput
            // 
            IdInput.Location = new Point(145, 301);
            IdInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            IdInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            IdInput.Name = "IdInput";
            IdInput.Size = new Size(144, 27);
            IdInput.TabIndex = 13;
            IdInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 303);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 15;
            label2.Text = "Course Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(312, 303);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 16;
            label3.Text = "Course Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(317, 377);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 17;
            label4.Text = "Course Topic";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(-1, 376);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 18;
            label5.Text = "Course Duration";
            // 
            // TopicInput
            // 
            TopicInput.FormattingEnabled = true;
            TopicInput.Location = new Point(434, 375);
            TopicInput.Name = "TopicInput";
            TopicInput.Size = new Size(144, 28);
            TopicInput.TabIndex = 19;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(616, 286);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 20;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(616, 341);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 21;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(616, 399);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 22;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // CourseCRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(818, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(TopicInput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(IdInput);
            Controls.Add(DurationInput);
            Controls.Add(NameInput);
            Controls.Add(dgv_courses);
            Name = "CourseCRUD";
            Text = "Courses";
            Load += CourseCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            ((System.ComponentModel.ISupportInitialize)DurationInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)IdInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_courses;
        private TextBox NameInput;
        private NumericUpDown DurationInput;
        private NumericUpDown IdInput;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox TopicInput;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
    }
}
