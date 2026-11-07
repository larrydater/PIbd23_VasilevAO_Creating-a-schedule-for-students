namespace Creating_a_schedule_for_students.Forms;

partial class FormLessons
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
        dataGridViewData = new DataGridView();
        panelButtons = new Panel();
        buttonAdd = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
        panelButtons.SuspendLayout();
        SuspendLayout();
        // dataGridViewData
        dataGridViewData.AllowUserToAddRows = false;
        dataGridViewData.AllowUserToDeleteRows = false;
        dataGridViewData.AllowUserToResizeColumns = false;
        dataGridViewData.AllowUserToResizeRows = false;
        dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewData.Dock = DockStyle.Fill;
        dataGridViewData.MultiSelect = false;
        dataGridViewData.Name = "dataGridViewData";
        dataGridViewData.ReadOnly = true;
        dataGridViewData.RowHeadersVisible = false;
        dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        // panelButtons
        panelButtons.Dock = DockStyle.Right;
        panelButtons.Name = "panelButtons";
        panelButtons.Size = new Size(130, 450);
        panelButtons.Controls.Add(buttonAdd);
        // buttonAdd
        buttonAdd.Location = new Point(10, 12);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(110, 36);
        buttonAdd.Text = "Добавить";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += ButtonAdd_Click;
        // FormLessons
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(850, 450);
        Controls.Add(dataGridViewData);
        Controls.Add(panelButtons);
        Name = "FormLessons";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Занятия";
        Load += FormLessons_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
        panelButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridViewData;
    private Panel panelButtons;
    private Button buttonAdd;
}
