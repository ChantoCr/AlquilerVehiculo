Public Class Alquiler
#Region "Atributos"
    Dim _Placa As String
    Dim _GPS As Boolean
    Dim _SeguroCompleto As Boolean
    Dim _SeguroBasico As Boolean
    Dim _CantPasajeros As Integer
    Dim _TarifaDiaria As Double
    Dim _CantDias As Double
    Dim _NumeroPasaporte As String



#End Region
#Region "Constructores"
    ''' <summary>
    ''' Constructor vacio del objeto
    ''' </summary>
    Public Sub New()
        _Placa = String.Empty
        _GPS = False
        _SeguroCompleto = False
        _SeguroBasico = False
        _CantPasajeros = 0
        _TarifaDiaria = 0
        _CantDias = 0
        _NumeroPasaporte = String.Empty
    End Sub
    ''' <summary>
    ''' Recibe todos los datos
    ''' </summary>
    ''' <param name=pPlaca> Placa del carro </param>
    ''' <param name=pGPS> Si Posee GPS o no</param> 
    ''' <param name=pSeguroCompleto> Si posee seguro completo o no</param>
    ''' <param name=pSeguroBasico>Si posee seguro básico o no</param>
    ''' <param name=pCantPasajeros> La Cantidad de pasajeros del carro</param>
    ''' <param name=pTarifaDiaria>La tarifa diaria del vehíuclo</param>
    ''' <param name=pCantDias>La cantidad de días que lo va a dejar en el taller</param>
    ''' <param name=pNumPasaporte> El numero de pasaporte del dueño</param>


    Public Sub New(ByVal pPlaca As String, ByVal pGPS As Boolean, ByVal pSeguroCompleto As Boolean,
                   ByVal pSeguroBasico As Boolean, ByVal pCantPasajeros As Integer, ByVal pTarifaDiaria As Double,
                   ByVal pCantDias As Double, ByVal pNumPasaporte As String)
        _Placa = pPlaca
        _GPS = pGPS
        _SeguroCompleto = pSeguroCompleto
        _SeguroBasico = pSeguroBasico
        _CantPasajeros = pCantPasajeros
        _TarifaDiaria = pTarifaDiaria
        _CantDias = pCantDias
        _NumeroPasaporte = pNumPasaporte



    End Sub

#Region "Propiedades"


    ''' <summary>
    ''' Numero de Placa
    ''' </summary>
    ''' <returns>Numero de Placa</returns>
    Public Property Placa As String
        Set(value As String)
            _Placa = value
        End Set
        Get
            Return _Placa
        End Get
    End Property
    ''' <summary>
    ''' Si quiere GPS
    ''' </summary>
    ''' <returns>GPS</returns>
    Public Property GPS As Boolean
        Set(value As Boolean)
            _GPS = value
        End Set
        Get
            Return _GPS
        End Get
    End Property
    ''' <summary>
    ''' Si tiene seguro Completo
    ''' </summary>
    ''' <returns>Seguro Completo</returns>
    Public Property SeguroCompleto As Boolean
        Set(value As Boolean)
            _SeguroCompleto = value
        End Set
        Get
            Return _SeguroCompleto
        End Get
    End Property
    ''' <summary>
    ''' Si tiene seguro básico
    ''' </summary>
    ''' <returns>SeguroBasico</returns>
    Public Property SeguroBasico As Boolean
        Set(value As Boolean)
            _SeguroBasico = value
        End Set
        Get
            Return _SeguroBasico
        End Get
    End Property
    ''' <summary>
    ''' Indica la cantidad de pasajeros
    ''' </summary>
    ''' <returns>Cantidad de Pasajeros</returns>
    Public Property CantPasajeros As Integer
        Set(value As Integer)
            _CantPasajeros = value
        End Set
        Get
            Return _CantPasajeros
        End Get
    End Property
    ''' <summary>
    ''' Indica la Tarifa Diaria
    ''' </summary>
    ''' <returns>Tarifa Diaria</returns>
    Public Property TarifaDiaria As Double
        Set(value As Double)
            _TarifaDiaria = value
        End Set
        Get
            Return _TarifaDiaria
        End Get
    End Property
    ''' <summary>
    ''' Indica la Cantidad de Dias
    ''' </summary>
    ''' <returns>Cantidad de Dias</returns>
    Public Property CantDias As Double
        Set(value As Double)
            _CantDias = value
        End Set
        Get
            Return _CantDias
        End Get
    End Property
    ''' <summary>
    ''' Indica el numero de pasaporte del cliente
    ''' </summary>
    ''' <returns>Numero de Pasaporte</returns>
    Public Property NumPasaporte As String
        Set(value As String)
            _NumeroPasaporte = value
        End Set
        Get
            Return _NumeroPasaporte
        End Get
    End Property

#End Region
#Region "Métodos"
    ''' <summary>
    ''' Calcula el Costo del GPS por dia
    ''' </summary>
    ''' <returns>Costo GPS</returns>
#End Region
    Function CostoGPS() As Double
        Try
            If _GPS Then
                Return CantDias * 4500
            Else
                Return 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Function
    ''' <summary>
    ''' Calcula el monto de Alquiler
    ''' </summary>
    ''' <returns>Monto Alquiler</returns>
    Function MontoAlquiler() As Double
        Try
            Return _TarifaDiaria * _CantDias
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Function
    ''' <summary>
    ''' Clacula la tarifa de Descuento por la Capacidad
    ''' </summary>
    ''' <returns> Monto descuento por Capacidad</returns>
    Function MontoDescporCapacidad() As Double
        Try
            If _CantDias > 5 Then
                Select Case _CantPasajeros
                    Case 5
                        Return MontoAlquiler() * 0.04
                    Case 7
                        Return MontoAlquiler() * 0.08
                    Case 11
                        Return MontoAlquiler() * 0.15
                    Case Else
                        Return 0



                End Select
            End If
            Return 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' Calcula el monto por Seguro
    ''' </summary>
    ''' <returns>Monto Seguro</returns>
    Function MontoSeguro() As Double
        Try
            If _SeguroCompleto Then
                Return MontoAlquiler() * 0.15
            ElseIf _SeguroBasico Then
                Return MontoAlquiler() * 0.08
            End If
            Return 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Function
    Function Total() As Double
        Try
            Dim dblTotal As Double = 0
            dblTotal = CostoGPS() + MontoAlquiler() + MontoSeguro() - MontoDescporCapacidad()
            Return dblTotal
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' Este es el metodo toString que devuelve todos los datos
    ''' </summary>
    ''' <returns>Todos los datos en String</returns>
    Function toString() As String


        Dim strDatos As String
        Dim strGPs As String

        Dim strSeguroCompleto As String
        If _GPS Then
            strGPs = "GPS: Si"
        Else
            strGPs = "GPS: No"
        End If


        If _SeguroCompleto Then
            strSeguroCompleto = "Completo"
        Else
            strSeguroCompleto = "Básico"
        End If
        strDatos = " Numero de Placa: " & _Placa & vbCrLf &
            "GPS: " & strGPs & vbCrLf &
            "Seguro: " & strSeguroCompleto & vbCrLf &
            "Cantidad de Pasajeros: " & _CantPasajeros & vbCrLf &
            "Tarifa Diaria: " & _TarifaDiaria.ToString & vbCrLf &
            "Cantidad de Días: " & _CantDias & vbCrLf &
            "Numero de Pasaporte: " & _NumeroPasaporte & vbCrLf &
            "Costo GPS: " & CostoGPS().ToString & vbCrLf &
            "Monto por Alquiler: " & MontoAlquiler().ToString & vbCrLf &
            "Monto Descuento por Capacidad: " & MontoDescporCapacidad().ToString & vbCrLf &
            "Monto por Seguro: " & MontoSeguro().ToString & vbCrLf &
            "Total: " & Total().ToString & vbCrLf


        Return strDatos

    End Function
#End Region
End Class
