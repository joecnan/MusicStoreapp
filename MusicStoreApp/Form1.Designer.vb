<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.lblautor = New System.Windows.Forms.Label()
        Me.lblaño = New System.Windows.Forms.Label()
        Me.pbximagen1 = New System.Windows.Forms.PictureBox()
        Me.pbxcentral = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btncomprar1 = New System.Windows.Forms.Button()
        Me.lblprecio = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblalbum = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pbximagen2 = New System.Windows.Forms.PictureBox()
        Me.btncomprar2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncomprar4 = New System.Windows.Forms.Button()
        Me.pbximagen4 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncomprar3 = New System.Windows.Forms.Button()
        Me.pbximagen3 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btncomprar6 = New System.Windows.Forms.Button()
        Me.pbximagen6 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btncomprar5 = New System.Windows.Forms.Button()
        Me.pbximagen5 = New System.Windows.Forms.PictureBox()
        CType(Me.pbximagen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxcentral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbximagen2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbximagen4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbximagen3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbximagen6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbximagen5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(463, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 42)
        Me.btncerrar.TabIndex = 0
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.White
        Me.lbltitulo.Location = New System.Drawing.Point(226, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(121, 24)
        Me.lbltitulo.TabIndex = 2
        Me.lbltitulo.Text = "Titulo de la cancion"
        '
        'lblautor
        '
        Me.lblautor.AutoSize = True
        Me.lblautor.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblautor.ForeColor = System.Drawing.Color.Transparent
        Me.lblautor.Location = New System.Drawing.Point(226, 55)
        Me.lblautor.Name = "lblautor"
        Me.lblautor.Size = New System.Drawing.Size(33, 20)
        Me.lblautor.TabIndex = 3
        Me.lblautor.Text = "Autor"
        '
        'lblaño
        '
        Me.lblaño.AutoSize = True
        Me.lblaño.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaño.ForeColor = System.Drawing.Color.Silver
        Me.lblaño.Location = New System.Drawing.Point(226, 75)
        Me.lblaño.Name = "lblaño"
        Me.lblaño.Size = New System.Drawing.Size(27, 17)
        Me.lblaño.TabIndex = 4
        Me.lblaño.Text = "Año"
        '
        'pbximagen1
        '
        Me.pbximagen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbximagen1.Image = CType(resources.GetObject("pbximagen1.Image"), System.Drawing.Image)
        Me.pbximagen1.Location = New System.Drawing.Point(12, 204)
        Me.pbximagen1.Name = "pbximagen1"
        Me.pbximagen1.Size = New System.Drawing.Size(120, 68)
        Me.pbximagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbximagen1.TabIndex = 5
        Me.pbximagen1.TabStop = False
        '
        'pbxcentral
        '
        Me.pbxcentral.BackColor = System.Drawing.Color.Gray
        Me.pbxcentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxcentral.Location = New System.Drawing.Point(18, 9)
        Me.pbxcentral.Name = "pbxcentral"
        Me.pbxcentral.Size = New System.Drawing.Size(197, 172)
        Me.pbxcentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxcentral.TabIndex = 6
        Me.pbxcentral.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(192, 470)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Importe:"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Transparent
        Me.lbltotal.Location = New System.Drawing.Point(236, 470)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(53, 20)
        Me.lbltotal.TabIndex = 33
        Me.lbltotal.Text = "S/. 0.00"
        '
        'btncomprar1
        '
        Me.btncomprar1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncomprar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncomprar1.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomprar1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btncomprar1.Location = New System.Drawing.Point(142, 244)
        Me.btncomprar1.Name = "btncomprar1"
        Me.btncomprar1.Size = New System.Drawing.Size(88, 26)
        Me.btncomprar1.TabIndex = 34
        Me.btncomprar1.Text = "COMPRAR"
        Me.btncomprar1.UseVisualStyleBackColor = True
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecio.ForeColor = System.Drawing.Color.Silver
        Me.lblprecio.Location = New System.Drawing.Point(226, 92)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(44, 15)
        Me.lblprecio.TabIndex = 35
        Me.lblprecio.Text = "S/. 0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(138, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Hasta que te conocí"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(139, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 17)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Juan Gabriel"
        '
        'lblalbum
        '
        Me.lblalbum.AutoSize = True
        Me.lblalbum.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalbum.ForeColor = System.Drawing.Color.White
        Me.lblalbum.Location = New System.Drawing.Point(226, 33)
        Me.lblalbum.Name = "lblalbum"
        Me.lblalbum.Size = New System.Drawing.Size(89, 20)
        Me.lblalbum.TabIndex = 40
        Me.lblalbum.Text = "Titulo del Album"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(227, 123)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(245, 46)
        Me.AxWindowsMediaPlayer1.TabIndex = 41
        '
        'pbximagen2
        '
        Me.pbximagen2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbximagen2.Image = CType(resources.GetObject("pbximagen2.Image"), System.Drawing.Image)
        Me.pbximagen2.Location = New System.Drawing.Point(254, 205)
        Me.pbximagen2.Name = "pbximagen2"
        Me.pbximagen2.Size = New System.Drawing.Size(120, 68)
        Me.pbximagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbximagen2.TabIndex = 42
        Me.pbximagen2.TabStop = False
        '
        'btncomprar2
        '
        Me.btncomprar2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncomprar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncomprar2.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomprar2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btncomprar2.Location = New System.Drawing.Point(384, 245)
        Me.btncomprar2.Name = "btncomprar2"
        Me.btncomprar2.Size = New System.Drawing.Size(88, 26)
        Me.btncomprar2.TabIndex = 43
        Me.btncomprar2.Text = "COMPRAR"
        Me.btncomprar2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(380, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "El Noa Noa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(381, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Juan Gabriel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(381, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Juan Gabriel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(380, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Así fue"
        '
        'btncomprar4
        '
        Me.btncomprar4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncomprar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncomprar4.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomprar4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btncomprar4.Location = New System.Drawing.Point(384, 332)
        Me.btncomprar4.Name = "btncomprar4"
        Me.btncomprar4.Size = New System.Drawing.Size(88, 26)
        Me.btncomprar4.TabIndex = 51
        Me.btncomprar4.Text = "COMPRAR"
        Me.btncomprar4.UseVisualStyleBackColor = True
        '
        'pbximagen4
        '
        Me.pbximagen4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbximagen4.Image = CType(resources.GetObject("pbximagen4.Image"), System.Drawing.Image)
        Me.pbximagen4.Location = New System.Drawing.Point(254, 292)
        Me.pbximagen4.Name = "pbximagen4"
        Me.pbximagen4.Size = New System.Drawing.Size(120, 68)
        Me.pbximagen4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbximagen4.TabIndex = 50
        Me.pbximagen4.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(139, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Juan Gabriel"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(138, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Querida"
        '
        'btncomprar3
        '
        Me.btncomprar3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncomprar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncomprar3.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomprar3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btncomprar3.Location = New System.Drawing.Point(142, 331)
        Me.btncomprar3.Name = "btncomprar3"
        Me.btncomprar3.Size = New System.Drawing.Size(88, 26)
        Me.btncomprar3.TabIndex = 47
        Me.btncomprar3.Text = "COMPRAR"
        Me.btncomprar3.UseVisualStyleBackColor = True
        '
        'pbximagen3
        '
        Me.pbximagen3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbximagen3.Image = CType(resources.GetObject("pbximagen3.Image"), System.Drawing.Image)
        Me.pbximagen3.Location = New System.Drawing.Point(12, 291)
        Me.pbximagen3.Name = "pbximagen3"
        Me.pbximagen3.Size = New System.Drawing.Size(120, 68)
        Me.pbximagen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbximagen3.TabIndex = 46
        Me.pbximagen3.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(381, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Juan Gabriel"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(380, 379)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 20)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Abrázame muy fuerte"
        '
        'btncomprar6
        '
        Me.btncomprar6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncomprar6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncomprar6.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomprar6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btncomprar6.Location = New System.Drawing.Point(384, 419)
        Me.btncomprar6.Name = "btncomprar6"
        Me.btncomprar6.Size = New System.Drawing.Size(88, 26)
        Me.btncomprar6.TabIndex = 59
        Me.btncomprar6.Text = "COMPRAR"
        Me.btncomprar6.UseVisualStyleBackColor = True
        '
        'pbximagen6
        '
        Me.pbximagen6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbximagen6.Image = CType(resources.GetObject("pbximagen6.Image"), System.Drawing.Image)
        Me.pbximagen6.Location = New System.Drawing.Point(254, 379)
        Me.pbximagen6.Name = "pbximagen6"
        Me.pbximagen6.Size = New System.Drawing.Size(120, 68)
        Me.pbximagen6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbximagen6.TabIndex = 58
        Me.pbximagen6.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Agency FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(139, 398)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 17)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Juan Gabriel"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(138, 378)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 20)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Amor Eterno"
        '
        'btncomprar5
        '
        Me.btncomprar5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncomprar5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncomprar5.Font = New System.Drawing.Font("Agency FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomprar5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btncomprar5.Location = New System.Drawing.Point(142, 418)
        Me.btncomprar5.Name = "btncomprar5"
        Me.btncomprar5.Size = New System.Drawing.Size(88, 26)
        Me.btncomprar5.TabIndex = 55
        Me.btncomprar5.Text = "COMPRAR"
        Me.btncomprar5.UseVisualStyleBackColor = True
        '
        'pbximagen5
        '
        Me.pbximagen5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbximagen5.Image = CType(resources.GetObject("pbximagen5.Image"), System.Drawing.Image)
        Me.pbximagen5.Location = New System.Drawing.Point(12, 378)
        Me.pbximagen5.Name = "pbximagen5"
        Me.pbximagen5.Size = New System.Drawing.Size(120, 68)
        Me.pbximagen5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbximagen5.TabIndex = 54
        Me.pbximagen5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(501, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btncomprar6)
        Me.Controls.Add(Me.pbximagen6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btncomprar5)
        Me.Controls.Add(Me.pbximagen5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btncomprar4)
        Me.Controls.Add(Me.pbximagen4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btncomprar3)
        Me.Controls.Add(Me.pbximagen3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btncomprar2)
        Me.Controls.Add(Me.pbximagen2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.lblalbum)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblprecio)
        Me.Controls.Add(Me.btncomprar1)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pbxcentral)
        Me.Controls.Add(Me.pbximagen1)
        Me.Controls.Add(Me.lblaño)
        Me.Controls.Add(Me.lblautor)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btncerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbximagen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxcentral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbximagen2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbximagen4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbximagen3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbximagen6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbximagen5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncerrar As Button
    Friend WithEvents lbltitulo As Label
    Friend WithEvents lblautor As Label
    Friend WithEvents lblaño As Label
    Friend WithEvents pbximagen1 As PictureBox
    Friend WithEvents pbxcentral As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents btncomprar1 As Button
    Friend WithEvents lblprecio As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblalbum As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents pbximagen2 As PictureBox
    Friend WithEvents btncomprar2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btncomprar4 As Button
    Friend WithEvents pbximagen4 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btncomprar3 As Button
    Friend WithEvents pbximagen3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btncomprar6 As Button
    Friend WithEvents pbximagen6 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btncomprar5 As Button
    Friend WithEvents pbximagen5 As PictureBox
End Class
