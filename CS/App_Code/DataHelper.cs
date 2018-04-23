using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

public class DataHelper {
    const string GridItemsKey = "GridItemsKey";
    const string SparklineItemsKey = "SparklineItemsKey";

    public static List<YearInfo> GridItems {
        get {
            if(HttpContext.Current.Session[GridItemsKey] == null)
                HttpContext.Current.Session[GridItemsKey] = GenerateGridItems();
            return (List<YearInfo>)HttpContext.Current.Session[GridItemsKey];
        }
    }
    public static List<OilCostInfo> SparklineItems {
        get {
            if(HttpContext.Current.Session[SparklineItemsKey] == null)
                HttpContext.Current.Session[SparklineItemsKey] = GenerateSparklineItems();
            return (List<OilCostInfo>)HttpContext.Current.Session[SparklineItemsKey];
        }
    }
    public static IEnumerable GetSparklineItemsByYear(int year) {
        return from item in SparklineItems where item.Year == year select item;
    }
    private static List<YearInfo> GenerateGridItems() {
        return new List<YearInfo> {
            new YearInfo() { Year = 2010 },
            new YearInfo() { Year = 2011 },
            new YearInfo() { Year = 2012 },
        };
    }
    private static List<OilCostInfo> GenerateSparklineItems() {
        return new List<OilCostInfo> {
            new OilCostInfo() { Year = 2010, Month = 1, Value = 77 },
            new OilCostInfo() { Year = 2010, Month = 2, Value = 72 },
            new OilCostInfo() { Year = 2010, Month = 3, Value = 79 },
            new OilCostInfo() { Year = 2010, Month = 4, Value = 82 },
            new OilCostInfo() { Year = 2010, Month = 5, Value = 86 },
            new OilCostInfo() { Year = 2010, Month = 6, Value = 73 },
            new OilCostInfo() { Year = 2010, Month = 7, Value = 73 },
            new OilCostInfo() { Year = 2010, Month = 8, Value = 77 },
            new OilCostInfo() { Year = 2010, Month = 9, Value = 76 },
            new OilCostInfo() { Year = 2010, Month = 10, Value = 81 },
            new OilCostInfo() { Year = 2010, Month = 11, Value = 83 },
            new OilCostInfo() { Year = 2010, Month = 12, Value = 89 },

            new OilCostInfo() { Year = 2011, Month = 1, Value = 93 },
            new OilCostInfo() { Year = 2011, Month = 2, Value = 101 },
            new OilCostInfo() { Year = 2011, Month = 3, Value = 115 },
            new OilCostInfo() { Year = 2011, Month = 4, Value = 116 },
            new OilCostInfo() { Year = 2011, Month = 5, Value = 124 },
            new OilCostInfo() { Year = 2011, Month = 6, Value = 115 },
            new OilCostInfo() { Year = 2011, Month = 7, Value = 110 },
            new OilCostInfo() { Year = 2011, Month = 8, Value = 117 },
            new OilCostInfo() { Year = 2011, Month = 9, Value = 113 },
            new OilCostInfo() { Year = 2011, Month = 10, Value = 103 },
            new OilCostInfo() { Year = 2011, Month = 11, Value = 110 },
            new OilCostInfo() { Year = 2011, Month = 12, Value = 109 },

            new OilCostInfo() { Year = 2012, Month = 1, Value = 107 },
            new OilCostInfo() { Year = 2012, Month = 2, Value = 112 },
            new OilCostInfo() { Year = 2012, Month = 3, Value = 123 },
            new OilCostInfo() { Year = 2012, Month = 4, Value = 123 },
            new OilCostInfo() { Year = 2012, Month = 5, Value = 116 },
            new OilCostInfo() { Year = 2012, Month = 6, Value = 102 },
            new OilCostInfo() { Year = 2012, Month = 7, Value = 94 },
            new OilCostInfo() { Year = 2012, Month = 8, Value = 105 },
            new OilCostInfo() { Year = 2012, Month = 9, Value = 113 },
            new OilCostInfo() { Year = 2012, Month = 10, Value = 111 },
            new OilCostInfo() { Year = 2012, Month = 11, Value = 107 },
            new OilCostInfo() { Year = 2012, Month = 12, Value = 110 }
        };
    }
}
public class YearInfo {
    public int Year { get; set; }
}
public class OilCostInfo {
    [ScriptIgnore]
    public int Year { get; set; }
    public int Month { get; set; }
    public int Value { get; set; }
}