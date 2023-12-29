<!-- default file list -->
*Files to look at*:

* [DataHelper.cs](./CS/App_Code/DataHelper.cs) (VB: [DataHelper.vb](./VB/App_Code/DataHelper.vb))
* **[Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))**
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to use dxSparkline inside ASPxGridView Cells / DataItemTemplate


This example is based on <a href="https://js.devexpress.com/Demos/WidgetsGallery/Demo/Charts/SimpleSparklines/jQuery/Light/">this</a> demo.<br />It illustrates how to use the <a href="http://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/dxSparkline/">dxSparkline</a> Data Visualization Widget in ASPxGridView Cells / DataItemTemplate:<br />- Define a custom HTML element with the specified "class" (for example, "elementClassToSelect" in order to access it via a selector on the client) and runat=server (in order to access it on the server) attributes and specified dimensions inside the DataItemTemplate;<br />- Use the <a href="https://www.devexpress.com/Support/Center/p/K18282">K18282: The general technique of using the Init/Load event handler</a> approach and handle this HTML element's Init event;<br />- Specify element's attribute (for example, "data") with some data (for example, the related record's one). Use the standard System.Web.Script.Serialization.JavaScriptSerializer.Serialize method to create a JSON string from an IEnumerable source.<br />- Handle the ASPxClientGridView Init/EndCallback events and initialize the dxSparkline widget (see the <a href="https://www.devexpress.com/Support/Center/p/K18561">K18561: Using jQuery / jQuery UI libraries with DevExpress ASP.NET Controls / MVC Extensions</a> #3):<br />    - Select all targets to be transformed to dxSparkline via a class selector (according to the class attribute specified earlier);<br />    - Transform all targets to the dxSparkline widget:<br />        - Use the <a href="https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxSparkline/">base settings</a> for creating a dxSparkline widget;<br />        - Specify an individual "dataSource" property retrieved from the element's ("data") attribute;<br />        - Remove the ("data") attribute from the transformed element (if necessary).

<br/>


