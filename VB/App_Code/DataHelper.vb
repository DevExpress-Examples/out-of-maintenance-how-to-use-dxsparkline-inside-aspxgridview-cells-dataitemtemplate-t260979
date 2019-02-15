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
            New OilCostInfo() With { _
                .Year = 2010, _
                .Month = 1, _
                .Value = 77 _
            }, _
            New OilCostInfo() With { _
                .Year = 2010, _
                .Month = 2, _
                .Value = 72 _
            }, _
            New OilCostInfo() With { _
                .Year = 2010, _
                .Month = 3, _
                .Value = 79 _
            }, _
            New OilCostInfo() With { _
                .Year = 2010, _
                .Month = 4, _
                .Value = 82 _
            }, _
            New OilCostInfo() With { _
                .Year = 2010, _
                .Month = 5, _
                .Value = 86 _
            }, _
            New OilCostInfo() With { _
                .Year = 2010, _
                .Month = 6, _
                .Value = 73 _
            }, _
            New OilCostInfo() With { _
                .Year = 2010, _
                .Month = 7, _
                .Value = 73 _
            }, _
            New OilCostInfo() With { _
                .Year = 2010, _
                .Month = 8, _
                .Value = 77 _
            }, _
            New OilCostInfo() With { _
                .Year = 2010, _
                .Month = 9, _
                .Value = 76 _
            }, _
            New OilCostInfo() With { _
                .Year = 2010, _
                .Month = 10, _
                .Value = 81 _
            }, _
            New OilCostInfo() With { _
                .Year = 2010, _
                .Month = 11, _
                .Value = 83 _
            }, _
            New OilCostInfo() With { _
                .Year = 2010, _
                .Month = 12, _
                .Value = 89 _
            }, _
            New OilCostInfo() With { _
                .Year = 2011, _
                .Month = 1, _
                .Value = 93 _
            }, _
            New OilCostInfo() With { _
                .Year = 2011, _
                .Month = 2, _
                .Value = 101 _
            }, _
            New OilCostInfo() With { _
                .Year = 2011, _
                .Month = 3, _
                .Value = 115 _
            }, _
            New OilCostInfo() With { _
                .Year = 2011, _
                .Month = 4, _
                .Value = 116 _
            }, _
            New OilCostInfo() With { _
                .Year = 2011, _
                .Month = 5, _
                .Value = 124 _
            }, _
            New OilCostInfo() With { _
                .Year = 2011, _
                .Month = 6, _
                .Value = 115 _
            }, _
            New OilCostInfo() With { _
                .Year = 2011, _
                .Month = 7, _
                .Value = 110 _
            }, _
            New OilCostInfo() With { _
                .Year = 2011, _
                .Month = 8, _
                .Value = 117 _
            }, _
            New OilCostInfo() With { _
                .Year = 2011, _
                .Month = 9, _
                .Value = 113 _
            }, _
            New OilCostInfo() With { _
                .Year = 2011, _
                .Month = 10, _
                .Value = 103 _
            }, _
            New OilCostInfo() With { _
                .Year = 2011, _
                .Month = 11, _
                .Value = 110 _
            }, _
            New OilCostInfo() With { _
                .Year = 2011, _
                .Month = 12, _
                .Value = 109 _
            }, _
            New OilCostInfo() With { _
                .Year = 2012, _
                .Month = 1, _
                .Value = 107 _
            }, _
            New OilCostInfo() With { _
                .Year = 2012, _
                .Month = 2, _
                .Value = 112 _
            }, _
            New OilCostInfo() With { _
                .Year = 2012, _
                .Month = 3, _
                .Value = 123 _
            }, _
            New OilCostInfo() With { _
                .Year = 2012, _
                .Month = 4, _
                .Value = 123 _
            }, _
            New OilCostInfo() With { _
                .Year = 2012, _
                .Month = 5, _
                .Value = 116 _
            }, _
            New OilCostInfo() With { _
                .Year = 2012, _
                .Month = 6, _
                .Value = 102 _
            }, _
            New OilCostInfo() With { _
                .Year = 2012, _
                .Month = 7, _
                .Value = 94 _
            }, _
            New OilCostInfo() With { _
                .Year = 2012, _
                .Month = 8, _
                .Value = 105 _
            }, _
            New OilCostInfo() With { _
                .Year = 2012, _
                .Month = 9, _
                .Value = 113 _
            }, _
            New OilCostInfo() With { _
                .Year = 2012, _
                .Month = 10, _
                .Value = 111 _
            }, _
            New OilCostInfo() With { _
                .Year = 2012, _
                .Month = 11, _
                .Value = 107 _
            }, _
            New OilCostInfo() With { _
                .Year = 2012, _
                .Month = 12, _
                .Value = 110 _
            } _
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