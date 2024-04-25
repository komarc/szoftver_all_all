namespace _9_softw_RemotelDbTest
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            neptunDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            averageGradeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isActiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            studentBindingSource = new BindingSource(components);
            buttonSave = new Button();
            textBoxId = new TextBox();
            textBoxNeptun = new TextBox();
            textBoxName = new TextBox();
            textBoxBirthDate = new TextBox();
            textBoxAverageGRade = new TextBox();
            textBoxIsActive = new TextBox();
            label1 = new Label();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, neptunDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn, averageGradeDataGridViewTextBoxColumn, isActiveDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = studentBindingSource;
            dataGridView1.Location = new Point(60, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(676, 150);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // neptunDataGridViewTextBoxColumn
            // 
            neptunDataGridViewTextBoxColumn.DataPropertyName = "Neptun";
            neptunDataGridViewTextBoxColumn.HeaderText = "Neptun";
            neptunDataGridViewTextBoxColumn.Name = "neptunDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // averageGradeDataGridViewTextBoxColumn
            // 
            averageGradeDataGridViewTextBoxColumn.DataPropertyName = "AverageGrade";
            averageGradeDataGridViewTextBoxColumn.HeaderText = "AverageGrade";
            averageGradeDataGridViewTextBoxColumn.Name = "averageGradeDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(661, 66);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxId
            // 
            textBoxId.DataBindings.Add(new Binding("Text", studentBindingSource, "Neptun", true));
            textBoxId.Location = new Point(111, 185);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(79, 23);
            textBoxId.TabIndex = 2;
            textBoxId.TextChanged += textBoxId_TextChanged;
            // 
            // textBoxNeptun
            // 
            textBoxNeptun.Location = new Point(37, 42);
            textBoxNeptun.Name = "textBoxNeptun";
            textBoxNeptun.Size = new Size(496, 23);
            textBoxNeptun.TabIndex = 3;
            textBoxNeptun.TextChanged += textBoxNeptun_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(312, 185);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(79, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxBirthDate
            // 
            textBoxBirthDate.Location = new Point(412, 185);
            textBoxBirthDate.Name = "textBoxBirthDate";
            textBoxBirthDate.Size = new Size(79, 23);
            textBoxBirthDate.TabIndex = 5;
            // 
            // textBoxAverageGRade
            // 
            textBoxAverageGRade.Location = new Point(512, 185);
            textBoxAverageGRade.Name = "textBoxAverageGRade";
            textBoxAverageGRade.Size = new Size(79, 23);
            textBoxAverageGRade.TabIndex = 6;
            // 
            // textBoxIsActive
            // 
            textBoxIsActive.Location = new Point(610, 185);
            textBoxIsActive.Name = "textBoxIsActive";
            textBoxIsActive.Size = new Size(79, 23);
            textBoxIsActive.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(373, 132);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 8;
            label1.Text = "Módosítás";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(557, 66);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEdit);
            Controls.Add(label1);
            Controls.Add(textBoxIsActive);
            Controls.Add(textBoxAverageGRade);
            Controls.Add(textBoxBirthDate);
            Controls.Add(textBoxName);
            Controls.Add(textBoxNeptun);
            Controls.Add(textBoxId);
            Controls.Add(buttonSave);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn neptunDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn averageGradeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private BindingSource studentBindingSource;
        private Button buttonSave;
        private TextBox textBoxId;
        private TextBox textBoxNeptun;
        private TextBox textBoxName;
        private TextBox textBoxBirthDate;
        private TextBox textBoxAverageGRade;
        private TextBox textBoxIsActive;
        private Label label1;
        private Button buttonEdit;
    }
}