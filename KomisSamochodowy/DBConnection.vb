Imports MySql.Data.MySqlClient

Public Class DBConnection
    Private Const SHOW_DATABASES As String = "SHOW DATABASES"

    Public Sub connectionToDatabase(stmDB, connStr, item)
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Dim conn As New MySqlConnection(connStr)

        Try
            conn.Open()

            ds = New DataSet
            da = New MySqlDataAdapter(stmDB, conn)
            da.Fill(ds, "cars")
            If (stmDB.Equals(SHOW_DATABASES)) Then
                insertNameOfDataBase(ds, item)
            ElseIf (stmDB.ToString.StartsWith("SELECT DISTINCT")) Then
                insertIntoComboBox(ds, item)
            ElseIf (stmDB.ToString.StartsWith("SELECT FORMAT")) Then
                item.text = "Średnia ocen: " + ds.Tables("cars").Rows(0).Item(0).ToString
            ElseIf (stmDB.ToString.StartsWith("SELECT login")) Then
                Try
                    Form1.checkLoginData(ds.Tables("cars").Rows(0).Item(0).ToString)
                Catch ex As Exception
                    MessageBox.Show("Incorect data, please try again")
                End Try
            ElseIf (item.GetType.IsPrimitive) Then
                checkOptionStatus(ds, item)
            Else
                fillDataGridWithDBData(ds, item)
            End If

        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        conn.Close()
    End Sub

    Private Sub insertNameOfDataBase(ds, item)
        For i = 0 To ds.Tables("cars").Rows.Count - 1
            If (ds.Tables("cars").Rows(i).Item(0).Equals("sys") Or
                    ds.Tables("cars").Rows(i).Item(0).Equals("information_schema") Or
                    ds.Tables("cars").Rows(i).Item(0).Equals("mysql") Or
                    ds.Tables("cars").Rows(i).Item(0).Equals("users") Or
                    ds.Tables("cars").Rows(i).Item(0).Equals("performance_schema")) Then
                Continue For
            Else
                item.Items.Add(ds.Tables("cars").Rows(i).Item(0))
            End If
        Next i
    End Sub

    Private Sub insertIntoComboBox(ds, item)
        For i = 0 To ds.Tables("cars").Rows.Count - 1
            If (item.Items.Contains(ds.Tables("cars").Rows(i).Item(0))) Then
                Continue For
            Else
                item.Items.Add(ds.Tables("cars").Rows(i).Item(0))
            End If
        Next i
    End Sub

    Private Sub checkOptionStatus(ds, item)
        If (ds.Tables("cars").Rows(0).Item(0)) Then
            Form1.Opcje.SetItemCheckState(item, CheckState.Checked)
        Else
            Form1.Opcje.SetItemCheckState(item, CheckState.Unchecked)
        End If
    End Sub


    Public Sub fillDataGridWithDBData(ds, item)
        item.DataSource = ds.Tables("cars")
    End Sub

    Public Sub getDataBaseName(item)
        Dim connStr As String = "server=localhost;user=root;database=intercars;port=3306;password=root;"
        Dim stmDB As String = SHOW_DATABASES

        connectionToDatabase(stmDB, connStr, item)
    End Sub
End Class
