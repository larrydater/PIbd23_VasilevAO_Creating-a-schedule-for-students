namespace Creating_a_schedule_for_students.Forms;

partial class FormStudentGroup
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
        labelName = new Label();
        textBoxName = new TextBox();
        labelCourse = new Label();
        numericUpDownCourse = new NumericUpDown();
        labelStudentsCount = new Label();
        numericUpDownStudentsCount = new NumericUpDown();
        buttonSave = new Button();
        buttonCancel = new Button();
        SuspendLayout();
        // labelName
        labelName.AutoSize = true;
        labelName.Location = new Point(12, 18);
        labelName.Name = "labelName";
        labelName.Text = "Название группы";
        // textBoxName
        textBoxName.Location = new Point(170, 15);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(250, 27);
        // labelCourse
        labelCourse.AutoSize = true;
        labelCourse.Location = new Point(12, 57);
        labelCourse.Name = "labelCourse";
        labelCourse.Text = "Курс";
        // numericUpDownCourse
        numericUpDownCourse.Minimum = 1M;
        numericUpDownCourse.Maximum = 6M;
        numericUpDownCourse.Value = 1M;
        numericUpDownCourse.Location = new Point(170, 54);
        numericUpDownCourse.Name = "numericUpDownCourse";
        numericUpDownCourse.Size = new Size(250, 27);
        // labelStudentsCount
        labelStudentsCount.AutoSize = true;
        labelStudentsCount.Location = new Point(12, 96);
        labelStudentsCount.Name = "labelStudentsCount";
        labelStudentsCount.Text = "Количество студентов";
        // numericUpDownStudentsCount
        numericUpDownStudentsCount.Minimum = 1M;
        numericUpDownStudentsCount.Maximum = 100M;
        numericUpDownStudentsCount.Value = 1M;
        numericUpDownStudentsCount.Location = new Point(170, 93);
        numericUpDownStudentsCount.Name = "numericUpDownStudentsCount";
        numericUpDownStudentsCount.Size = new Size(250, 27);
        // buttonSave
        buttonSave.Location = new Point(170, 140);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(120, 32);
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // buttonCancel
        buttonCancel.Location = new Point(300, 140);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(120, 32);
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // FormStudentGroup
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 187);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormStudentGroup";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Группа";
        Controls.Add(labelName);
        Controls.Add(textBoxName);
        Controls.Add(labelCourse);
        Controls.Add(numericUpDownCourse);
        Controls.Add(labelStudentsCount);
        Controls.Add(numericUpDownStudentsCount);
        Controls.Add(buttonSave);
        Controls.Add(buttonCancel);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelName;
    private TextBox textBoxName;
    private Label labelCourse;
    private NumericUpDown numericUpDownCourse;
    private Label labelStudentsCount;
    private NumericUpDown numericUpDownStudentsCount;
    private Button buttonSave;
    private Button buttonCancel;
}
