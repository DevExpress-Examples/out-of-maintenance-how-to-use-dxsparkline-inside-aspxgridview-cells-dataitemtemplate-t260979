<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-2.1.4.min.js"></script>
    <script src="Scripts/knockout-3.3.0.js"></script>
    <script src="Scripts/globalize.min.js"></script>
    <script src="Scripts/dx.chartjs.js"></script>
    <script type="text/javascript">
        var BaseSparklineOptions = {
            argumentField: 'Month',
            valueField: 'Value',
            type: 'line',
            showMinMax: true
        };
        function OnInit(s, e) {
            InitWidgets();
        }
        function OnEndCallback(s, e) {
            InitWidgets();
        }
        function InitWidgets() {
            $('.elementClassToSelect').each(function () {
                var containerSelector = $(this);
                containerSelector.dxSparkline(
                    $.extend(BaseSparklineOptions, {
                        dataSource: $.parseJSON(containerSelector.attr("data"))
                    })
                );
                //containerSelector.removeAttr("data");
            });
        }
    </script>
</head>
<body>
    <form id="frm" runat="server">
        <dx:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" KeyFieldName="Year" OnDataBinding="grid_DataBinding">
            <Columns>
                <dx:GridViewDataTextColumn FieldName="Year">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataColumn Caption="Oil (USD/barrel)">
                    <DataItemTemplate>
                        <div id="sparklineContainer" runat="server" oninit="sparklineContainer_Init"
                            class="elementClassToSelect"
                            style="height: 50px; width: 200px">
                        </div>
                    </DataItemTemplate>
                </dx:GridViewDataColumn>
            </Columns>
            <ClientSideEvents Init="OnInit" EndCallback="OnEndCallback" />
        </dx:ASPxGridView>
    </form>
</body>
</html>