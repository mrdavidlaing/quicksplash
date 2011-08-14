Imports System.Threading

Namespace Splashscreen
    Public Class Form1
        Inherits System.Windows.Forms.Form
        Public Sub New()
            MyBase.New()
            SplashscreenController.UpdateStatusLabel("Connecting to datasource...")
            Thread.Sleep(5000) 'Simulated connecting to a datasource
            SplashscreenController.UpdateStatusLabel("Loading UI stuff...")

            InitializeComponent()
            'Trap the idle event - this tells us when the form has finished loading
            AddHandler Application.Idle, AddressOf OnLoaded
        End Sub
        Protected Overridable Sub OnLoaded(ByVal sender As Object, ByVal args As EventArgs)
            RemoveHandler Application.Idle, AddressOf OnLoaded
            SplashscreenController.CloseSplash()
        End Sub
        Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
            Application.Exit()
        End Sub
#Region " Windows Form Designer generated code "

        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents CloseButton As System.Windows.Forms.Button
        Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents label1 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.CloseButton = New System.Windows.Forms.Button
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.label1 = New System.Windows.Forms.Label
            Me.SuspendLayout()
            '
            'CloseButton
            '
            Me.CloseButton.Location = New System.Drawing.Point(448, 472)
            Me.CloseButton.Name = "CloseButton"
            Me.CloseButton.TabIndex = 5
            Me.CloseButton.Text = "&Close"
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(24, 16)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(500, 375)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            Me.pictureBox1.TabIndex = 4
            Me.pictureBox1.TabStop = False
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(72, 408)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(424, 40)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Night arrives over Europe & Africa"
            Me.label1.UseMnemonic = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(552, 518)
            Me.Controls.Add(Me.CloseButton)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.label1)
            Me.Name = "Form1"
            Me.Text = "VB - Night Arrives over Europe"
            Me.ResumeLayout(False)

        End Sub

#End Region
    End Class
End Namespace