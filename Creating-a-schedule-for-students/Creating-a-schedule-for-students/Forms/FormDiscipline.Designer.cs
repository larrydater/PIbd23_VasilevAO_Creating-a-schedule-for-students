namespace Creating_a_schedule_for_students.Forms;

partial class FormDiscipline
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
        labelLessonTypes = new Label();
        checkedListBoxLessonTypes = new CheckedListBox();
        buttonSave = new Button();
        buttonCancel = new Button();
        SuspendLayout();
        // labelName
        labelName.AutoSize = true;
        labelName.Location = new Point(12, 18);
        labelName.Name = "labelName";
        labelName.Text = "Название дисциплины";
        // textBoxName
        textBoxName.Location = new Point(170, 15);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(250, 27);
        // labelLessonTypes
        labelLessonTypes.AutoSize = true;
        labelLessonTypes.Location = new Point(12, 57);
        labelLessonTypes.Name = "labelLessonTypes";
        labelLessonTypes.Text = "Виды занятий";
        // checkedListBoxLessonTypes
        checkedListBoxLessonTypes.CheckOnClick = true;
        checkedListBoxLessonTypes.FormattingEnabled = true;
        checkedListBoxLessonTypes.Location = new Point(170, 54);
        checkedListBoxLessonTypes.Name = "checkedListBoxLessonTypes";
        checkedListBoxLessonTypes.Size = new Size(250, 70);
        // buttonSave
        buttonSave.Location = new Point(170, 144);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(120, 32);
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // buttonCancel
        buttonCancel.Location = new Point(300, 144);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(120, 32);
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // FormDiscipline
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 191);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormDiscipline";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Дисциплина";
        Controls.Add(labelName);
        Controls.Add(textBoxName);
        Controls.Add(labelLessonTypes);
        Controls.Add(checkedListBoxLessonTypes);
        Controls.Add(buttonSave);
        Controls.Add(buttonCancel);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelName;
    private TextBox textBoxName;
    private Label labelLessonTypes;
    private CheckedListBox checkedListBoxLessonTypes;
    private Button buttonSave;
    private Button buttonCancel;
}
