Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Script.Serialization

Public Class DataHelper
    Private Const GridItemsKey As String = "GridItemsKey"
    Private Const SparklineItemsKey As String = "SparklineItemsKey"

    Public Shared ReadOnly Property GridItems() As List(Of YearInfo)
        Get
            If HttpContext.Current.Session(GridItemsKey) Is Nothing Then
                HttpContext.Current.Session(GridItemsKey) = GenerateGridItems()
            End If
            Return DirectCast(HttpContext.Current.Session(GridItemsKey), List(Of YearInfo))
        End Get
    End Property
    Public Shared ReadOnly Property SparklineItems() As List(Of OilCostInfo)
        Get
            If HttpContext.Current.Session(SparklineItemsKey) Is Nothing Then
                HttpContext.Current.Session(SparklineItemsKey) = GenerateSparklineItems()
            End If
            Return DirectCast(HttpContext.Current.Session(SparklineItemsKey), List(Of OilCostInfo))
        End Get
    End Property
    Public Shared Function GetSparklineItemsByYear(ByVal year As Integer) As IEnumerable
        Return From item In SparklineItems _
               Where item.Year = year _
               Select item
    End Function
    Private Shared Function GenerateGridItems() As List(Of YearInfo)
        Return New List(Of YearInfo) From { _
            New YearInfo() With {.Year = 2010}, _
            New YearInfo() With {.Year = 2011}, _
            New YearInfo() With {.Year = 2012} _
        }
    End Function
    Private Shared Function GenerateSparklineItems() As List(Of OilCostInfo)
        Return New List(Of OilCostInfo) From { _
            New OilCostInfo() With {.Year = 2010, .Month = 1, .Value = 77}, _
            New OilCostInfo() With {.Year = 2010, .Month = 2, .Value = 72}, _
            New OilCostInfo() With {.Year = 2010, .Month = 3, .Value = 79}, _
            New OilCostInfo() With {.Year = 2010, .Month = 4, .Value = 82}, _
            New OilCostInfo() With {.Year = 2010, .Month = 5, .Value = 86}, _
            New OilCostInfo() With {.Year = 2010, .Month = 6, .Value = 73}, _
            New OilCostInfo() With {.Year = 2010, .Month = 7, .Value = 73}, _
            New OilCostInfo() With {.Year = 2010, .Month = 8, .Value = 77}, _
            New OilCostInfo() With {.Year = 2010, .Month = 9, .Value = 76}, _
            New OilCostInfo() With {.Year = 2010, .Month = 10, .Value = 81}, _
            New OilCostInfo() With {.Year = 2010, .Month = 11, .Value = 83}, _
            New OilCostInfo() With {.Year = 2010, .Month = 12, .Value = 89}, _
            New OilCostInfo() With {.Year = 2011, .Month = 1, .Value = 93}, _
            New OilCostInfo() With {.Year = 2011, .Month = 2, .Value = 101}, _
            New OilCostInfo() With {.Year = 2011, .Month = 3, .Value = 115}, _
            New OilCostInfo() With {.Year = 2011, .Month = 4, .Value = 116}, _
            New OilCostInfo() With {.Year = 2011, .Month = 5, .Value = 124}, _
            New OilCostInfo() With {.Year = 2011, .Month = 6, .Value = 115}, _
            New OilCostInfo() With {.Year = 2011, .Month = 7, .Value = 110}, _
            New OilCostInfo() With {.Year = 2011, .Month = 8, .Value = 117}, _
            New OilCostInfo() With {.Year = 2011, .Month = 9, .Value = 113}, _
            New OilCostInfo() With {.Year = 2011, .Month = 10, .Value = 103}, _
            New OilCostInfo() With {.Year = 2011, .Month = 11, .Value = 110}, _
            New OilCostInfo() With {.Year = 2011, .Month = 12, .Value = 109}, _
            New OilCostInfo() With {.Year = 2012, .Month = 1, .Value = 107}, _
            New OilCostInfo() With {.Year = 2012, .Month = 2, .Value = 112}, _
            New OilCostInfo() With {.Year = 2012, .Month = 3, .Value = 123}, _
            New OilCostInfo() With {.Year = 2012, .Month = 4, .Value = 123}, _
            New OilCostInfo() With {.Year = 2012, .Month = 5, .Value = 116}, _
            New OilCostInfo() With {.Year = 2012, .Month = 6, .Value = 102}, _
            New OilCostInfo() With {.Year = 2012, .Month = 7, .Value = 94}, _
            New OilCostInfo() With {.Year = 2012, .Month = 8, .Value = 105}, _
            New OilCostInfo() With {.Year = 2012, .Month = 9, .Value = 113}, _
            New OilCostInfo() With {.Year = 2012, .Month = 10, .Value = 111}, _
            New OilCostInfo() With {.Year = 2012, .Month = 11, .Value = 107}, _
            New OilCostInfo() With {.Year = 2012, .Month = 12, .Value = 110} _
        }
    End Function
End Class
Public Class YearInfo
    Public Property Year() As Integer
End Class
Public Class OilCostInfo
    <ScriptIgnore> _
    Public Property Year() As Integer
    Public Property Month() As Integer
    Public Property Value() As Integer
End Class