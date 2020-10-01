Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.io
Module PrimeModule
    Public strConnect As String
    Public Password, SysPwd As String
    Public UserID As String
    Public IntegratedSecurity As Boolean
    Public strApptitle As String = "PrimeScholar"
    Public sysOwner As String = "Megahit Systems"
    Public ServerName As String = My.Computer.Name
    Public sysUserName As String = ""
    Public sysUser As String = ""
    Public ThePhase As String = ""
    'Public USD As String = ""
    'Public GBP As String = ""
    'Public EUR As String = ""

    Public AttachName As String = "PrimeScholar"
    Public AppPath As String
    Public MSAccessCn As String
    Public LogOnFail As Boolean = False
    Public arrayLogo() As Byte
    Public arrayBody() As Byte
    Public strOwnerFromServer As String = "Megahit Systems"
    Public strLevel As String = ""
    Public Fmt As String = "###,##0.00" 'used format number to the format
    Public MandatePrefix, CustomerRefPrefix
    Public PictBody As Boolean = False

    Public Signatory1 As String
    Public Signatory2 As String
    Public Signatory3 As String
    Public SignatoryDesig1 As String
    Public SignatoryDesig2 As String
    Public SignatoryDesig3 As String
    Public PreparedBy As String

    Public Enum AppAction
        Add = 1
        Edit = 2
        Delete = 3
        Browse = 4
        Open = 6
    End Enum
    Sub New()
        sysOwner = "MegaHit Systems, Abuja"
        AppPath = IIf(Len(My.Application.Info.DirectoryPath) <= 3, My.Application.Info.DirectoryPath, My.Application.Info.DirectoryPath + "\")
        ' AppPath = "c:\Applications\PrimeScholar\"
        MSAccessCn = "Provider=Microsoft.jet.oledb.4.0;Data Source=" + AppPath + "ConfigDir\Config.gif;Jet OLEDB:Database Password=secret" ' & 
        InitialiseEntireSystem()
    End Sub
    Public Sub InitialiseEntireSystem()
        On Error GoTo handler
        'sysOwner = "MegaHit Systems, Abuja"
        Dim cnOle As OleDbConnection
        Dim cmOle As OleDbCommand
        Dim drOle As OleDbDataReader

        cnOle = New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" & AppPath & "ConfigDir\Config.gif;Jet OLEDB:Database Password=secret")
        cnOle.Open()

        cmOle = New OleDbCommand("SELECT * FROM SvrParam", cnOle)
        drOle = cmOle.ExecuteReader()

        If drOle.HasRows = False Then
            MsgBox("Invalid Configuration Parameter" & Chr(13) & "System Halted", MsgBoxStyle.Information)
            End
        End If
        If drOle.Read Then
            ServerName = IIf(IsDBNull(drOle.Item("ServerName").ToString()), "", drOle.Item("ServerName").ToString())
            UserID = IIf(IsDBNull(drOle.Item("UserID").ToString()), "", drOle.Item("UserID").ToString())
            Password = IIf(IsDBNull(drOle.Item("Password").ToString()), "", drOle.Item("Password").ToString())
            IntegratedSecurity = drOle.Item("IntegratedSecurity")
            sysOwner = IIf(IsDBNull(drOle.Item("Owner").ToString()), "Invalid User", drOle.Item("Owner").ToString())
            strOwnerFromServer = sysOwner
            AttachName = IIf(IsDBNull(drOle.Item("AttachName").ToString()), "", drOle.Item("AttachName").ToString())
        End If
        If drOle.Item("IntegratedSecurity") = False Then
            strConnect = "Data Source=" & ServerName & ";Initial Catalog=" & AttachName & ";Persist Security Info=True;User ID=" & UserID & ";Password=" & Password
        Else
            strConnect = "Data Source=" & ServerName & ";Initial Catalog=" & AttachName & ";Integrated Security=True"
        End If
        'strConnect = "Data Source=MHCLIENT;Initial Catalog=BnkReconcile;Persist Security Info=True;User ID=sa;Password=penny"
        drOle.Close()
        cnOle.Close()
        cmOle.Dispose()
        cnOle.Dispose()

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()

        cmSQL.CommandText = "FetchAllSystemParameters"
        cmSQL.CommandType = CommandType.StoredProcedure
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Invalid System Parameters")
            End
        Else
            If drSQL.Read Then
                ThePhase = drSQL.Item("Me")
                arrayLogo = CType(drSQL.Item("Logo"), Byte())
                arrayBody = CType(drSQL.Item("BackImage"), Byte())
                MandatePrefix = ChkNull(drSQL.Item("MandatePrefix"))
                CustomerRefPrefix = ChkNull(drSQL.Item("CustomerRefPrefix"))

                'USD = ChkNull(drSQL.Item("USD"))
                'GBP = ChkNull(drSQL.Item("GBP"))
                'EUR = ChkNull(drSQL.Item("EUR"))

                Signatory1 = ChkNull(drSQL.Item("1stSignatory"))
                Signatory2 = ChkNull(drSQL.Item("2ndSignatory"))
                Signatory3 = ChkNull(drSQL.Item("3rdSignatory"))
                SignatoryDesig1 = ChkNull(drSQL.Item("1stSignatoryDesig"))
                SignatoryDesig2 = ChkNull(drSQL.Item("2ndSignatoryDesig"))
                SignatoryDesig3 = ChkNull(drSQL.Item("3rdSignatoryDesig"))
                PreparedBy = ChkNull(drSQL.Item("PreparedBy"))

            End If
        End If

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        If Err.Description Like "Cannot open database requested in login 'PrimeScholar'. Login fails*" Then
            If My.Computer.Name = ServerName Or UCase(ServerName) = "(LOCAL)" Then
                attachDB(AttachName)
            Else
                MsgBox("Database not attached...Pls. refer to the system administrator", MsgBoxStyle.Information, strApptitle)
            End If
        Else
            MsgBox(Err.Description, MsgBoxStyle.Critical, strApptitle)
            If Err.Description Like "*Login fails*" Then LogOnFail = True
        End If
    End Sub
    Sub attachDB(ByVal attachName As String)
        On Error GoTo handler
        Dim connectStr As String = ""

        If IntegratedSecurity Then
            connectStr = "workstation id=" & ServerName & ";packet size=4096;data source=" & ServerName & ";Integrated Security=True;initial catalog=master"
        Else
            connectStr = "workstation id=" & ServerName & ";packet size=4096;user id=" & UserID & ";pwd=" & Password & ";data source=" & ServerName & ";persist security info=False;initial catalog=master"
        End If

        Dim SqlCn As SqlConnection = New SqlConnection(connectStr)
        Dim strConnectMaster As String
        SqlCn.Open()
        On Error Resume Next

        Dim myCommand As SqlCommand = SqlCn.CreateCommand

        On Error GoTo handler
        Dim DBName As String = AppPath + "ConfigDir\PrimeScholar.MDF"
        myCommand.CommandText = "EXEC sp_attach_db @dbname = N'" & attachName & "',@filename1 = N'" & DBName & "',@filename2 = N'" & Mid(Trim(DBName), 1, InStr(Trim(DBName), ".") - 1) + ".LDF" & "'"
        myCommand.ExecuteNonQuery()

        myCommand.Connection.Close()
        myCommand.Dispose()
        SqlCn.Close()
        SqlCn.Dispose()
        MsgBox("Pls. restart the application", MsgBoxStyle.Information, strApptitle)
        End
        Exit Sub
        Resume
handler:
        MsgBox("Pls. refer to the system administrator", MsgBoxStyle.Information, strApptitle)

        'MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Public Sub InitialiseEntireSystem_Prev()
        sysOwner = "MegaHit Systems, Abuja"
        Dim cnOle As OleDbConnection
        Dim cmOle As OleDbCommand
        Dim drOle As OleDbDataReader

        Try
            cnOle = New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" & AppPath & "Config.gif;Jet OLEDB:Database Password=secret")
            cnOle.Open()

            cmOle = New OleDbCommand("SELECT * FROM SvrParam", cnOle)
            drOle = cmOle.ExecuteReader()

            If drOle.HasRows = False Then
                MsgBox("Invalid Configuration Parameter" & Chr(13) & "System Halted", MsgBoxStyle.Information)
                End
            End If
            If drOle.Read Then
                ServerName = IIf(IsDBNull(drOle.Item("ServerName").ToString()), "", drOle.Item("ServerName").ToString())
                UserID = IIf(IsDBNull(drOle.Item("UserID").ToString()), "", drOle.Item("UserID").ToString())
                Password = IIf(IsDBNull(drOle.Item("Password").ToString()), "", drOle.Item("Password").ToString())
                IntegratedSecurity = drOle.Item("IntegratedSecurity")
                sysOwner = IIf(IsDBNull(drOle.Item("Owner").ToString()), "MegaHit Systems", drOle.Item("Owner").ToString())
                AttachName = IIf(IsDBNull(drOle.Item("AttachName").ToString()), "", drOle.Item("AttachName").ToString())
            End If

            If drOle.Item("IntegratedSecurity") = False Then
                strConnect = "Data Source=" & ServerName & ";Initial Catalog=" & AttachName & ";Persist Security Info=True;User ID=" & UserID & ";Password=" & Password
            Else
                strConnect = "Data Source=" & ServerName & ";Initial Catalog=" & AttachName & ";Integrated Security=True"
            End If

            drOle.Close()
            cnOle.Close()
            cmOle.Dispose()
            cnOle.Dispose()

            Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
            Dim cmSQL As SqlCommand = cnSQL.CreateCommand
            Dim drSQL As SqlDataReader

            cnSQL.Open()

            cmSQL.CommandText = "FetchAllSystemParameters"
            cmSQL.CommandType = CommandType.StoredProcedure
            drSQL = cmSQL.ExecuteReader()
            If drSQL.HasRows = False Then
                MsgBox("Invalid System Parameters")
                End
            Else
                If drSQL.Read Then
                    arrayLogo = CType(drSQL.Item("Logo"), Byte())
                End If
            End If
            cmSQL.Connection.Close()
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            cnSQL.Dispose()

        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, strApptitle)
            If e.Message Like "*Login fails*" Then LogOnFail = True

        End Try
    End Sub
    Public Function formatDate(ByVal dtp As DateTimePicker) As Date
        If dtp.ShowCheckBox = True Then
            If dtp.Checked = False Then
                formatDate = "31-Dec-9998"
            Else
                formatDate = Format(dtp.Value, "dd-MMM-yyyy")
            End If
        Else
            formatDate = Format(dtp.Value, "dd-MMM-yyyy")
        End If
    End Function
    Public Function ChkNull(ByVal TheStr) As String
        ChkNull = IIf(IsDBNull(TheStr).ToString, "", TheStr.ToString)
    End Function

    Public Function GetUserAccessDetails(ByVal dModule As String, Optional ByVal DisplayMsg As Boolean = True) As Boolean
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        GetUserAccessDetails = False
        ' Try
        On Error Resume Next
        cnSQL.Open()

        cmSQL.CommandText = "FetchUserModuleAccess"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@UserID", sysUser)
        cmSQL.Parameters.AddWithValue("@Module", dModule)

        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
        Else
            If drSQL.Read Then
                GetUserAccessDetails = True
            End If
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        If GetUserAccessDetails = False And DisplayMsg = True Then MsgBox("Access is denied to the " + Chr(13) + UCase(dModule) + " module", MsgBoxStyle.Information, strApptitle)
        'Catch e As Exception
        '    MsgBox(e.Message, MsgBoxStyle.Critical, strApptitle)
        'End Try
    End Function
End Module
