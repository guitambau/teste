<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Controle_mascara
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Controle_mascara))
        Me.LST_RETIRADA = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cracha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP_DATA_INICO = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_registro = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cbo_semana = New System.Windows.Forms.ComboBox()
        Me.BTN_EXCEL = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LST_RETIRADA
        '
        Me.LST_RETIRADA.AllowColumnReorder = True
        Me.LST_RETIRADA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_RETIRADA.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_RETIRADA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LST_RETIRADA.FullRowSelect = True
        Me.LST_RETIRADA.GridLines = True
        Me.LST_RETIRADA.Location = New System.Drawing.Point(27, 204)
        Me.LST_RETIRADA.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.LST_RETIRADA.MultiSelect = False
        Me.LST_RETIRADA.Name = "LST_RETIRADA"
        Me.LST_RETIRADA.Size = New System.Drawing.Size(833, 312)
        Me.LST_RETIRADA.TabIndex = 12
        Me.LST_RETIRADA.UseCompatibleStateImageBehavior = False
        Me.LST_RETIRADA.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Crachá"
        '
        'txt_cracha
        '
        Me.txt_cracha.Location = New System.Drawing.Point(27, 122)
        Me.txt_cracha.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_cracha.Name = "txt_cracha"
        Me.txt_cracha.ShortcutsEnabled = False
        Me.txt_cracha.Size = New System.Drawing.Size(371, 32)
        Me.txt_cracha.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(618, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Semana"
        '
        'DTP_DATA_INICO
        '
        Me.DTP_DATA_INICO.Font = New System.Drawing.Font("Malgun Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DATA_INICO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_DATA_INICO.Location = New System.Drawing.Point(214, 77)
        Me.DTP_DATA_INICO.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DTP_DATA_INICO.Name = "DTP_DATA_INICO"
        Me.DTP_DATA_INICO.Size = New System.Drawing.Size(135, 32)
        Me.DTP_DATA_INICO.TabIndex = 175
        Me.DTP_DATA_INICO.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Malgun Gothic", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(471, 51)
        Me.Label6.TabIndex = 176
        Me.Label6.Text = "RETIRADA DE MASCARA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(442, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "Registro"
        '
        'txt_registro
        '
        Me.txt_registro.Location = New System.Drawing.Point(447, 122)
        Me.txt_registro.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt_registro.Name = "txt_registro"
        Me.txt_registro.ShortcutsEnabled = False
        Me.txt_registro.Size = New System.Drawing.Size(127, 32)
        Me.txt_registro.TabIndex = 178
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(646, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(214, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 179
        Me.PictureBox2.TabStop = False
        '
        'cbo_semana
        '
        Me.cbo_semana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_semana.FormattingEnabled = True
        Me.cbo_semana.Location = New System.Drawing.Point(623, 122)
        Me.cbo_semana.Name = "cbo_semana"
        Me.cbo_semana.Size = New System.Drawing.Size(121, 33)
        Me.cbo_semana.TabIndex = 180
        '
        'BTN_EXCEL
        '
        Me.BTN_EXCEL.ForeColor = System.Drawing.Color.Black
        Me.BTN_EXCEL.Image = CType(resources.GetObject("BTN_EXCEL.Image"), System.Drawing.Image)
        Me.BTN_EXCEL.Location = New System.Drawing.Point(782, 122)
        Me.BTN_EXCEL.Name = "BTN_EXCEL"
        Me.BTN_EXCEL.Size = New System.Drawing.Size(47, 33)
        Me.BTN_EXCEL.TabIndex = 181
        Me.BTN_EXCEL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTN_EXCEL.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 173)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 25)
        Me.Label4.TabIndex = 182
        Me.Label4.Text = "Lista Retirada de Mascara"
        '
        'Controle_mascara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(887, 532)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTN_EXCEL)
        Me.Controls.Add(Me.cbo_semana)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txt_registro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DTP_DATA_INICO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cracha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LST_RETIRADA)
        Me.Font = New System.Drawing.Font("Malgun Gothic Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Controle_mascara"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Mascara"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LST_RETIRADA As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cracha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DTP_DATA_INICO As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_registro As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cbo_semana As ComboBox
    Friend WithEvents BTN_EXCEL As Button
    Friend WithEvents Label4 As Label
End Class
