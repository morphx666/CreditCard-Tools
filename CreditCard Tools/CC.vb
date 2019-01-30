Imports System.Reflection

' http://www.freeformatter.com/credit-card-number-generator-validator.html
' http://www.stevemorse.org/ssn/List_of_Bank_Identification_Numbers.html#Petroleum_and_other_future_industry_assignments_.287.2A.2A.2A.2A.2A.29
' https://web.eecs.umich.edu/~bartlett/credit_card_number.html

' FIXME: Only 16 digit long numbers are supported

Public Class CC
    Public Enum MajorIndustryIdentifiers
        <Range()> <Description("Invalid")> Invalid
        <Range("0")> <Description("ISO/TC 68 and other industry assignments")> ISO_TC68
        <Range("1")> <Description("Airlines")> Airlines1
        <Range("2")> <Description("Airlines, financial and other future industry assignments")> Airlines2
        <Range("3")> <Description("Travel and entertainment")> TravelAndEntertainment
        <Range("4-5")> <Description("Banking and financial")> BankingAndFinancial
        <Range("6")> <Description("Merchandising and banking/financial")> MerchandizingAndBanking
        <Range("7")> <Description("Petroleum and other future industry assignments")> Petroleum
        <Range("8")> <Description("Healthcare, telecommunications and other future industry assignments")> Telecommunications
        <Range("9")> <Description("For assignment by national standards bodies")> NationalAssignment
    End Enum

    Public Enum IssuerIdentificationNumbers
        <Range()> Invalid
        <Range("34, 37")> AmericanExpress
        <Range("5610, 560221-560225")> Bankcard
        <Range("62")> ChinaUnionPay
        <Range("300-305")> DinersClubCarteBlanche
        <Range("2014, 2149")> DinersClubEnRoute
        <Range("36")> DinersClubInternational
        <Range("54, 55")> DinersClubUnitedStatesAndCanada
        <Range("6011, 622126-622925, 644-649, 65")> DiscoverCard
        <Range("637-639")> InstaPayment
        <Range("3528-3589")> JCB
        <Range("6304, 6706, 6771, 6709")> Laser
        <Range("5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763, 0604")> Maestro
        <Range("51-55")> MasterCard
        <Range("6334, 6767")> Solo
        <Range("4903, 4905, 4911, 4936, 564182, 633110, 6333, 6759")> Switch
        <Range("4")> Visa
        <Range("4026, 417500, 4405, 4508, 4844, 4913, 4917")> VisaElectron
        <Range("700007")> FPSolutions
        <Range("7001**, 7021**")> BestBuy
        <Range("700247")> PriorityPassPassengerCard
        <Range("700676")> BPPlusUK
        <Range("7034**")> ShellAU
        <Range("7050**, 7052**")> BPCard
        <Range("705505")> euroShellUK
        <Range("7061**")> ChevronTexaco
        <Range("706405")> Esso
        <Range("7069**")> PretroCanada
        <Range("707134, 7076**")> CaltexAustraliaPetroleum
        <Range("708141")> DeutscheBahnBahnCard
        <Range("708224")> UKFuels
        <Range("708251")> TexacoFastFuels
        <Range("708326")> AgipHungary
        <Range("766668")> Shell
        <Range("778900")> PerekrestokX5Club
        <Range("788536")> CompacCard
    End Enum

    Private mNumber As String
    Private mMII As MajorIndustryIdentifiers = MajorIndustryIdentifiers.Invalid
    Private mIIN As IssuerIdentificationNumbers = IssuerIdentificationNumbers.Invalid
    Private mAccount As String
    Private mIsValid As Boolean

    Public Sub New()
    End Sub

    Public Sub New(number As String)
        Me.Number = number
    End Sub

    Public Property Number As String
        Get
            Return mNumber
        End Get
        Set(value As String)
            mNumber = value
            Decode()
        End Set
    End Property

    Public ReadOnly Property Account As String
        Get
            Return mAccount
        End Get
    End Property

    Public ReadOnly Property MajorIndustryIdentifier As MajorIndustryIdentifiers
        Get
            Return mMII
        End Get
    End Property

    Public ReadOnly Property IssuerIdentificationNumber As IssuerIdentificationNumbers
        Get
            Return mIIN
        End Get
    End Property

    Public ReadOnly Property IsValid As Boolean
        Get
            Return mIsValid
        End Get
    End Property

    Private Sub Decode()
        mMII = MajorIndustryIdentifiers.Invalid
        mIIN = IssuerIdentificationNumbers.Invalid
        mAccount = ""
        mIsValid = False

        If mNumber.Length <> 16 Then Exit Sub

        Dim v As Integer

        v = Integer.Parse(mNumber.Substring(0, 1))
        Dim ev1 As MajorIndustryIdentifiers
        For Each mmi In [Enum].GetNames(GetType(MajorIndustryIdentifiers))
            If [Enum].TryParse(mmi, ev1) Then
                For Each r In Range.GetRanges(ev1)
                    If v >= r.Min AndAlso v <= r.Max Then
                        mMII = ev1
                        Exit For
                    End If
                Next
            End If
            If mMII <> MajorIndustryIdentifiers.Invalid Then Exit For
        Next

        Dim ev2 As IssuerIdentificationNumbers
        For Each iin In [Enum].GetNames(GetType(IssuerIdentificationNumbers))
            If [Enum].TryParse(iin, ev2) Then
                For Each r In Range.GetRanges(ev2)
                    Dim ml = Math.Max(r.Min.ToString().Length, r.Max.ToString().Length)
                    v = Integer.Parse(mNumber.Substring(0, ml))

                    If v >= r.Min AndAlso v <= r.Max Then
                        mIIN = ev2
                        Exit For
                    End If
                Next
            End If
            If mIIN <> IssuerIdentificationNumbers.Invalid Then Exit For
        Next

        mAccount = mNumber.Substring(6, 9)

        mIsValid = (CalculateChecksum(mNumber) Mod 10 = 0) AndAlso
                    mMII <> MajorIndustryIdentifiers.Invalid AndAlso
                    mIIN <> IssuerIdentificationNumbers.Invalid
    End Sub

    ' Luhn algorithm
    Private Function CalculateChecksum(value As String) As Integer
        Dim checkSum As Integer = 0
        Dim n As Integer
        For i As Integer = 0 To value.Length - 1
            n = Integer.Parse(value.Substring(i, 1))
            If i Mod 2 = 0 Then n *= 2
            If n > 9 Then
                Dim ip As Integer = Math.Floor(n / 10)
                Dim fp As Integer = n - ip * 10
                n = ip + fp
            End If
            checkSum = checkSum + n
        Next

        Return checkSum
    End Function

    Public Function Encode(mii As MajorIndustryIdentifiers, iin As IssuerIdentificationNumbers) As CC
        Dim triesCount As Integer

        If mii = MajorIndustryIdentifiers.Invalid OrElse iin = IssuerIdentificationNumbers.Invalid Then Return Nothing

        Do
            Dim miiValues As New List(Of Integer)
            Dim iinValues As New List(Of Integer)
            Dim ccNumber As String = ""
            Dim rand As New Random()

            'Dim ev1 As MajorIndustryIdentifiers
            For Each r In Range.GetRanges(mii)
                For i As Integer = r.Min To r.Max
                    miiValues.Add(i)
                Next
            Next

            'Dim ev2 As MajorIndustryIdentifiers
            For Each r In Range.GetRanges(iin)
                For i As Integer = r.Min To r.Max
                    For Each miiValue In miiValues
                        If i.ToString().StartsWith(miiValue.ToString()) Then
                            iinValues.Add(i)
                        End If
                    Next
                Next
            Next

            If iinValues.Count > 0 Then
                ' First Digits
                ccNumber = iinValues(rand.Next(iinValues.Count - 1))
                Dim l = ccNumber.Length
                ' Padding
                If l < 6 Then ccNumber += rand.Next(10 ^ (6 - l) - 1).ToString().PadLeft((6 - l), "0")
                ' Account Number
                ccNumber += rand.Next(10 ^ 9 - 1).ToString().PadLeft(9, "0")

                For i As Integer = 0 To 9
                    If CalculateChecksum(ccNumber + i.ToString()) Mod 10 = 0 Then
                        ccNumber += i.ToString()
                        Exit For
                    End If
                Next

                If ccNumber.Length = 16 Then
                    Return New CC(ccNumber)
                Else
                    triesCount += 1
                    If triesCount > 100 Then Return Nothing
                End If
            Else
                Return Nothing
            End If
        Loop
    End Function
End Class

<AttributeUsage(AttributeTargets.Field, Inherited:=True)>
Public Class Description
    Inherits Attribute

    Public ReadOnly Property Description As String

    Public Sub New(description As String)
        Me.Description = description
    End Sub

    Public Shared Function GetDescription(value As [Enum]) As String
        Dim attr As Description = Nothing
        Dim memberInfo As MemberInfo = value.GetType().GetMember(value.ToString()).FirstOrDefault()
        If memberInfo IsNot Nothing Then attr = CType(memberInfo.GetCustomAttributes(GetType(Description), False).FirstOrDefault(), Description)

        If attr Is Nothing Then
            Return Nothing
        Else
            Return attr.Description
        End If
    End Function
End Class

<AttributeUsage(AttributeTargets.Field, Inherited:=True)>
Public Class Range
    Inherits Attribute

    Public Class ValueRange
        Public ReadOnly Property Min As Integer
        Public ReadOnly Property Max As Integer

        Public Sub New(min As Integer, max As Integer)
            Me.Min = min
            Me.Max = max
        End Sub

        Public Sub New(min As String, max As String)
            Me.Min = Integer.Parse(min.Replace("*", "0"))
            Me.Max = Integer.Parse(max.Replace("*", "0"))
        End Sub

        Public Sub New(uniqueValue As String)
            Min = Integer.Parse(uniqueValue.Replace("*", "0"))
            Max = Integer.Parse(uniqueValue.Replace("*", "9"))
        End Sub
    End Class

    Public ReadOnly Property Ranges As New List(Of ValueRange)

    Public Sub New()
    End Sub

    Public Sub New(ranges As String)
        For Each token In ranges.Split(",")
            If token.Contains("-") Then
                Dim values() As String = token.Split("-")
                Me.Ranges.Add(New ValueRange(values(0), values(1)))
            Else
                Me.Ranges.Add(New ValueRange(token))
            End If
        Next
    End Sub

    Public ReadOnly Property HasRange As Boolean
        Get
            Return Ranges.Any()
        End Get
    End Property

    Public Shared Function GetRanges(value As [Enum]) As List(Of ValueRange)
        Dim attr As Range = Nothing
        Dim memberInfo As MemberInfo = value.GetType().GetMember(value.ToString()).FirstOrDefault()
        If memberInfo IsNot Nothing Then attr = CType(memberInfo.GetCustomAttributes(GetType(Range), False).FirstOrDefault(), Range)

        If attr Is Nothing Then
            Return Nothing
        Else
            Return attr.Ranges
        End If
    End Function
End Class

Module Extensions
    <Runtime.CompilerServices.Extension()>
    Public Function Prettify(value As String) As String
        Dim r As String = ""

        For Each c In value
            If r <> "" AndAlso Char.IsUpper(c) Then r += " "
            r += c
        Next

        Return r
    End Function
End Module