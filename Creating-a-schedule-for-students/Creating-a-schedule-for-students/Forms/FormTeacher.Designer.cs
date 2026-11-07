namespace Creating_a_schedule_for_students.Forms;

partial class FormTeacher
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
        labelTeacherPost = new Label();
        comboBoxTeacherPost = new ComboBox();
        buttonSave = new Button();
        buttonCancel = new Button();
        SuspendLayout();
        // labeName
        labelName.AutoSize = true;
        labelName.Location = new Point(12, 18);
        labelName.Name = "labelName";
        labelName.Text = "Имя";
        // textBoxFirstName
        textBoxName.Location = new Point(170, 15);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(250, 27);
        // labelTeacherPost
        labelTeacherPost.AutoSize = true;
        labelTeacherPost.Location = new Point(12, 96);
        labelTeacherPost.Name = "labelTeacherPost";
        labelTeacherPost.Text = "Должность";
        // comboBoxTeacherPost
        comboBoxTeacherPost.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxTeacherPost.FormattingEnabled = true;
        comboBoxTeacherPost.Location = new Point(170, 93);
        comboBoxTeacherPost.Name = "comboBoxTeacherPost";
        comboBoxTeacherPost.Size = new Size(250, 28);
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
        // FormTeacher
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 188);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormTeacher";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Преподаватель";
        Controls.Add(labelName);
        Controls.Add(textBoxName);
        Controls.Add(labelTeacherPost);
        Controls.Add(comboBoxTeacherPost);
        Controls.Add(buttonSave);
        Controls.Add(buttonCancel);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelName;
    private TextBox textBoxName;
    private Label labelTeacherPost;
    private ComboBox comboBoxTeacherPost;
    private Button buttonSave;
    private Button buttonCancel;
}
