Imports System.Data.SqlClient
Public Class inputdata
    Dim query As String
    Dim COMMMAND As SqlCommand
    Sub isiId()
        
        Dim READER As SqlDataReader
        Try
            'bukakoneksi()
            conn.ConnectionString = str
            conn.Open()

            query = "SELECT Max(StudentID) FROM StudentsInfo"
            COMMMAND = New SqlCommand(query, conn)
            READER = COMMMAND.ExecuteReader
            While READER.Read

                Dim dd = READER.GetInt32(0) '2210001

                'IDText.Text = dd
                IDText.Text = Microsoft.VisualBasic.Right(Today.Year, 2) & "1" & Microsoft.VisualBasic.Right(READER.GetInt32(0) + 1, 4) '0002+1
            End While
            conn.Close()
            'Dim copy = 

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub inputdata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isiId()
    End Sub

    Private Sub ReadSingleRow()
        Throw New NotImplementedException
    End Sub
    Sub cleartext()
        isiId()
        NameText.Text = ""
        ParentText.Text = ""
        AddressText.Text = ""
        PhoneText.Text = ""
        CityText.Text = ""
        CountryText.Text = ""
    End Sub
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        'langkah2 insert
        If NameText.Text = "" Or ParentText.Text = "" Or AddressText.Text = "" Or PhoneText.Text = "" Or CityText.Text = "" Or CountryText.Text = "" Then
            MsgBox("semua wajib diisi", MsgBoxStyle.Information)
        Else
            MsgBox("data saved", MsgBoxStyle.OkOnly)

        End If
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub
End Class