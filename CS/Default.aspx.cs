using System;
using System.Web.Script.Serialization;
using System.Web.UI.HtmlControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsCallback && !IsPostBack)
            grid.DataBind();
    }
    protected void grid_DataBinding(object sender, EventArgs e) {
        grid.DataSource = DataHelper.GridItems;
    }
    protected void sparklineContainer_Init(object sender, EventArgs e) {
        HtmlGenericControl sparklineContainer = (HtmlGenericControl)sender;
        GridViewDataItemTemplateContainer templateContainer = (GridViewDataItemTemplateContainer)sparklineContainer.NamingContainer;
        sparklineContainer.Attributes["data"] = new JavaScriptSerializer().Serialize(DataHelper.GetSparklineItemsByYear((int)templateContainer.KeyValue));
    }
}