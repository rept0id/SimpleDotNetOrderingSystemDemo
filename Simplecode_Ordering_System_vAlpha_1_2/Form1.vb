Public Class Form1
    'Author Radwan Ahmet <<radwan.ahmet@gmail.com>>.
    'Tested Maximized @ Windows 7, Width 1616 & Height 916...
    Dim OrdersTable As New DataTable("OrdersTable")
    Private DoneLoading As Boolean = False
    '
    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Welcome_Custom_Redraw()
        DoneLoading = True
        DataGridView1.Rows.Add(New String() {"Πελάτης", "2105722731", "Νέος Πελάτης", "ΑΓΝΩΣΤΗ", "ΑΓΝΩΣΤΟ", "", "Καινούργια"})
        DataGridView1.Rows.Add(New String() {"Πελάτης", "2105722731", "Γιάννης", "Simplecode", "ΣΥΝΕΡΓΕΙΟ", "ΚΑΛΟΣ_ΠΕΛΑΤΗΣ", "Επεξεργασμένη"})
        DataGridView1.Rows.Add(New String() {"Πελάτης", "2105722731", "Θάνος", "Simplecode", "ΓΡΑΦΕΙΟ", "ΚΑΛΟΣ_ΠΕΛΑΤΗΣ", "Επεξεργασμένη"})
        DataGridView1.Rows.Add(New String() {"Πελάτης", "2105722731", "Αλέξης", "Simplecode", "ΓΡΑΦΕΙΟ", "", "Επεξεργασμένη"})
        DataGridView1.Rows.Add(New String() {"Πελάτης", "2105722731", "Νέος Πελάτης", "ΑΓΝΩΣΤΗ", "ΑΓΝΩΣΤΟ", "", "Επεξεργασμένη"})
        DataGridView1.Rows.Add(New String() {"Τεχνική_υποστήριξη", "2105722731", "Simplecode", "Simplecode", "ΓΡΑΦΕΙΟ", "", "Επεξεργασμένη"})
        DataGridView1.Rows.Add(New String() {"Προσωπικό", "2105722731", "Simplecode", "Simplecode", "ΓΡΑΦΕΙΟ", "", "Επεξεργασμένη"})
        DataGridView1.Rows.Add(New String() {"Υπεύθηνος", "2105722731", "Simplecode", "Simplecode", "ΓΡΑΦΕΙΟ", "", "Επεξεργασμένη"})
        DataGridView1.Rows.Add(New String() {"Συνεργάτης", "2105722731", "Simplecode", "Simplecode", "ΓΡΑΦΕΙΟ", "", "Επεξεργασμένη"})
        DataGridView1.Rows.Add(New String() {"Άλλο", "2105722731", "Simplecode", "Simplecode", "", "ΚΑΛΟΣ_ΠΕΛΑΤΗΣ", "Επεξεργασμένη"})
        '
        'DataGridView1.ClearSelection()
        DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
    End Sub
    '
    Private Sub Welcome_Custom_Redraw()
        'H Bottom Bar χρησιμοποιείται ώστε να αποφύγουμε την απόκρυψη περιεχόμενου από την γραμμή εργασιών.
        BottomBar1.BackColor = Color.FromArgb(128, 0, 0, 0)
        BottomBar1.Size = New Size(Width, (((My.Computer.Screen.Bounds.Size.Height - My.Computer.Screen.WorkingArea.Size.Height) * 2) + 5))
        BottomBar1.Location = New Size(0, (Height - (((My.Computer.Screen.Bounds.Size.Height - My.Computer.Screen.WorkingArea.Size.Height) * 2))))
        '
        Handle_AddOrder_Btn.Location = New Size((Width - Handle_AddOrder_Btn.Width - (Width / 62.15) - 7), (Height - Handle_AddOrder_Btn.Height - BottomBar1.Height - (Height / 91.6)))
        Handle_AddCustomer_Btn.Location = New Size((Width - Handle_AddOrder_Btn.Width - Handle_AddOrder_Btn.Width - 7 - (Width / 62.15) - 7), (Height - Handle_AddOrder_Btn.Height - BottomBar1.Height - (Height / 91.6)))
        Handle_UP_Btn.Location = New Size(13, (Height - Handle_AddOrder_Btn.Height - BottomBar1.Height - (Height / 91.6)))
        Handle_DOWN_Btn.Location = New Size((Handle_UP_Btn.Location.X + Handle_UP_Btn.Width + 13), (Height - Handle_AddOrder_Btn.Height - BottomBar1.Height - (Height / 91.6)))
        '
        DataGridView1.Size = New Size((Width - (Width / 62.15) - DataGridView1.Location.X - 7), (Height - PictureBox1.Height - FreshOrder_Btn.Height - BottomBar1.Height - (Height / 91.6) - (Height / 36.6)) - 5)
        FreshOrder_Btn.Location = New Size((Width - FreshOrder_Btn.Width - (Width / 62.15) - 7), (Height / 91.6))
        'Responsive Design Παραμετροποίηση περιεχομένου.
        If Size.Width < "942" Then
            NameLabel1.Text = "Keep 'em Tidy"
        ElseIf Size.Width > "942" Then
            NameLabel1.Text = "Keep 'em Tidy :: Ordering System"
        End If
        '
        Dim LOCALWIDTH = (DataGridView1.Size.Width / (DataGridView1.Columns.Count + 1))
        DataGridView1.Columns(0).Width = LOCALWIDTH
        DataGridView1.Columns(1).Width = LOCALWIDTH
        DataGridView1.Columns(2).Width = LOCALWIDTH
        DataGridView1.Columns(3).Width = LOCALWIDTH
        DataGridView1.Columns(4).Width = LOCALWIDTH
        DataGridView1.Columns(5).Width = LOCALWIDTH
        DataGridView1.Columns(6).Width = LOCALWIDTH
    End Sub
    '
    Private Sub Welcome_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Με τη χρήση συνθήκης αποφεύγουμε άσκοπες κλήσεις της ρουτίνας επανασχεδιασμού (Welcome_Custom_Redraw()) όταν το πρόγραμμα ξεκινάει.
        If DoneLoading Then
            Welcome_Custom_Redraw()
        End If
    End Sub
    '
    Private Sub Handle_UP_Btn_Click(sender As Object, e As EventArgs) Handles Handle_UP_Btn.Click
        If DataGridView1.CurrentCell.RowIndex > 0 Then
            DataGridView1.CurrentCell = DataGridView1.Rows((DataGridView1.CurrentCell.RowIndex - 1)).Cells(0)
        Else
            DataGridView1.CurrentCell = DataGridView1.Rows((DataGridView1.Rows.Count - 1)).Cells(0)
        End If
    End Sub
    Private Sub Handle_DOWN_Btn_Click(sender As Object, e As EventArgs) Handles Handle_DOWN_Btn.Click
        If DataGridView1.CurrentCell.RowIndex < (DataGridView1.Rows.Count - 1) Then
            DataGridView1.CurrentCell = DataGridView1.Rows((DataGridView1.CurrentCell.RowIndex + 1)).Cells(0)
        Else
            DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class