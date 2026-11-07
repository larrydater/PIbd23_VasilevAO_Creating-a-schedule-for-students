namespace Creating_a_schedule_for_students.Forms;

partial class FormLesson
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
        labelClassroom = new Label();
        comboBoxClassroom = new ComboBox();
        labelStudentGroup = new Label();
        comboBoxStudentGroup = new ComboBox();
        labelTeacher = new Label();
        comboBoxTeacher = new ComboBox();
        labelDiscipline = new Label();
        comboBoxDiscipline = new ComboBox();
        labelLessonType = new Label();
        comboBoxLessonType = new ComboBox();
        labelWeekDay = new Label();
        comboBoxWeekDay = new ComboBox();
        labelPairNumber = new Label();
        numericUpDownPairNumber = new NumericUpDown();
        buttonSave = new Button();
        buttonCancel = new Button();
        SuspendLayout();
        // labelClassroom
        labelClassroom.AutoSize = true;
        labelClassroom.Location = new Point(12, 18);
        labelClassroom.Name = "labelClassroom";
        labelClassroom.Text = "Аудитория";
        // comboBoxClassroom
        comboBoxClassroom.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxClassroom.FormattingEnabled = true;
        comboBoxClassroom.Location = new Point(170, 15);
        comboBoxClassroom.Name = "comboBoxClassroom";
        comboBoxClassroom.Size = new Size(250, 28);
        // labelStudentGroup
        labelStudentGroup.AutoSize = true;
        labelStudentGroup.Location = new Point(12, 58);
        labelStudentGroup.Name = "labelStudentGroup";
        labelStudentGroup.Text = "Группа";
        // comboBoxStudentGroup
        comboBoxStudentGroup.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxStudentGroup.FormattingEnabled = true;
        comboBoxStudentGroup.Location = new Point(170, 55);
        comboBoxStudentGroup.Name = "comboBoxStudentGroup";
        comboBoxStudentGroup.Size = new Size(250, 28);
        // labelTeacher
        labelTeacher.AutoSize = true;
        labelTeacher.Location = new Point(12, 98);
        labelTeacher.Name = "labelTeacher";
        labelTeacher.Text = "Преподаватель";
        // comboBoxTeacher
        comboBoxTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxTeacher.FormattingEnabled = true;
        comboBoxTeacher.Location = new Point(170, 95);
        comboBoxTeacher.Name = "comboBoxTeacher";
        comboBoxTeacher.Size = new Size(250, 28);
        // labelDiscipline
        labelDiscipline.AutoSize = true;
        labelDiscipline.Location = new Point(12, 138);
        labelDiscipline.Name = "labelDiscipline";
        labelDiscipline.Text = "Дисциплина";
        // comboBoxDiscipline
        comboBoxDiscipline.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDiscipline.FormattingEnabled = true;
        comboBoxDiscipline.Location = new Point(170, 135);
        comboBoxDiscipline.Name = "comboBoxDiscipline";
        comboBoxDiscipline.Size = new Size(250, 28);
        // labelLessonType
        labelLessonType.AutoSize = true;
        labelLessonType.Location = new Point(12, 178);
        labelLessonType.Name = "labelLessonType";
        labelLessonType.Text = "Вид занятия";
        // comboBoxLessonType
        comboBoxLessonType.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxLessonType.FormattingEnabled = true;
        comboBoxLessonType.Location = new Point(170, 175);
        comboBoxLessonType.Name = "comboBoxLessonType";
        comboBoxLessonType.Size = new Size(250, 28);
        // labelWeekDay
        labelWeekDay.AutoSize = true;
        labelWeekDay.Location = new Point(12, 218);
        labelWeekDay.Name = "labelWeekDay";
        labelWeekDay.Text = "День недели";
        // comboBoxWeekDay
        comboBoxWeekDay.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxWeekDay.FormattingEnabled = true;
        comboBoxWeekDay.Location = new Point(170, 215);
        comboBoxWeekDay.Name = "comboBoxWeekDay";
        comboBoxWeekDay.Size = new Size(250, 28);
        // labelPairNumber
        labelPairNumber.AutoSize = true;
        labelPairNumber.Location = new Point(12, 258);
        labelPairNumber.Name = "labelPairNumber";
        labelPairNumber.Text = "Номер пары";
        // numericUpDownPairNumber
        numericUpDownPairNumber.Minimum = 1M;
        numericUpDownPairNumber.Maximum = 8M;
        numericUpDownPairNumber.Value = 1M;
        numericUpDownPairNumber.Location = new Point(170, 255);
        numericUpDownPairNumber.Name = "numericUpDownPairNumber";
        numericUpDownPairNumber.Size = new Size(250, 27);
        // buttonSave
        buttonSave.Location = new Point(170, 302);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(120, 32);
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // buttonCancel
        buttonCancel.Location = new Point(300, 302);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(120, 32);
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // FormLesson
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 349);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormLesson";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Занятие";
        Controls.Add(labelClassroom);
        Controls.Add(comboBoxClassroom);
        Controls.Add(labelStudentGroup);
        Controls.Add(comboBoxStudentGroup);
        Controls.Add(labelTeacher);
        Controls.Add(comboBoxTeacher);
        Controls.Add(labelDiscipline);
        Controls.Add(comboBoxDiscipline);
        Controls.Add(labelLessonType);
        Controls.Add(comboBoxLessonType);
        Controls.Add(labelWeekDay);
        Controls.Add(comboBoxWeekDay);
        Controls.Add(labelPairNumber);
        Controls.Add(numericUpDownPairNumber);
        Controls.Add(buttonSave);
        Controls.Add(buttonCancel);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelClassroom;
    private ComboBox comboBoxClassroom;
    private Label labelStudentGroup;
    private ComboBox comboBoxStudentGroup;
    private Label labelTeacher;
    private ComboBox comboBoxTeacher;
    private Label labelDiscipline;
    private ComboBox comboBoxDiscipline;
    private Label labelLessonType;
    private ComboBox comboBoxLessonType;
    private Label labelWeekDay;
    private ComboBox comboBoxWeekDay;
    private Label labelPairNumber;
    private NumericUpDown numericUpDownPairNumber;
    private Button buttonSave;
    private Button buttonCancel;
}
