
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms

Public Class Inverter
    '  Private Shared __ENCList As New List(Of WeakReference)()
    Private exit_ As Boolean
    Private invertX_ As Boolean
    Private invertY_ As Boolean
    Private pos As Point
    Private running_ As Boolean
    Private swap_ As Boolean


    Public Sub New(x As Boolean, y As Boolean)
        Me.pos = Cursor.Position
        Me.invertX_ = x
        Me.invertY_ = y
        Me.pos = Cursor.Position
    End Sub

    Public Event InvertSettingsChangedEvent(inverter As Inverter, eventArgs As EventArgs)

    Private Sub MouseLoop()
        While Not Me.exit_
            Dim position As Point = Cursor.Position
            Dim x As Integer = 0
            Dim y As Integer = 0
            If Me.swap_ Then
                x = If(Me.InvertX, (Me.pos.X - (position.Y - Me.pos.Y)), (Me.pos.X + (position.Y - Me.pos.Y)))
                y = If(Me.InvertY, (Me.pos.Y - (position.X - Me.pos.X)), (Me.pos.Y + (position.X - Me.pos.X)))
            Else
                x = If(Me.InvertX, (Me.pos.X - (position.X - Me.pos.X)), position.X)
                y = If(Me.InvertY, (Me.pos.Y - (position.Y - Me.pos.Y)), position.Y)
            End If
            If Me.InvertX Then
                If x < 2 Then
                    x = 2
                End If
                If x > (Screen.FromPoint(position).Bounds.Right - 2) Then
                    x = Screen.FromPoint(position).Bounds.Right - 2
                End If
            End If
            If Me.InvertY Then
                If y < 2 Then
                    y = 2
                End If
                If y > (Screen.FromPoint(position).Bounds.Bottom - 2) Then
                    y = Screen.FromPoint(position).Bounds.Bottom - 2
                End If
            End If
            Dim point2 As New Point(x, y)
            Cursor.Position = point2
            Me.pos = Cursor.Position
            Thread.Sleep(5)
        End While
        Me.exit_ = False
    End Sub

    Public Sub Start()
        Me.pos = Cursor.Position
        Me.running_ = True
        Dim thead = New Thread(New ThreadStart(AddressOf Me.MouseLoop)) With { _
          .Priority = ThreadPriority.Highest, _
            .IsBackground = True _
        }
        thead.Start()
    End Sub

    Public Sub [Stop]()
        Me.running_ = False
        Me.exit_ = True
    End Sub

    Public Property InvertX() As Boolean
        Get
            Return Me.invertX_
        End Get
        Set(value As Boolean)
            Me.invertX_ = value
            '     Dim invertSettingsChangedEvent As EventHandler = Me.InvertSettingsChangedEvent
            RaiseEvent InvertSettingsChangedEvent(Me, New EventArgs())
        End Set
    End Property

    Public Property InvertY() As Boolean
        Get
            Return Me.invertY_
        End Get
        Set(value As Boolean)
            Me.invertY_ = value
            '    Dim invertSettingsChangedEvent As EventHandler = Me.InvertSettingsChangedEvent
            RaiseEvent InvertSettingsChangedEvent(Me, New EventArgs())
        End Set
    End Property

    Public ReadOnly Property Running() As Boolean
        Get
            Return Me.running_
        End Get
    End Property
    Public Property Swap() As Boolean
        Get
            Return Me.swap_
        End Get
        Set(value As Boolean)
            Me.swap_ = value
            '   Dim invertSettingsChangedEvent As EventHandler = Me.InvertSettingsChangedEvent
            RaiseEvent InvertSettingsChangedEvent(Me, New EventArgs())
        End Set
    End Property
End Class
