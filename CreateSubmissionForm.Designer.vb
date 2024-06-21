<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnSubmit = New Button()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        txtStopwatch = New TextBox()
        btnStopwatch = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(60, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 15)
        Label5.TabIndex = 27
        Label5.Text = "Github Link for Task 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 25
        Label3.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 24
        Label2.Text = "Phone num"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 23
        Label1.Text = "Name"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(118, 439)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(214, 23)
        btnSubmit.TabIndex = 22
        btnSubmit.Text = "&Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(231, 78)
        txtName.Name = "txtName"
        txtName.Size = New Size(231, 23)
        txtName.TabIndex = 20
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(231, 145)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(231, 23)
        txtEmail.TabIndex = 19
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(231, 212)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(231, 23)
        txtPhone.TabIndex = 18
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(231, 281)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(231, 23)
        txtGitHub.TabIndex = 17
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(231, 355)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(231, 23)
        txtStopwatch.TabIndex = 16
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.Location = New Point(38, 354)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(155, 23)
        btnStopwatch.TabIndex = 28
        btnStopwatch.Text = "Start/Pause Stopwatch"
        btnStopwatch.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 496)
        Controls.Add(btnStopwatch)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(txtName)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtGitHub)
        Controls.Add(txtStopwatch)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents Timer1 As Timer
End Class
