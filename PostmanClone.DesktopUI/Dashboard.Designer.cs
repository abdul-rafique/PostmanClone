namespace PostmanClone.DesktopUI;

partial class Dashboard
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        FormTitle = new Label();
        apiTextBox = new TextBox();
        callApiBtn = new Button();
        statusStrip = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        resultTextBoxLabel = new Label();
        apiTextBoxLabel = new Label();
        httpVerbSelectionBox = new ComboBox();
        callDataTabControl = new TabControl();
        bodyTab = new TabPage();
        bodyTextBox = new TextBox();
        resultsTab = new TabPage();
        resultTextBox = new TextBox();
        statusStrip.SuspendLayout();
        callDataTabControl.SuspendLayout();
        bodyTab.SuspendLayout();
        resultsTab.SuspendLayout();
        SuspendLayout();
        // 
        // FormTitle
        // 
        FormTitle.AutoSize = true;
        FormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormTitle.Location = new Point(40, 19);
        FormTitle.Name = "FormTitle";
        FormTitle.Size = new Size(218, 41);
        FormTitle.TabIndex = 0;
        FormTitle.Text = "Postman Clone";
        // 
        // apiTextBox
        // 
        apiTextBox.BackColor = Color.White;
        apiTextBox.BorderStyle = BorderStyle.FixedSingle;
        apiTextBox.Location = new Point(177, 94);
        apiTextBox.Name = "apiTextBox";
        apiTextBox.Size = new Size(504, 27);
        apiTextBox.TabIndex = 2;
        // 
        // callApiBtn
        // 
        callApiBtn.Location = new Point(687, 93);
        callApiBtn.Name = "callApiBtn";
        callApiBtn.Size = new Size(61, 29);
        callApiBtn.TabIndex = 3;
        callApiBtn.Text = "Go";
        callApiBtn.UseVisualStyleBackColor = true;
        callApiBtn.Click += callApiBtn_Click;
        // 
        // statusStrip
        // 
        statusStrip.ImageScalingSize = new Size(20, 20);
        statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
        statusStrip.Location = new Point(0, 533);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(806, 34);
        statusStrip.TabIndex = 5;
        statusStrip.Text = "statusStrip1";
        // 
        // systemStatus
        // 
        systemStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        systemStatus.Name = "systemStatus";
        systemStatus.Size = new Size(65, 28);
        systemStatus.Text = "Ready";
        // 
        // resultTextBoxLabel
        // 
        resultTextBoxLabel.AutoSize = true;
        resultTextBoxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        resultTextBoxLabel.Location = new Point(40, 146);
        resultTextBoxLabel.Name = "resultTextBoxLabel";
        resultTextBoxLabel.Size = new Size(0, 28);
        resultTextBoxLabel.TabIndex = 7;
        // 
        // apiTextBoxLabel
        // 
        apiTextBoxLabel.AutoSize = true;
        apiTextBoxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        apiTextBoxLabel.Location = new Point(40, 90);
        apiTextBoxLabel.Name = "apiTextBoxLabel";
        apiTextBoxLabel.Size = new Size(45, 28);
        apiTextBoxLabel.TabIndex = 1;
        apiTextBoxLabel.Text = "API:";
        // 
        // httpVerbSelectionBox
        // 
        httpVerbSelectionBox.FormattingEnabled = true;
        httpVerbSelectionBox.Items.AddRange(new object[] { "GET", "POST" });
        httpVerbSelectionBox.Location = new Point(91, 93);
        httpVerbSelectionBox.Name = "httpVerbSelectionBox";
        httpVerbSelectionBox.Size = new Size(80, 28);
        httpVerbSelectionBox.TabIndex = 8;
        // 
        // callDataTabControl
        // 
        callDataTabControl.Controls.Add(bodyTab);
        callDataTabControl.Controls.Add(resultsTab);
        callDataTabControl.Location = new Point(46, 146);
        callDataTabControl.Name = "callDataTabControl";
        callDataTabControl.SelectedIndex = 0;
        callDataTabControl.Size = new Size(702, 356);
        callDataTabControl.TabIndex = 9;
        // 
        // bodyTab
        // 
        bodyTab.Controls.Add(bodyTextBox);
        bodyTab.Location = new Point(4, 29);
        bodyTab.Name = "bodyTab";
        bodyTab.Padding = new Padding(3);
        bodyTab.Size = new Size(694, 323);
        bodyTab.TabIndex = 0;
        bodyTab.Text = "Body";
        bodyTab.UseVisualStyleBackColor = true;
        // 
        // bodyTextBox
        // 
        bodyTextBox.Dock = DockStyle.Fill;
        bodyTextBox.Location = new Point(3, 3);
        bodyTextBox.Multiline = true;
        bodyTextBox.Name = "bodyTextBox";
        bodyTextBox.ScrollBars = ScrollBars.Vertical;
        bodyTextBox.Size = new Size(688, 317);
        bodyTextBox.TabIndex = 0;
        // 
        // resultsTab
        // 
        resultsTab.Controls.Add(resultTextBox);
        resultsTab.Location = new Point(4, 29);
        resultsTab.Name = "resultsTab";
        resultsTab.Padding = new Padding(3);
        resultsTab.Size = new Size(694, 323);
        resultsTab.TabIndex = 1;
        resultsTab.Text = "Results";
        resultsTab.UseVisualStyleBackColor = true;
        // 
        // resultTextBox
        // 
        resultTextBox.Dock = DockStyle.Fill;
        resultTextBox.Location = new Point(3, 3);
        resultTextBox.Multiline = true;
        resultTextBox.Name = "resultTextBox";
        resultTextBox.ScrollBars = ScrollBars.Vertical;
        resultTextBox.Size = new Size(688, 317);
        resultTextBox.TabIndex = 0;
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(806, 567);
        Controls.Add(callDataTabControl);
        Controls.Add(httpVerbSelectionBox);
        Controls.Add(resultTextBoxLabel);
        Controls.Add(statusStrip);
        Controls.Add(callApiBtn);
        Controls.Add(apiTextBox);
        Controls.Add(apiTextBoxLabel);
        Controls.Add(FormTitle);
        Name = "Dashboard";
        Text = "Dashboard";
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        callDataTabControl.ResumeLayout(false);
        bodyTab.ResumeLayout(false);
        bodyTab.PerformLayout();
        resultsTab.ResumeLayout(false);
        resultsTab.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label FormTitle;
    private TextBox apiTextBox;
    private Button callApiBtn;
    private StatusStrip statusStrip;
    private Label resultTextBoxLabel;
    private ToolStripStatusLabel systemStatus;
    private Label apiTextBoxLabel;
    private ComboBox httpVerbSelectionBox;
    private TabControl callDataTabControl;
    private TabPage bodyTab;
    private TextBox bodyTextBox;
    private TabPage resultsTab;
    private TextBox resultTextBox;
}
