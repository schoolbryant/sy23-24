Public Class Coinslot
    Public Event Dispense(p As Image)
    Public Event CoinreturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer)
    Public Property Quarters As Integer
    Public Property Nickels As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Dim _Total As Decimal
    Public ReadOnly Property Total As Decimal
        Get
            _Total = Dollars + Quarters * 0.25 + Dimes * 0.1 + Nickels * 0.05
            Return _Total
        End Get
    End Property
    Public Sub Coinreturn()
        RaiseEvent CoinreturnEvent(Dollars, Quarters, Dimes, Nickels)
        Dollars = 0
        Quarters = 0
        Dimes = 0
        Nickels = 0
    End Sub
    Public Sub Insertquarter()
        Quarters = Quarters + 1
    End Sub
    Public Sub Insertnickel()
        Nickels = Nickels + 1
    End Sub
    Public Sub Insertdime()
        Dimes = Dimes + 1
    End Sub
    Public Sub Insertdollar()
        Dollars = Dollars + 1
    End Sub
    Public Sub spin()
        If Total >= 1 Then
            _Total = _Total - 1
            Dollars = 0
            Quarters = 0
            Dimes = 0
            Nickels = _Total / 0.05
        End If
    End Sub
End Class

