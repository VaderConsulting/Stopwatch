Public Class frmMain
    Inherits System.Windows.Forms.Form

    Dim bMainTimerRunning As Boolean = False
    Dim bTimer1Running As Boolean = False
    Dim bTimer2Running As Boolean = False
    Dim bTimer3Running As Boolean = False

    Dim datTimer1StartTime As Date
    Dim datTimer2StartTime As Date
    Dim datTimer3StartTime As Date
    Dim datMainTimerStartTime As Date


    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents btnStart1 As System.Windows.Forms.Button
    Friend WithEvents btnStart2 As System.Windows.Forms.Button
    Friend WithEvents btnStart3 As System.Windows.Forms.Button
    Friend WithEvents btnStop1 As System.Windows.Forms.Button
    Friend WithEvents btnStop2 As System.Windows.Forms.Button
    Friend WithEvents btnStop3 As System.Windows.Forms.Button
    Friend WithEvents lblTimer1 As System.Windows.Forms.Label
    Friend WithEvents lblTimer2 As System.Windows.Forms.Label
    Friend WithEvents lblTimer3 As System.Windows.Forms.Label
    Friend WithEvents btnReset2 As System.Windows.Forms.Button
    Friend WithEvents btnReset1 As System.Windows.Forms.Button
    Friend WithEvents lblTimerMain As System.Windows.Forms.Label
    Friend WithEvents btnStopMain As System.Windows.Forms.Button
    Friend WithEvents btnStartMain As System.Windows.Forms.Button
    Friend WithEvents btnResetMain As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnReset3 As System.Windows.Forms.Button
    Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.tmrMain = New System.Windows.Forms.Timer
        Me.btnStart1 = New System.Windows.Forms.Button
        Me.btnStart2 = New System.Windows.Forms.Button
        Me.btnStart3 = New System.Windows.Forms.Button
        Me.btnStop1 = New System.Windows.Forms.Button
        Me.btnStop2 = New System.Windows.Forms.Button
        Me.btnStop3 = New System.Windows.Forms.Button
        Me.lblTimer1 = New System.Windows.Forms.Label
        Me.lblTimer2 = New System.Windows.Forms.Label
        Me.lblTimer3 = New System.Windows.Forms.Label
        Me.btnReset3 = New System.Windows.Forms.Button
        Me.btnReset2 = New System.Windows.Forms.Button
        Me.btnReset1 = New System.Windows.Forms.Button
        Me.lblTimerMain = New System.Windows.Forms.Label
        Me.btnStopMain = New System.Windows.Forms.Button
        Me.btnStartMain = New System.Windows.Forms.Button
        Me.btnResetMain = New System.Windows.Forms.Button
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        Me.tmrMain.Interval = 1000
        '
        'btnStart1
        '
        Me.btnStart1.Location = New System.Drawing.Point(8, 24)
        Me.btnStart1.Size = New System.Drawing.Size(48, 24)
        Me.btnStart1.Text = "Start"
        '
        'btnStart2
        '
        Me.btnStart2.Location = New System.Drawing.Point(8, 56)
        Me.btnStart2.Size = New System.Drawing.Size(48, 24)
        Me.btnStart2.Text = "Start"
        '
        'btnStart3
        '
        Me.btnStart3.Location = New System.Drawing.Point(8, 88)
        Me.btnStart3.Size = New System.Drawing.Size(48, 24)
        Me.btnStart3.Text = "Start"
        '
        'btnStop1
        '
        Me.btnStop1.Location = New System.Drawing.Point(64, 24)
        Me.btnStop1.Size = New System.Drawing.Size(48, 24)
        Me.btnStop1.Text = "Stop"
        '
        'btnStop2
        '
        Me.btnStop2.Location = New System.Drawing.Point(64, 56)
        Me.btnStop2.Size = New System.Drawing.Size(48, 24)
        Me.btnStop2.Text = "Stop"
        '
        'btnStop3
        '
        Me.btnStop3.Location = New System.Drawing.Point(64, 88)
        Me.btnStop3.Size = New System.Drawing.Size(48, 24)
        Me.btnStop3.Text = "Stop"
        '
        'lblTimer1
        '
        Me.lblTimer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTimer1.Location = New System.Drawing.Point(176, 24)
        Me.lblTimer1.Size = New System.Drawing.Size(56, 24)
        Me.lblTimer1.Text = "0:00"
        Me.lblTimer1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTimer2
        '
        Me.lblTimer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTimer2.Location = New System.Drawing.Point(176, 56)
        Me.lblTimer2.Size = New System.Drawing.Size(56, 24)
        Me.lblTimer2.Text = "0:00"
        Me.lblTimer2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTimer3
        '
        Me.lblTimer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTimer3.Location = New System.Drawing.Point(176, 88)
        Me.lblTimer3.Size = New System.Drawing.Size(56, 24)
        Me.lblTimer3.Text = "0:00"
        Me.lblTimer3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnReset3
        '
        Me.btnReset3.Location = New System.Drawing.Point(120, 88)
        Me.btnReset3.Size = New System.Drawing.Size(48, 24)
        Me.btnReset3.Text = "Reset"
        '
        'btnReset2
        '
        Me.btnReset2.Location = New System.Drawing.Point(120, 56)
        Me.btnReset2.Size = New System.Drawing.Size(48, 24)
        Me.btnReset2.Text = "Reset"
        '
        'btnReset1
        '
        Me.btnReset1.Location = New System.Drawing.Point(120, 24)
        Me.btnReset1.Size = New System.Drawing.Size(48, 24)
        Me.btnReset1.Text = "Reset"
        '
        'lblTimerMain
        '
        Me.lblTimerMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTimerMain.Location = New System.Drawing.Point(8, 240)
        Me.lblTimerMain.Size = New System.Drawing.Size(232, 24)
        Me.lblTimerMain.Text = "0:00"
        Me.lblTimerMain.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnStopMain
        '
        Me.btnStopMain.Location = New System.Drawing.Point(104, 208)
        Me.btnStopMain.Size = New System.Drawing.Size(48, 24)
        Me.btnStopMain.Text = "Stop"
        '
        'btnStartMain
        '
        Me.btnStartMain.Location = New System.Drawing.Point(8, 208)
        Me.btnStartMain.Size = New System.Drawing.Size(48, 24)
        Me.btnStartMain.Text = "Start"
        '
        'btnResetMain
        '
        Me.btnResetMain.Location = New System.Drawing.Point(184, 208)
        Me.btnResetMain.Size = New System.Drawing.Size(48, 24)
        Me.btnResetMain.Text = "Reset"
        '
        'frmMain
        '
        Me.Controls.Add(Me.lblTimerMain)
        Me.Controls.Add(Me.btnStopMain)
        Me.Controls.Add(Me.btnStartMain)
        Me.Controls.Add(Me.btnResetMain)
        Me.Controls.Add(Me.btnReset1)
        Me.Controls.Add(Me.btnReset2)
        Me.Controls.Add(Me.lblTimer3)
        Me.Controls.Add(Me.lblTimer2)
        Me.Controls.Add(Me.lblTimer1)
        Me.Controls.Add(Me.btnStop3)
        Me.Controls.Add(Me.btnStop2)
        Me.Controls.Add(Me.btnStop1)
        Me.Controls.Add(Me.btnStart3)
        Me.Controls.Add(Me.btnStart2)
        Me.Controls.Add(Me.btnStart1)
        Me.Controls.Add(Me.btnReset3)
        Me.Menu = Me.MainMenu1
        Me.Text = "Stopwatch"

    End Sub

#End Region

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart1.Click
        bTimer1Running = True
        If lblTimer1.Text = "0:00" Then
            datTimer1StartTime = Now
        Else
            datTimer1StartTime = Now.Subtract(CDate(lblTimer1.Text).TimeOfDay.Duration)
        End If
    End Sub

    Private Sub btnStop1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop1.Click
        bTimer1Running = False
    End Sub

    Private Sub btnReset1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset1.Click
        bTimer1Running = False
    End Sub

    Private Sub btnStart2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart2.Click
        bTimer2Running = True
        If lblTimer2.Text = "0:00" Then
            datTimer2StartTime = Now
        End If
    End Sub

    Private Sub btnStop2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop2.Click
        bTimer2Running = False
    End Sub

    Private Sub btnReset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset2.Click
        bTimer2Running = False
        lblTimer2.Text = "0:00"
    End Sub

    Private Sub btnStart3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart3.Click
        bTimer3Running = True
        If lblTimer3.Text = "0:00" Then
            datTimer3StartTime = Now
        End If
    End Sub

    Private Sub btnStop3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop3.Click
        bTimer3Running = False
    End Sub

    Private Sub btnReset3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset3.Click
        bTimer3Running = False
        lblTimer3.Text = "0:00"
    End Sub

    Private Sub btnStartMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartMain.Click
        bMainTimerRunning = True
        If lblTimerMain.Text = "0:00" Then
            datMainTimerStartTime = Now
        End If
    End Sub

    Private Sub btnStopMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopMain.Click
        bMainTimerRunning = False
    End Sub

    Private Sub btnResetMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetMain.Click
        bMainTimerRunning = False
        lblTimerMain.Text = "0:00"
    End Sub

    Private Sub tmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick
        If bTimer1Running Then
            lblTimer1.Text = TimeDifference(datTimer1StartTime, Now)
        End If

        If bTimer2Running Then
            lblTimer2.Text = TimeDifference(datTimer2StartTime, Now)
        End If

        If bTimer3Running Then
            lblTimer3.Text = TimeDifference(datTimer3StartTime, Now)
        End If

        If bMainTimerRunning Then
            lblTimerMain.Text = TimeDifference(datMainTimerStartTime, Now)
        End If

        Me.Refresh()
    End Sub

    Function TimeDifference(ByVal timStart As Date, ByVal timLap As Date) As String

        TimeDifference = Minute(timLap.Subtract(timStart.TimeOfDay.Duration)) & ":" & Microsoft.VisualBasic.Right("00" & Second(timLap.Subtract(timStart.TimeOfDay.Duration)), 2)

    End Function

End Class
