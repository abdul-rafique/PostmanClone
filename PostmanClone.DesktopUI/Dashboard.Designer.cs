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
        apiTextBoxLabel = new Label();
        apiTextBox = new TextBox();
        callApiBtn = new Button();
        statusStrip = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        resultTextBox = new TextBox();
        resultTextBoxLabel = new Label();
        statusStrip.SuspendLayout();
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
        // apiTextBox
        // 
        apiTextBox.BackColor = Color.White;
        apiTextBox.BorderStyle = BorderStyle.FixedSingle;
        apiTextBox.Location = new Point(91, 94);
        apiTextBox.Name = "apiTextBox";
        apiTextBox.Size = new Size(590, 27);
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
        // resultTextBox
        // 
        resultTextBox.BackColor = Color.White;
        resultTextBox.BorderStyle = BorderStyle.FixedSingle;
        resultTextBox.Location = new Point(40, 177);
        resultTextBox.Multiline = true;
        resultTextBox.Name = "resultTextBox";
        resultTextBox.ReadOnly = true;
        resultTextBox.ScrollBars = ScrollBars.Both;
        resultTextBox.Size = new Size(708, 336);
        resultTextBox.TabIndex = 6;
        // 
        // resultTextBoxLabel
        // 
        resultTextBoxLabel.AutoSize = true;
        resultTextBoxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        resultTextBoxLabel.Location = new Point(40, 146);
        resultTextBoxLabel.Name = "resultTextBoxLabel";
        resultTextBoxLabel.Size = new Size(76, 28);
        resultTextBoxLabel.TabIndex = 7;
        resultTextBoxLabel.Text = "Results:";
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(806, 567);
        Controls.Add(resultTextBoxLabel);
        Controls.Add(resultTextBox);
        Controls.Add(statusStrip);
        Controls.Add(callApiBtn);
        Controls.Add(apiTextBox);
        Controls.Add(apiTextBoxLabel);
        Controls.Add(FormTitle);
        Name = "Dashboard";
        Text = "Dashboard";
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label FormTitle;
    private Label apiTextBoxLabel;
    private TextBox apiTextBox;
    private Button callApiBtn;
    private StatusStrip statusStrip;
    private TextBox resultTextBox;
    private Label resultTextBoxLabel;
    private ToolStripStatusLabel systemStatus;
}
