Imports System.Threading

Public Class Form1

    Public Sub New()
        InitializeComponent()
        AddHandler Application.Idle, AddressOf OnLoaded
        'Update the splashscreen to tell the user we are loading data
        Splashscreen.SplashscreenController.UpdateStatusLabel("Loading data...")
        Thread.Sleep(5000) 'Simulate loading data from an external DB / Webservice
    End Sub

    Protected Overridable Sub OnLoaded(ByVal sender As Object, ByVal args As EventArgs)
        RemoveHandler Application.Idle, AddressOf OnLoaded
        'Close the Splashscreen
        Splashscreen.SplashscreenController.CloseSplash()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As DataSet1 = New DataSet1
        ds.ReadXml(Application.StartupPath + "\GoogleLocations.DataSet1.xml")
        UrlBindingSource.DataSource = ds
        URLDropDown.SelectedIndex = 0
    End Sub

    Private Sub FetchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FetchButton.Click
        toolStripStatusLabel1.Text = "Fetching Google Map..."
        toolStripStatusLabel1.Visible = True
        toolStripProgressBar1.Visible = True
        webBrowser1.Url = New Uri(URLDropDown.SelectedValue.ToString)
    End Sub

    Private Sub webBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webBrowser1.DocumentCompleted
        toolStripStatusLabel1.Visible = False
        toolStripProgressBar1.Visible = False
    End Sub
End Class
