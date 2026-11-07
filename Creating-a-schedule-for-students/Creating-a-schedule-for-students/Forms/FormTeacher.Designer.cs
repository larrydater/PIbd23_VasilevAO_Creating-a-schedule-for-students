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
        checkedListBoxTeacherPost = new CheckedListBox();
        buttonSave = new Button();
        buttonCancel = new Button();
        SuspendLayout();
        // labelName
        labelName.AutoSize = true;
        labelName.Location = new Point(12, 18);
        labelName.Name = "labelName";
        labelName.Text = "Имя";
        // textBoxName
        textBoxName.Location = new Point(170, 15);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(250, 27);

        // labelTeacherPost
        labelTeacherPost.AutoSize = true;
        labelTeacherPost.Location = new Point(12, 96);
        labelTeacherPost.Name = "labelTeacherPost";
        labelTeacherPost.Text = "Должность";
        // checkedListBoxTeacherPost
        checkedListBoxTeacherPost.CheckOnClick = true;
        checkedListBoxTeacherPost.FormattingEnabled = true;
        checkedListBoxTeacherPost.Location = new Point(170, 93);
        checkedListBoxTeacherPost.Name = "checkedListBoxTeacherPost";
        checkedListBoxTeacherPost.Size = new Size(250, 112);
        // buttonSave
        buttonSave.Location = new Point(170, 225);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(120, 32);
        buttonSave.Text = "Сохранить";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += ButtonSave_Click;
        // buttonCancel
        buttonCancel.Location = new Point(300, 225);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(120, 32);
        buttonCancel.Text = "Отмена";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // FormTeacher
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 272);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormTeacher";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Преподаватель";
        Controls.Add(labelName);
        Controls.Add(textBoxName);
        Controls.Add(labelTeacherPost);
        Controls.Add(checkedListBoxTeacherPost);
        Controls.Add(buttonSave);
        Controls.Add(buttonCancel);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelName;
    private TextBox textBoxName;
    private Label labelTeacherPost;
    private CheckedListBox checkedListBoxTeacherPost;
    private Button buttonSave;
    private Button buttonCancel;
}
