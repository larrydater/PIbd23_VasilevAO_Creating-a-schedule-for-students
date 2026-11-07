namespace Creating_a_schedule_for_students.Forms;

partial class FormSchedule
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
        menuStrip = new MenuStrip();
        directoriesToolStripMenuItem = new ToolStripMenuItem();
        classroomsToolStripMenuItem = new ToolStripMenuItem();
        studentGroupsToolStripMenuItem = new ToolStripMenuItem();
        teachersToolStripMenuItem = new ToolStripMenuItem();
        disciplinesToolStripMenuItem = new ToolStripMenuItem();
        operationsToolStripMenuItem = new ToolStripMenuItem();
        lessonsToolStripMenuItem = new ToolStripMenuItem();
        curriculumPlansToolStripMenuItem = new ToolStripMenuItem();
        reportsToolStripMenuItem = new ToolStripMenuItem();
        menuStrip.SuspendLayout();
        SuspendLayout();
        // menuStrip
        menuStrip.Items.AddRange(new ToolStripItem[] { directoriesToolStripMenuItem, operationsToolStripMenuItem, reportsToolStripMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(800, 24);
        // directoriesToolStripMenuItem
        directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
        directoriesToolStripMenuItem.Text = "Справочники";
        directoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { classroomsToolStripMenuItem, studentGroupsToolStripMenuItem, teachersToolStripMenuItem, disciplinesToolStripMenuItem });
        // classroomsToolStripMenuItem
        classroomsToolStripMenuItem.Name = "classroomsToolStripMenuItem";
        classroomsToolStripMenuItem.Text = "Аудитории";
        classroomsToolStripMenuItem.Click += ClassroomsToolStripMenuItem_Click;
        // studentGroupsToolStripMenuItem
        studentGroupsToolStripMenuItem.Name = "studentGroupsToolStripMenuItem";
        studentGroupsToolStripMenuItem.Text = "Группы";
        studentGroupsToolStripMenuItem.Click += StudentGroupsToolStripMenuItem_Click;
        // teachersToolStripMenuItem
        teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
        teachersToolStripMenuItem.Text = "Преподаватели";
        teachersToolStripMenuItem.Click += TeachersToolStripMenuItem_Click;
        // disciplinesToolStripMenuItem
        disciplinesToolStripMenuItem.Name = "disciplinesToolStripMenuItem";
        disciplinesToolStripMenuItem.Text = "Дисциплины";
        disciplinesToolStripMenuItem.Click += DisciplinesToolStripMenuItem_Click;
        // operationsToolStripMenuItem
        operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
        operationsToolStripMenuItem.Text = "Операции";
        operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lessonsToolStripMenuItem, curriculumPlansToolStripMenuItem });
        // lessonsToolStripMenuItem
        lessonsToolStripMenuItem.Name = "lessonsToolStripMenuItem";
        lessonsToolStripMenuItem.Text = "Занятия";
        lessonsToolStripMenuItem.Click += LessonsToolStripMenuItem_Click;
        // curriculumPlansToolStripMenuItem
        curriculumPlansToolStripMenuItem.Name = "curriculumPlansToolStripMenuItem";
        curriculumPlansToolStripMenuItem.Text = "Учебные планы";
        curriculumPlansToolStripMenuItem.Click += CurriculumPlansToolStripMenuItem_Click;
        // reportsToolStripMenuItem
        reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
        reportsToolStripMenuItem.Text = "Отчеты";
        // FormSchedule
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        Name = "FormSchedule";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Расписание факультета";
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip;
    private ToolStripMenuItem directoriesToolStripMenuItem;
    private ToolStripMenuItem classroomsToolStripMenuItem;
    private ToolStripMenuItem studentGroupsToolStripMenuItem;
    private ToolStripMenuItem teachersToolStripMenuItem;
    private ToolStripMenuItem disciplinesToolStripMenuItem;
    private ToolStripMenuItem operationsToolStripMenuItem;
    private ToolStripMenuItem lessonsToolStripMenuItem;
    private ToolStripMenuItem curriculumPlansToolStripMenuItem;
    private ToolStripMenuItem reportsToolStripMenuItem;
}
