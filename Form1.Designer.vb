﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.TextAge = New System.Windows.Forms.TextBox()
        Me.TextAddress = New System.Windows.Forms.TextBox()
        Me.SaveTxt = New System.Windows.Forms.Button()
        Me.SaveXml = New System.Windows.Forms.Button()
        Me.SaveJson = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address:"
        '
        'TextName
        '
        Me.TextName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.Location = New System.Drawing.Point(103, 29)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(318, 26)
        Me.TextName.TabIndex = 3
        '
        'TextAge
        '
        Me.TextAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAge.Location = New System.Drawing.Point(103, 66)
        Me.TextAge.Name = "TextAge"
        Me.TextAge.Size = New System.Drawing.Size(66, 26)
        Me.TextAge.TabIndex = 4
        '
        'TextAddress
        '
        Me.TextAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAddress.Location = New System.Drawing.Point(103, 102)
        Me.TextAddress.Name = "TextAddress"
        Me.TextAddress.Size = New System.Drawing.Size(464, 26)
        Me.TextAddress.TabIndex = 5
        '
        'SaveTxt
        '
        Me.SaveTxt.BackColor = System.Drawing.Color.PaleGreen
        Me.SaveTxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveTxt.FlatAppearance.BorderSize = 0
        Me.SaveTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveTxt.Location = New System.Drawing.Point(451, 151)
        Me.SaveTxt.Name = "SaveTxt"
        Me.SaveTxt.Size = New System.Drawing.Size(116, 23)
        Me.SaveTxt.TabIndex = 6
        Me.SaveTxt.Text = "Save as TXT"
        Me.SaveTxt.UseVisualStyleBackColor = False
        '
        'SaveXml
        '
        Me.SaveXml.BackColor = System.Drawing.Color.Aqua
        Me.SaveXml.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveXml.FlatAppearance.BorderSize = 0
        Me.SaveXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveXml.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveXml.Location = New System.Drawing.Point(451, 180)
        Me.SaveXml.Name = "SaveXml"
        Me.SaveXml.Size = New System.Drawing.Size(116, 23)
        Me.SaveXml.TabIndex = 7
        Me.SaveXml.Text = "Save as XML"
        Me.SaveXml.UseVisualStyleBackColor = False
        '
        'SaveJson
        '
        Me.SaveJson.BackColor = System.Drawing.Color.MediumOrchid
        Me.SaveJson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SaveJson.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveJson.FlatAppearance.BorderSize = 0
        Me.SaveJson.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveJson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveJson.Location = New System.Drawing.Point(451, 209)
        Me.SaveJson.Name = "SaveJson"
        Me.SaveJson.Size = New System.Drawing.Size(116, 23)
        Me.SaveJson.TabIndex = 8
        Me.SaveJson.Text = "Save as JSON"
        Me.SaveJson.UseVisualStyleBackColor = False
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.Color.Red
        Me.Status.Location = New System.Drawing.Point(17, 212)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(212, 20)
        Me.Status.TabIndex = 9
        Me.Status.Text = "SAMPLE SAMPLE SAMPLE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 254)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.SaveJson)
        Me.Controls.Add(Me.SaveXml)
        Me.Controls.Add(Me.SaveTxt)
        Me.Controls.Add(Me.TextAddress)
        Me.Controls.Add(Me.TextAge)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextName As TextBox
    Friend WithEvents TextAge As TextBox
    Friend WithEvents TextAddress As TextBox
    Friend WithEvents SaveTxt As Button
    Friend WithEvents SaveXml As Button
    Friend WithEvents SaveJson As Button
    Friend WithEvents Status As Label
End Class
