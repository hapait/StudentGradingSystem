namespace GradingSystem
{
    partial class CourseInfoPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.teacherInfoButton = new System.Windows.Forms.Button();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradingSystemDataSet = new GradingSystem.GradingSystemDataSet();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.teacherTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.displayInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradingSystemDataSet3 = new GradingSystem.GradingSystemDataSet3();
            this.gradingSystemDataSet1 = new GradingSystem.GradingSystemDataSet1();
            this.teacherInfoTableAdapter = new GradingSystem.GradingSystemDataSetTableAdapters.TeacherInfoTableAdapter();
            this.teacherInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradingSystemDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter = new GradingSystem.GradingSystemDataSetTableAdapters.StudentInfoTableAdapter();
            this.studentInfoButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.courseInfoButton = new System.Windows.Forms.Button();
            this.gradingSystemDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gradingSystemDataSet1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gradingSystemDataSet2 = new GradingSystem.GradingSystemDataSet2();
            this.gradingSystemDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseInfoTableAdapter = new GradingSystem.GradingSystemDataSet3TableAdapters.CourseInfoTableAdapter();
            this.deleteButt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet)).BeginInit();
            this.displayInfoTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherInfoButton
            // 
            this.teacherInfoButton.AutoSize = true;
            this.teacherInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherInfoButton.Location = new System.Drawing.Point(-223, -40);
            this.teacherInfoButton.Name = "teacherInfoButton";
            this.teacherInfoButton.Size = new System.Drawing.Size(213, 35);
            this.teacherInfoButton.TabIndex = 32;
            this.teacherInfoButton.Text = "Teacher Information";
            this.teacherInfoButton.UseVisualStyleBackColor = true;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.gradingSystemDataSet;
            // 
            // gradingSystemDataSet
            // 
            this.gradingSystemDataSet.DataSetName = "GradingSystemDataSet";
            this.gradingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // creditTextBox
            // 
            this.creditTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creditTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditTextBox.Location = new System.Drawing.Point(188, 308);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.Size = new System.Drawing.Size(357, 31);
            this.creditTextBox.TabIndex = 9;
            this.creditTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teacherTextBox
            // 
            this.teacherTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teacherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherTextBox.Location = new System.Drawing.Point(188, 214);
            this.teacherTextBox.Name = "teacherTextBox";
            this.teacherTextBox.Size = new System.Drawing.Size(357, 31);
            this.teacherTextBox.TabIndex = 8;
            this.teacherTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(188, 122);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(357, 31);
            this.titleTextBox.TabIndex = 7;
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.courseIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdTextBox.Location = new System.Drawing.Point(188, 30);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(357, 31);
            this.courseIdTextBox.TabIndex = 6;
            this.courseIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(57, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Credit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(46, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(65, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayInfoTable
            // 
            this.displayInfoTable.ColumnCount = 2;
            this.displayInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.displayInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.displayInfoTable.Controls.Add(this.label1, 0, 0);
            this.displayInfoTable.Controls.Add(this.label2, 0, 1);
            this.displayInfoTable.Controls.Add(this.label3, 0, 2);
            this.displayInfoTable.Controls.Add(this.label4, 0, 3);
            this.displayInfoTable.Controls.Add(this.courseIdTextBox, 1, 0);
            this.displayInfoTable.Controls.Add(this.titleTextBox, 1, 1);
            this.displayInfoTable.Controls.Add(this.teacherTextBox, 1, 2);
            this.displayInfoTable.Controls.Add(this.creditTextBox, 1, 3);
            this.displayInfoTable.Location = new System.Drawing.Point(680, 86);
            this.displayInfoTable.Name = "displayInfoTable";
            this.displayInfoTable.RowCount = 4;
            this.displayInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.displayInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.displayInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.displayInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.displayInfoTable.Size = new System.Drawing.Size(550, 371);
            this.displayInfoTable.TabIndex = 24;
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(868, 486);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(91, 35);
            this.updateButton.TabIndex = 25;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.AutoSize = true;
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(707, 486);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(91, 35);
            this.insertButton.TabIndex = 26;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(1337, 603);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(91, 35);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1150, 57);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 28;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(645, 677);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 29;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(285, -40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.teacherDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseInfoBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(1, 2, 3, 4);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Size = new System.Drawing.Size(467, 478);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "CourseId";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "CourseId";
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Teacher";
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseInfoBindingSource
            // 
            this.courseInfoBindingSource.DataMember = "CourseInfo";
            this.courseInfoBindingSource.DataSource = this.gradingSystemDataSet3;
            // 
            // gradingSystemDataSet3
            // 
            this.gradingSystemDataSet3.DataSetName = "GradingSystemDataSet3";
            this.gradingSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradingSystemDataSet1
            // 
            this.gradingSystemDataSet1.DataSetName = "GradingSystemDataSet1";
            this.gradingSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherInfoTableAdapter
            // 
            this.teacherInfoTableAdapter.ClearBeforeFill = true;
            // 
            // teacherInfoBindingSource
            // 
            this.teacherInfoBindingSource.DataMember = "TeacherInfo";
            this.teacherInfoBindingSource.DataSource = this.gradingSystemDataSet;
            // 
            // gradingSystemDataSet1BindingSource
            // 
            this.gradingSystemDataSet1BindingSource.DataSource = this.gradingSystemDataSet1;
            this.gradingSystemDataSet1BindingSource.Position = 0;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // studentInfoButton
            // 
            this.studentInfoButton.AutoSize = true;
            this.studentInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentInfoButton.Location = new System.Drawing.Point(12, 35);
            this.studentInfoButton.Name = "studentInfoButton";
            this.studentInfoButton.Size = new System.Drawing.Size(213, 35);
            this.studentInfoButton.TabIndex = 33;
            this.studentInfoButton.Text = "Student Information";
            this.studentInfoButton.UseVisualStyleBackColor = true;
            this.studentInfoButton.Click += new System.EventHandler(this.studentInfoButton_Click);
            // 
            // teacherButton
            // 
            this.teacherButton.AutoSize = true;
            this.teacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherButton.Location = new System.Drawing.Point(266, 35);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(213, 35);
            this.teacherButton.TabIndex = 34;
            this.teacherButton.Text = "Teacher Information";
            this.teacherButton.UseVisualStyleBackColor = true;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1385, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // courseInfoButton
            // 
            this.courseInfoButton.AutoSize = true;
            this.courseInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseInfoButton.Location = new System.Drawing.Point(24, -40);
            this.courseInfoButton.Name = "courseInfoButton";
            this.courseInfoButton.Size = new System.Drawing.Size(203, 35);
            this.courseInfoButton.TabIndex = 31;
            this.courseInfoButton.Text = "Course Information";
            this.courseInfoButton.UseVisualStyleBackColor = true;
            // 
            // gradingSystemDataSet1BindingSource1
            // 
            this.gradingSystemDataSet1BindingSource1.DataSource = this.gradingSystemDataSet1;
            this.gradingSystemDataSet1BindingSource1.Position = 0;
            // 
            // gradingSystemDataSet1BindingSource2
            // 
            this.gradingSystemDataSet1BindingSource2.DataSource = this.gradingSystemDataSet1;
            this.gradingSystemDataSet1BindingSource2.Position = 0;
            // 
            // gradingSystemDataSet2
            // 
            this.gradingSystemDataSet2.DataSetName = "GradingSystemDataSet2";
            this.gradingSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradingSystemDataSet2BindingSource
            // 
            this.gradingSystemDataSet2BindingSource.DataSource = this.gradingSystemDataSet2;
            this.gradingSystemDataSet2BindingSource.Position = 0;
            // 
            // courseInfoTableAdapter
            // 
            this.courseInfoTableAdapter.ClearBeforeFill = true;
            // 
            // deleteButt
            // 
            this.deleteButt.AutoSize = true;
            this.deleteButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButt.Location = new System.Drawing.Point(1024, 486);
            this.deleteButt.Name = "deleteButt";
            this.deleteButt.Size = new System.Drawing.Size(91, 35);
            this.deleteButt.TabIndex = 36;
            this.deleteButt.Text = "Delete";
            this.deleteButt.UseVisualStyleBackColor = true;
            this.deleteButt.Click += new System.EventHandler(this.deleteButt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 570);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CourseInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1242, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deleteButt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.teacherButton);
            this.Controls.Add(this.studentInfoButton);
            this.Controls.Add(this.courseInfoButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.displayInfoTable);
            this.Controls.Add(this.teacherInfoButton);
            this.Name = "CourseInfoPage";
            this.Text = "CourseInfoPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CourseInfoPage_FormClosed);
            this.Load += new System.EventHandler(this.CourseInfoPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet)).EndInit();
            this.displayInfoTable.ResumeLayout(false);
            this.displayInfoTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradingSystemDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button teacherInfoButton;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private GradingSystemDataSet gradingSystemDataSet;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.TextBox teacherTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel displayInfoTable;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource teacherInfoBindingSource;
        private GradingSystemDataSet1 gradingSystemDataSet1;
        private GradingSystemDataSetTableAdapters.TeacherInfoTableAdapter teacherInfoTableAdapter;
        private System.Windows.Forms.BindingSource gradingSystemDataSet1BindingSource;
        private GradingSystemDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.Button studentInfoButton;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button courseInfoButton;
        private System.Windows.Forms.BindingSource gradingSystemDataSet2BindingSource;
        private GradingSystemDataSet2 gradingSystemDataSet2;
        private System.Windows.Forms.BindingSource gradingSystemDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource gradingSystemDataSet1BindingSource2;
        private GradingSystemDataSet3 gradingSystemDataSet3;
        private System.Windows.Forms.BindingSource courseInfoBindingSource;
        private GradingSystemDataSet3TableAdapters.CourseInfoTableAdapter courseInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButt;
        private System.Windows.Forms.Button button2;

    }
}