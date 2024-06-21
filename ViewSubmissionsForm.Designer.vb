<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        txtStopwatch = New TextBox()
        txtGitHub = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.Location = New Point(245, 341)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(231, 23)
        txtStopwatch.TabIndex = 4
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(245, 267)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(231, 23)
        txtGitHub.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(245, 198)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(231, 23)
        txtPhone.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(245, 131)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(231, 23)
        txtEmail.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(245, 64)
        txtName.Name = "txtName"
        txtName.Size = New Size(231, 23)
        txtName.TabIndex = 8
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(50, 420)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(190, 23)
        btnPrevious.TabIndex = 9
        btnPrevious.Text = "&Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(262, 420)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(214, 23)
        btnNext.TabIndex = 10
        btnNext.Text = "&Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 11
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 12
        Label2.Text = "Phone num"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(74, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 13
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(74, 341)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 15)
        Label4.TabIndex = 14
        Label4.Text = "Stopwatch Time"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(74, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 15)
        Label5.TabIndex = 15
        Label5.Text = "Github Link for Task 2"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(550, 486)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtName)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtGitHub)
        Controls.Add(txtStopwatch)
        Name = "ViewSubmissionsForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
