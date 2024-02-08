﻿Public Class Coinslot
    Public Event CoinreturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer)
    Public Property Quarters As Integer
    Public Property Nickels As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Public ReadOnly Property Total As Decimal
        Get
            Return Dollars + Quarters * 0.25 + Dimes * 0.1 + Nickels * 0.05
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
End Class
