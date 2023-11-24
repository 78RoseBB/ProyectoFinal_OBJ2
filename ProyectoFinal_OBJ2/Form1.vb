Imports System
Imports System.Linq
Imports System.Windows.Forms
Imports Fluent.Infrastructure.FluentModel

Namespace ProyectoFinal_OBJ2
    Partial Public Class Form1
        Inherits Form

        Private ReadOnly dbContext As New ApplicationDbContext()
        Private WithEvents btnAgregar As Button
        Private txtNombre As TextBox ' Declarar txtNombre aquí para que sea accesible en toda la clase

        Public Sub New()
            InitializeComponent()
            InicializarControles() ' Llamar a un método para inicializar los controles
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Usuario = New System.Windows.Forms.TextBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Javanese Text", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(27, 12)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(188, 73)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Bienvenido"
            '
            'PictureBox1
            '
            Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.No
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(581, 12)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(133, 132)
            Me.PictureBox1.TabIndex = 2
            Me.PictureBox1.TabStop = False
            '
            'Button1
            '
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Button1.Font = New System.Drawing.Font("Roboto", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button1.ForeColor = System.Drawing.Color.SeaShell
            Me.Button1.Location = New System.Drawing.Point(464, 293)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(133, 30)
            Me.Button1.TabIndex = 3
            Me.Button1.Text = "Ingresar"
            Me.Button1.UseMnemonic = False
            Me.Button1.UseVisualStyleBackColor = False
            Me.Button1.UseWaitCursor = True
            '
            'Button2
            '
            Me.Button2.BackColor = System.Drawing.Color.Black
            Me.Button2.Font = New System.Drawing.Font("Roboto", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.ForeColor = System.Drawing.Color.SeaShell
            Me.Button2.Location = New System.Drawing.Point(606, 293)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(133, 30)
            Me.Button2.TabIndex = 4
            Me.Button2.Text = "Cancelar"
            Me.Button2.UseMnemonic = False
            Me.Button2.UseVisualStyleBackColor = False
            Me.Button2.UseWaitCursor = True
            '
            'Usuario
            '
            Me.Usuario.BackColor = System.Drawing.Color.White
            Me.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.Usuario.Location = New System.Drawing.Point(194, 124)
            Me.Usuario.Name = "Usuario"
            Me.Usuario.Size = New System.Drawing.Size(194, 20)
            Me.Usuario.TabIndex = 5
            Me.Usuario.Text = "Usuario"
            '
            'TextBox1
            '
            Me.TextBox1.BackColor = System.Drawing.Color.White
            Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.TextBox1.Location = New System.Drawing.Point(194, 182)
            Me.TextBox1.Name = "Contraseña"
            Me.TextBox1.Size = New System.Drawing.Size(194, 20)
            Me.TextBox1.TabIndex = 6
            Me.TextBox1.Text = "Contraseña"
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(751, 347)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Usuario)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Label1)
            Me.Name = "Form1"
            Me.Text = "Taekwondo Oriente"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub


        Private Sub InicializarControles()
            btnAgregar = New Button() ' Inicializar el botón
            txtNombre = New TextBox() ' Inicializar el TextBox
            ' Configuraciones adicionales de los controles
        End Sub


        Private components As System.ComponentModel.IContainer

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

        End Sub

        Friend WithEvents Label1 As Label

        Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        End Sub

        Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)

        End Sub

        Friend WithEvents Button1 As Button

        Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
            InicializarControles()
        End Sub

        Friend WithEvents Button2 As Button

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Application.Exit()
        End Sub

        Protected WithEvents PictureBox1 As PictureBox
        Public WithEvents Usuario As TextBox
        Public WithEvents TextBox1 As TextBox
    End Class
End Namespace

