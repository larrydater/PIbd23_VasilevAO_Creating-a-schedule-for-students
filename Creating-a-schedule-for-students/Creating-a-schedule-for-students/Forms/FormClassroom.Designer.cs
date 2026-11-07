namespace Creating_a_schedule_for_students.Forms;

partial class FormClassroom
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
        labelNumber = new Label();
        textBoxNumber = new TextBox();
        labelCapacity = new Label();
        numericUpDownCapacity = new NumericUpDown();
        labelClassroomType = new Label();
        comboBoxClassroomType = new ComboBox();
        buttonSave = new Button();
        buttonCancel = new Button();
        SuspendLayout();
        // labelNumber
        labelNumber.AutoSize = true;
        labelNumber.Location = new Point(12, 18);
        labelNumber.Name = "labelNumber";
        labelNumber.Text = "Номер аудитории";
        // textBoxNumber
        textBoxNumber.Location = new Point(170, 15);
        textBoxNumber.Name = "textBoxNumber";
        textBoxNumber.Size = new Size(250, 27);
        // labelCapacity
        labelCapacity.AutoSize = true;
        labelCapacity.Location = new Point(12, 57);
        labelCapacity.Name = "labelCapacity";
        labelCapacity.Text = "Вместимость";
        // numericUpDownCapacity
        numericUpDownCapacity.Minimum = 1M;
        numericUpDownCapacity.Maximum = 1000M;
        numericUpDownCapacity.Value = 1M;
        numericUpDownCapacity.Location = new Point(170, 54);
        numericUpDownCapacity.Name = "numericUpDownCapacity";
        numericUpDownCapacity.Size = new Size(250, 27);
        // labelClassroomType
        labelClassroomType.AutoSize = true;
        labelClassroomType.Location = new Point(12, 96);
        labelClassroomType.Name = "labelClassroomType";
        labelClassroomType.Text = "Тип аудитории";
        // comboBoxClassroomType
        comboBoxClassroomType.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxClassroomType.FormattingEnabled = true;
        comboBoxClassroomType.Location = new Point(170, 93);
        comboBoxClassroomType.Name = "comboBoxClassroomType";
        comboBoxClassroomType.Size = new Size(250, 28);
        // buttonSave
        buttonSave.Location = new Point(170, 141);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(120, 32);
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // buttonCancel
        buttonCancel.Location = new Point(300, 141);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(120, 32);
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // FormClassroom
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 188);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormClassroom";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Аудитория";
        Controls.Add(labelNumber);
        Controls.Add(textBoxNumber);
        Controls.Add(labelCapacity);
        Controls.Add(numericUpDownCapacity);
        Controls.Add(labelClassroomType);
        Controls.Add(comboBoxClassroomType);
        Controls.Add(buttonSave);
        Controls.Add(buttonCancel);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelNumber;
    private TextBox textBoxNumber;
    private Label labelCapacity;
    private NumericUpDown numericUpDownCapacity;
    private Label labelClassroomType;
    private ComboBox comboBoxClassroomType;
    private Button buttonSave;
    private Button buttonCancel;
}
