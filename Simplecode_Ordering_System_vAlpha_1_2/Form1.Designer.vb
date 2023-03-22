<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.BottomBar1 = New System.Windows.Forms.Panel()
        Me.Handle_AddOrder_Btn = New System.Windows.Forms.Button()
        Me.FreshOrder_Btn = New System.Windows.Forms.Button()
        Me.Handle_UP_Btn = New System.Windows.Forms.Button()
        Me.Handle_DOWN_Btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GUI_Table_Ranking = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GUI_Table_Telephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GUI_Table_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GUI_Table_Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Job = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GUI_Table_Comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GUI_Table_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Handle_AddCustomer_Btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 126)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'NameLabel1
        '
        Me.NameLabel1.AutoSize = True
        Me.NameLabel1.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.NameLabel1.Location = New System.Drawing.Point(299, 13)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(373, 29)
        Me.NameLabel1.TabIndex = 1
        Me.NameLabel1.Text = "Keep 'em Tidy :: Ordering System"
        '
        'BottomBar1
        '
        Me.BottomBar1.Location = New System.Drawing.Point(13, 536)
        Me.BottomBar1.Name = "BottomBar1"
        Me.BottomBar1.Size = New System.Drawing.Size(200, 14)
        Me.BottomBar1.TabIndex = 5
        '
        'Handle_AddOrder_Btn
        '
        Me.Handle_AddOrder_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Handle_AddOrder_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Handle_AddOrder_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Handle_AddOrder_Btn.Image = CType(resources.GetObject("Handle_AddOrder_Btn.Image"), System.Drawing.Image)
        Me.Handle_AddOrder_Btn.Location = New System.Drawing.Point(528, 381)
        Me.Handle_AddOrder_Btn.Name = "Handle_AddOrder_Btn"
        Me.Handle_AddOrder_Btn.Size = New System.Drawing.Size(244, 99)
        Me.Handle_AddOrder_Btn.TabIndex = 6
        Me.Handle_AddOrder_Btn.UseVisualStyleBackColor = False
        '
        'FreshOrder_Btn
        '
        Me.FreshOrder_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.FreshOrder_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FreshOrder_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FreshOrder_Btn.Image = CType(resources.GetObject("FreshOrder_Btn.Image"), System.Drawing.Image)
        Me.FreshOrder_Btn.Location = New System.Drawing.Point(528, 12)
        Me.FreshOrder_Btn.Name = "FreshOrder_Btn"
        Me.FreshOrder_Btn.Size = New System.Drawing.Size(244, 99)
        Me.FreshOrder_Btn.TabIndex = 8
        Me.FreshOrder_Btn.UseVisualStyleBackColor = False
        '
        'Handle_UP_Btn
        '
        Me.Handle_UP_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Handle_UP_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Handle_UP_Btn.Image = CType(resources.GetObject("Handle_UP_Btn.Image"), System.Drawing.Image)
        Me.Handle_UP_Btn.Location = New System.Drawing.Point(13, 381)
        Me.Handle_UP_Btn.Name = "Handle_UP_Btn"
        Me.Handle_UP_Btn.Size = New System.Drawing.Size(122, 99)
        Me.Handle_UP_Btn.TabIndex = 9
        Me.Handle_UP_Btn.UseVisualStyleBackColor = True
        '
        'Handle_DOWN_Btn
        '
        Me.Handle_DOWN_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Handle_DOWN_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Handle_DOWN_Btn.Image = CType(resources.GetObject("Handle_DOWN_Btn.Image"), System.Drawing.Image)
        Me.Handle_DOWN_Btn.Location = New System.Drawing.Point(142, 381)
        Me.Handle_DOWN_Btn.Name = "Handle_DOWN_Btn"
        Me.Handle_DOWN_Btn.Size = New System.Drawing.Size(122, 99)
        Me.Handle_DOWN_Btn.TabIndex = 10
        Me.Handle_DOWN_Btn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GUI_Table_Ranking, Me.GUI_Table_Telephone, Me.GUI_Table_Name, Me.GUI_Table_Address, Me.Job, Me.GUI_Table_Comment, Me.GUI_Table_Status})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 146)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 75
        Me.DataGridView1.Size = New System.Drawing.Size(755, 220)
        Me.DataGridView1.TabIndex = 11
        '
        'GUI_Table_Ranking
        '
        Me.GUI_Table_Ranking.HeaderText = "Ιδιότητα"
        Me.GUI_Table_Ranking.Name = "GUI_Table_Ranking"
        Me.GUI_Table_Ranking.ReadOnly = True
        '
        'GUI_Table_Telephone
        '
        Me.GUI_Table_Telephone.HeaderText = "Τηλέφωνο"
        Me.GUI_Table_Telephone.Name = "GUI_Table_Telephone"
        Me.GUI_Table_Telephone.ReadOnly = True
        '
        'GUI_Table_Name
        '
        Me.GUI_Table_Name.HeaderText = "Όνομα"
        Me.GUI_Table_Name.Name = "GUI_Table_Name"
        Me.GUI_Table_Name.ReadOnly = True
        '
        'GUI_Table_Address
        '
        Me.GUI_Table_Address.HeaderText = "Διεύθυνση"
        Me.GUI_Table_Address.Name = "GUI_Table_Address"
        Me.GUI_Table_Address.ReadOnly = True
        '
        'Job
        '
        Me.Job.HeaderText = "Επάγγελμα"
        Me.Job.Name = "Job"
        Me.Job.ReadOnly = True
        '
        'GUI_Table_Comment
        '
        Me.GUI_Table_Comment.HeaderText = "Σχόλιο"
        Me.GUI_Table_Comment.Name = "GUI_Table_Comment"
        Me.GUI_Table_Comment.ReadOnly = True
        '
        'GUI_Table_Status
        '
        Me.GUI_Table_Status.HeaderText = "Κατάσταση"
        Me.GUI_Table_Status.Name = "GUI_Table_Status"
        '
        'Handle_AddCustomer_Btn
        '
        Me.Handle_AddCustomer_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Handle_AddCustomer_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Handle_AddCustomer_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Handle_AddCustomer_Btn.Image = CType(resources.GetObject("Handle_AddCustomer_Btn.Image"), System.Drawing.Image)
        Me.Handle_AddCustomer_Btn.Location = New System.Drawing.Point(278, 381)
        Me.Handle_AddCustomer_Btn.Name = "Handle_AddCustomer_Btn"
        Me.Handle_AddCustomer_Btn.Size = New System.Drawing.Size(244, 99)
        Me.Handle_AddCustomer_Btn.TabIndex = 12
        Me.Handle_AddCustomer_Btn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(385, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Ρυθμίσεις"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(304, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Πελάτες"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(466, 46)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Οδηγίες"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(547, 46)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Στατιστικά"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(628, 46)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Τιμοκατάλογος"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Handle_AddCustomer_Btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Handle_DOWN_Btn)
        Me.Controls.Add(Me.Handle_UP_Btn)
        Me.Controls.Add(Me.FreshOrder_Btn)
        Me.Controls.Add(Me.Handle_AddOrder_Btn)
        Me.Controls.Add(Me.BottomBar1)
        Me.Controls.Add(Me.NameLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form1"
        Me.Text = "Simplecode - Keep 'em Tidy :: Ordering System (V.0.2. ALPHA)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NameLabel1 As Label
    Friend WithEvents BottomBar As Panel
    Friend WithEvents BottomBar1 As Panel
    Friend WithEvents Handle_AddOrder_Btn As Button
    Friend WithEvents FreshOrder_Btn As Button
    Friend WithEvents Handle_UP_Btn As Button
    Friend WithEvents Handle_DOWN_Btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GUI_Table_Ranking As DataGridViewTextBoxColumn
    Friend WithEvents GUI_Table_Telephone As DataGridViewTextBoxColumn
    Friend WithEvents GUI_Table_Name As DataGridViewTextBoxColumn
    Friend WithEvents GUI_Table_Address As DataGridViewTextBoxColumn
    Friend WithEvents Job As DataGridViewTextBoxColumn
    Friend WithEvents GUI_Table_Comment As DataGridViewTextBoxColumn
    Friend WithEvents GUI_Table_Status As DataGridViewTextBoxColumn
    Friend WithEvents Handle_AddCustomer_Btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
