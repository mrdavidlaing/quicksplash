<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.toolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.FetchButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.URLDropDown = New System.Windows.Forms.ComboBox
        Me.UrlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DesignTimeDataSet11 = New VB_ProgressBarAndStatusLabel.DataSet1
        Me.statusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UrlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignTimeDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'webBrowser1
        '
        Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser1.Location = New System.Drawing.Point(0, 64)
        Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(766, 483)
        Me.webBrowser1.TabIndex = 7
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripProgressBar1})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 547)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(766, 22)
        Me.statusStrip1.TabIndex = 10
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(50, 17)
        Me.toolStripStatusLabel1.Text = "Ready..."
        '
        'toolStripProgressBar1
        '
        Me.toolStripProgressBar1.AutoSize = False
        Me.toolStripProgressBar1.Name = "toolStripProgressBar1"
        Me.toolStripProgressBar1.Size = New System.Drawing.Size(250, 16)
        Me.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.toolStripProgressBar1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FetchButton)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.URLDropDown)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 64)
        Me.Panel1.TabIndex = 12
        '
        'FetchButton
        '
        Me.FetchButton.Location = New System.Drawing.Point(559, 27)
        Me.FetchButton.Name = "FetchButton"
        Me.FetchButton.Size = New System.Drawing.Size(75, 23)
        Me.FetchButton.TabIndex = 14
        Me.FetchButton.Text = "Fetch"
        Me.FetchButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Google Map Location"
        '
        'URLDropDown
        '
        Me.URLDropDown.DataSource = Me.UrlBindingSource
        Me.URLDropDown.DisplayMember = "Title"
        Me.URLDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.URLDropDown.FormattingEnabled = True
        Me.URLDropDown.Location = New System.Drawing.Point(30, 27)
        Me.URLDropDown.Name = "URLDropDown"
        Me.URLDropDown.Size = New System.Drawing.Size(523, 21)
        Me.URLDropDown.TabIndex = 12
        Me.URLDropDown.ValueMember = "Url"
        '
        'UrlBindingSource
        '
        Me.UrlBindingSource.DataMember = "Url"
        Me.UrlBindingSource.DataSource = Me.DesignTimeDataSet11
        '
        'DesignTimeDataSet11
        '
        Me.DesignTimeDataSet11.DataSetName = "DataSet1"
        Me.DesignTimeDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 569)
        Me.Controls.Add(Me.webBrowser1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Name = "Form1"
        Me.Text = "Exciting Google Map Locations - VB"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UrlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignTimeDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents webBrowser1 As System.Windows.Forms.WebBrowser
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents toolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents FetchButton As System.Windows.Forms.Button
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents URLDropDown As System.Windows.Forms.ComboBox
    Private WithEvents UrlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DesignTimeDataSet11 As VB_ProgressBarAndStatusLabel.DataSet1

End Class
