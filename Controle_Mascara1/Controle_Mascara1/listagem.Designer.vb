<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listagem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listagem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_semana = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_registro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP_DATA_INICO = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cracha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LST_RETIRADA = New System.Windows.Forms.ListView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-72, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Crachá"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 174)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 25)
        Me.Label4.TabIndex = 196
        Me.Label4.Text = "Lista Retirada de Mascara"
        '
        'cbo_semana
        '
        Me.cbo_semana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_semana.FormattingEnabled = True
        Me.cbo_semana.Location = New System.Drawing.Point(423, 123)
        Me.cbo_semana.Name = "cbo_semana"
        Me.cbo_semana.Size = New System.Drawing.Size(121, 21)
        Me.cbo_semana.TabIndex = 194
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(638, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(214, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 193
        Me.PictureBox2.TabStop = False
        '
        'txt_registro
        '
        Me.txt_registro.Location = New System.Drawing.Point(423, 59)
        Me.txt_registro.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_registro.Name = "txt_registro"
        Me.txt_registro.ShortcutsEnabled = False
        Me.txt_registro.Size = New System.Drawing.Size(127, 20)
        Me.txt_registro.TabIndex = 192
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(418, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Registro"
        '
        'DTP_DATA_INICO
        '
        Me.DTP_DATA_INICO.Font = New System.Drawing.Font("Malgun Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DATA_INICO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_DATA_INICO.Location = New System.Drawing.Point(260, 161)
        Me.DTP_DATA_INICO.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DTP_DATA_INICO.Name = "DTP_DATA_INICO"
        Me.DTP_DATA_INICO.Size = New System.Drawing.Size(135, 32)
        Me.DTP_DATA_INICO.TabIndex = 189
        Me.DTP_DATA_INICO.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(418, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 188
        Me.Label3.Text = "Semana"
        '
        'txt_cracha
        '
        Me.txt_cracha.Location = New System.Drawing.Point(19, 123)
        Me.txt_cracha.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_cracha.Name = "txt_cracha"
        Me.txt_cracha.ShortcutsEnabled = False
        Me.txt_cracha.Size = New System.Drawing.Size(371, 20)
        Me.txt_cracha.TabIndex = 187
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Malgun Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(14, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 25)
        Me.Label5.TabIndex = 186
        Me.Label5.Text = "Crachá"
        '
        'LST_RETIRADA
        '
        Me.LST_RETIRADA.AllowColumnReorder = True
        Me.LST_RETIRADA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_RETIRADA.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_RETIRADA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LST_RETIRADA.FullRowSelect = True
        Me.LST_RETIRADA.GridLines = True
        Me.LST_RETIRADA.Location = New System.Drawing.Point(19, 205)
        Me.LST_RETIRADA.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.LST_RETIRADA.MultiSelect = False
        Me.LST_RETIRADA.Name = "LST_RETIRADA"
        Me.LST_RETIRADA.Size = New System.Drawing.Size(833, 312)
        Me.LST_RETIRADA.TabIndex = 185
        Me.LST_RETIRADA.UseCompatibleStateImageBehavior = False
        Me.LST_RETIRADA.View = System.Windows.Forms.View.Details
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(371, 20)
        Me.TextBox1.TabIndex = 197
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Malgun Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 30)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 25)
        Me.Label6.TabIndex = 198
        Me.Label6.Text = "Nome"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(616, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 199
        Me.Button1.Text = "Busca"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(777, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 200
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'listagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(867, 532)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbo_semana)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txt_registro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTP_DATA_INICO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cracha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LST_RETIRADA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "listagem"
        Me.Text = "listagem"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_semana As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_registro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DTP_DATA_INICO As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cracha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LST_RETIRADA As ListView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
