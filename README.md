# vbprogram-testcodingvb
# membuat id otomatis membaca dari id database yang terakhir
# menirukan apps yang sudah di buat untuk dijadikan contoh test vb
# kisi-kisi : CRUD,ID OTOMATIS,EXECEPTION HANDLING,
## Database menggunakan SQL SERVER by microsoft

1. cara koneksi lihat pada module1
2. cara id otomatis pada halaman ketika button di tekan pada costumer DI FORM INPUTDATA
3. tinggal tiru dan selesai

# komponen2 sql server
Imports System.Data.SqlClient
Public conn As New SqlConnection 'konek ke database
Public str As String = "Data Source=DESKTOP-LMEAVP1\ASUS;Initial Catalog=Students;Integrated Security=True" 'catalog itu database anda

conn.ConnectionString = str 'step ini wajib
            conn.Open() 'open koneksi

            query = "SELECT Max(StudentID) FROM StudentsInfo" 'query sesuai dengan tugas yang diinginkan
            COMMMAND = New SqlCommand(query, conn) 'wajib
            READER = COMMMAND.ExecuteReader 'buat baca untuk dikonversi menjadi textbox
            While READER.Read 'wajib

                Dim dd = READER.GetInt32(0) '2210001

                'IDText.Text = dd
                IDText.Text = Microsoft.VisualBasic.Right(Today.Year, 2) & "1" & Microsoft.VisualBasic.Right(READER.GetInt32(0) + 1, 4) '0002+1
            End While
            conn.Close() 'close
            'selengkapnya pada kodingan cara untuk menggunakannya
