Imports System.IO
Public Class Card
    Private intYear As Integer

    Public Property PlayerName As String
    Public Property Year As Integer
        Get
            ' return the value of the backing field
            Return intYear
        End Get
        Set(value As Integer)
            ' validate the value being set
            If value < 100 Then
                If value < 30 Then
                    value += 2000
                Else
                    value += 1900
                End If
            End If
            intYear = value ' set the backing field to the validated value
        End Set
    End Property

    'Auto Implementation for Team. Graded, and Signed 
    Public Property Team As String
    Public Property Graded As Boolean
    Public Property Signed As Boolean

    ' default constructor
    Public Sub New()
        Graded = False
        Signed = False
    End Sub

    ' parameterized constructor
    Public Sub New(ByVal strPlayerName As String, ByVal intYear As Integer, ByVal strTeam As String)

        ' set PlayerName to the value passed in(strPlayerName)
        PlayerName = strPlayerName

        ' set Year to the value passed in(intYear) 
        Year = intYear

        ' set Team to the value passed in(strTeam)
        Team = strTeam
        'set Signed nad Graded to False
        Graded = False
        Signed = False
    End Sub

    ' parameterized constructor
    Public Sub New(ByVal strPlayerName As String, ByVal intYear As Integer, ByVal strTeam As String, ByVal boolGraded As Boolean, ByVal boolSigned As Boolean)
        PlayerName = strPlayerName ' set PlayerName to the value passed 
        Year = intYear ' set Year to the value passed 
        Team = strTeam ' set Team to the value passed 
        Graded = boolGraded ' set Graded to the value passed 
        Signed = boolSigned ' set Signed to the value passed 
    End Sub

    'Override the ToString method to return a string in the format "PlayerName (Year)"
    Public Overrides Function ToString() As String
        Return PlayerName & " (" & Year.ToString() & ")"
    End Function
End Class
