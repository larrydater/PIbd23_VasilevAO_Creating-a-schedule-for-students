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
        // labelStudentGroup
        labelStudentGroup.AutoSize = true;
        labelStudentGroup.Location = new Point(12, 18);
        labelStudentGroup.Name = "labelStudentGroup";
        labelStudentGroup.Text = "Группа";
        // comboBoxStudentGroup
        comboBoxStudentGroup.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxStudentGroup.FormattingEnabled = true;
        comboBoxStudentGroup.Location = new Point(110, 15);
        comboBoxStudentGroup.Name = "comboBoxStudentGroup";
        comboBoxStudentGroup.Size = new Size(250, 28);
        // labelSemester
        labelSemester.AutoSize = true;
        labelSemester.Location = new Point(12, 56);
        labelSemester.Name = "labelSemester";
        labelSemester.Text = "Семестр";
        // numericUpDownSemester
        numericUpDownSemester.Location = new Point(110, 53);
        numericUpDownSemester.Maximum = 12M;
        numericUpDownSemester.Minimum = 1M;
        numericUpDownSemester.Name = "numericUpDownSemester";
        numericUpDownSemester.Size = new Size(120, 27);
        numericUpDownSemester.Value = 1M;
        // groupBoxDisciplines
        groupBoxDisciplines.Controls.Add(dataGridViewDisciplines);
        groupBoxDisciplines.Location = new Point(12, 92);
        groupBoxDisciplines.Name = "groupBoxDisciplines";
        groupBoxDisciplines.Size = new Size(536, 230);
        groupBoxDisciplines.Text = "Дисциплины";
        // dataGridViewDisciplines
        dataGridViewDisciplines.AllowUserToResizeRows = false;
        dataGridViewDisciplines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewDisciplines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewDisciplines.Columns.AddRange(new DataGridViewColumn[] { ColumnDiscipline, ColumnLecturesCount, ColumnLabsCount });
        dataGridViewDisciplines.Dock = DockStyle.Fill;
        dataGridViewDisciplines.Name = "dataGridViewDisciplines";
        dataGridViewDisciplines.RowHeadersVisible = false;
        // ColumnDiscipline
        ColumnDiscipline.HeaderText = "Дисциплина";
        ColumnDiscipline.Name = "ColumnDiscipline";
        // ColumnLecturesCount
        ColumnLecturesCount.HeaderText = "Лекций";
        ColumnLecturesCount.Name = "ColumnLecturesCount";
        // ColumnLabsCount
        ColumnLabsCount.HeaderText = "Лабораторных";
        ColumnLabsCount.Name = "ColumnLabsCount";
        // buttonSave
        buttonSave.Location = new Point(300, 335);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(120, 32);
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // buttonCancel
        buttonCancel.Location = new Point(428, 335);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(120, 32);
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // FormCurriculumPlan
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(560, 382);
        Controls.Add(labelStudentGroup);
        Controls.Add(comboBoxStudentGroup);
        Controls.Add(labelSemester);
        Controls.Add(numericUpDownSemester);
        Controls.Add(groupBoxDisciplines);
        Controls.Add(buttonSave);
        Controls.Add(buttonCancel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
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
