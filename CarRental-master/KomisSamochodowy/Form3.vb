Imports System.Data.OleDb
Imports System.IO

Public Class Form3
    Dim dbConnection As OleDbConnection
    Dim dbAdapter As OleDbDataAdapter = New OleDb.OleDbDataAdapter()

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
  AppDomain.CurrentDomain.BaseDirectory + "bazy\")
            If (Path.GetExtension(foundFile).Equals(".mdb")) Then
                ListBox1.Items.Add(Dir(foundFile))
            End If
        Next
    End Sub



    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim dataBaseName As String
        'wybrana pozycja z listy table w sTableName
        dataBaseName = "bazy\" + ListBox1.Items(ListBox1.SelectedIndex).ToString

        Dim sConStr As String
        'tutaj budujemy ConnectionString składajac go z cześci stałej oraz
        ' dynamicznej reprezentującej nazwę pliku
        sConStr = "Provider=Microsoft.Jet.OLEDB.4.0;"
        sConStr &= "Data Source=" & dataBaseName & ";"
        If Not dbConnection Is Nothing Then
            dbConnection.Close()
            dbConnection = Nothing
        End If
        dbConnection = New OleDbConnection(sConStr)
        dbConnection.Open()
        Dim schemaTable As DataTable =
                    dbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
            New Object() {Nothing, Nothing, Nothing, "TABLE"})

        dbConnection.Close()
        'NA wszelki wypadek czyścimy ListBox lstTables przed dodaniem
        ListBox2.Items.Clear()
        For i = 0 To schemaTable.Rows.Count - 1
            'Kolekcja Items to kolumny w schemaTable. Kolumna 0 i 1 jest Null,
            ' kolumna 2 zawiera nazwę tabeli .
            ListBox2.Items.Add(schemaTable.Rows(i).Item(2))
        Next i
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim sTableName As String
        'wybrana pozycja z listy table w sTableName
        sTableName = ListBox2.Items(ListBox2.SelectedIndex).ToString

        Dim selectCMD As OleDbCommand =
        New OleDbCommand("SELECT * FROM " &
        "[" & sTableName & "]", dbConnection)
        'wiążemy adapter z komedą SQL
        dbAdapter.SelectCommand = selectCMD
        ' Tworzymy obiekt DataSet do przechowaywania informacji o wybranej tabeli Dim
        Dim dbDataSet As DataSet = New DataSet()
        dbDataSet.Clear()
        dbAdapter.Fill(dbDataSet, sTableName)
        'czyścimy listBox z nazwami kolumn

        Dim MyBindingSource As New BindingSource
        Dim MyDataTable As New DataTable
        dbAdapter.Fill(MyDataTable)
        'stworzyć powiazanie pomiedzy DataTable a BindingSource
        MyBindingSource.DataSource = MyDataTable
        DataGridView1.DataSource = MyBindingSource
    End Sub
End Class