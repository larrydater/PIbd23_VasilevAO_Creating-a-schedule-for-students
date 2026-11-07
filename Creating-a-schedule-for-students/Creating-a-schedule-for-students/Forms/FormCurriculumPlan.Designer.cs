namespace Creating_a_schedule_for_students.Forms;

partial class FormCurriculumPlan
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        labelStudentGroup = new Label();
        labelSemester = new Label();
        comboBoxStudentGroup = new ComboBox();
        numericUpDownSemester = new NumericUpDown();
        groupBoxDisciplines = new GroupBox();
        dataGridViewDisciplines = new DataGridView();
        ColumnDiscipline = new DataGridViewComboBoxColumn();
        ColumnLecturesCount = new DataGridViewTextBoxColumn();
        ColumnLabsCount = new DataGridViewTextBoxColumn();
        buttonSave = new Button();
        buttonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownSemester).BeginInit();
        groupBoxDisciplines.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewDisciplines).BeginInit();
        SuspendLayout();
        // 
        // labelStudentGroup
        // 
        labelStudentGroup.AutoSize = true;
        labelStudentGroup.Location = new Point(17, 23);
        labelStudentGroup.Name = "labelStudentGroup";
        labelStudentGroup.Size = new Size(58, 20);
        labelStudentGroup.TabIndex = 0;
        labelStudentGroup.Text = "Группа";
        // 
        // labelSemester
        // 
        labelSemester.AutoSize = true;
        labelSemester.Location = new Point(14, 75);
        labelSemester.Name = "labelSemester";
        labelSemester.Size = new Size(67, 20);
        labelSemester.TabIndex = 2;
        labelSemester.Text = "Семестр";
        // 
        // comboBoxStudentGroup
        // 
        comboBoxStudentGroup.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxStudentGroup.FormattingEnabled = true;
        comboBoxStudentGroup.Location = new Point(126, 20);
        comboBoxStudentGroup.Margin = new Padding(3, 4, 3, 4);
        comboBoxStudentGroup.Name = "comboBoxStudentGroup";
        comboBoxStudentGroup.Size = new Size(285, 28);
        comboBoxStudentGroup.TabIndex = 1;
        // 
        // numericUpDownSemester
        // 
        numericUpDownSemester.Location = new Point(126, 71);
        numericUpDownSemester.Margin = new Padding(3, 4, 3, 4);
        numericUpDownSemester.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        numericUpDownSemester.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDownSemester.Name = "numericUpDownSemester";
        numericUpDownSemester.Size = new Size(137, 27);
        numericUpDownSemester.TabIndex = 3;
        numericUpDownSemester.Value = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDownSemester.ValueChanged += numericUpDownSemester_ValueChanged;
        // 
        // groupBoxDisciplines
        // 
        groupBoxDisciplines.Controls.Add(dataGridViewDisciplines);
        groupBoxDisciplines.Location = new Point(12, 120);
        groupBoxDisciplines.Margin = new Padding(3, 4, 3, 4);
        groupBoxDisciplines.Name = "groupBoxDisciplines";
        groupBoxDisciplines.Padding = new Padding(3, 4, 3, 4);
        groupBoxDisciplines.Size = new Size(613, 307);
        groupBoxDisciplines.TabIndex = 4;
        groupBoxDisciplines.TabStop = false;
        groupBoxDisciplines.Text = "Дисциплины";
        // 
        // dataGridViewDisciplines
        // 
        dataGridViewDisciplines.AllowUserToResizeRows = false;
        dataGridViewDisciplines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewDisciplines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewDisciplines.Columns.AddRange(new DataGridViewColumn[] { ColumnDiscipline, ColumnLecturesCount, ColumnLabsCount });
        dataGridViewDisciplines.Dock = DockStyle.Fill;
        dataGridViewDisciplines.Location = new Point(3, 24);
        dataGridViewDisciplines.Margin = new Padding(3, 4, 3, 4);
        dataGridViewDisciplines.Name = "dataGridViewDisciplines";
        dataGridViewDisciplines.RowHeadersVisible = false;
        dataGridViewDisciplines.RowHeadersWidth = 51;
        dataGridViewDisciplines.Size = new Size(607, 279);
        dataGridViewDisciplines.TabIndex = 0;
        // 
        // ColumnDiscipline
        // 
        ColumnDiscipline.HeaderText = "Дисциплина";
        ColumnDiscipline.MinimumWidth = 6;
        ColumnDiscipline.Name = "ColumnDiscipline";
        // 
        // ColumnLecturesCount
        // 
        ColumnLecturesCount.HeaderText = "Лекций";
        ColumnLecturesCount.MinimumWidth = 6;
        ColumnLecturesCount.Name = "ColumnLecturesCount";
        // 
        // ColumnLabsCount
        // 
        ColumnLabsCount.HeaderText = "Лабораторных";
        ColumnLabsCount.MinimumWidth = 6;
        ColumnLabsCount.Name = "ColumnLabsCount";
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(343, 447);
        buttonSave.Margin = new Padding(3, 4, 3, 4);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(137, 43);
        buttonSave.TabIndex = 5;
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Location = new Point(489, 447);
        buttonCancel.Margin = new Padding(3, 4, 3, 4);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(137, 43);
        buttonCancel.TabIndex = 6;
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // 
        // FormCurriculumPlan
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(640, 509);
        Controls.Add(labelStudentGroup);
        Controls.Add(comboBoxStudentGroup);
        Controls.Add(labelSemester);
        Controls.Add(numericUpDownSemester);
        Controls.Add(groupBoxDisciplines);
        Controls.Add(buttonSave);
        Controls.Add(buttonCancel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormCurriculumPlan";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Учебный план";
        ((System.ComponentModel.ISupportInitialize)numericUpDownSemester).EndInit();
        groupBoxDisciplines.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewDisciplines).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelStudentGroup;
    private Label labelSemester;
    private ComboBox comboBoxStudentGroup;
    private NumericUpDown numericUpDownSemester;
    private GroupBox groupBoxDisciplines;
    private DataGridView dataGridViewDisciplines;
    private DataGridViewComboBoxColumn ColumnDiscipline;
    private DataGridViewTextBoxColumn ColumnLecturesCount;
    private DataGridViewTextBoxColumn ColumnLabsCount;
    private Button buttonSave;
    private Button buttonCancel;
}
