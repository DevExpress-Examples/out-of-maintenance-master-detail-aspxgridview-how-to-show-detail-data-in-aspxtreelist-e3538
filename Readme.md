<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# Master-Detail ASPxGridView - How to show detail data in ASPxTreeList


<p>Sometimes, it is necessary to show hierarchical data inside a detail ASPxGridView row. ASPxTreeList can show hierarchical data, but it does not have a built-in capability to get a corresponding master row key value. </p><p>To get a grid master row key value, it is necessary to move up through a hierarchy of controls to find <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewBaseRowTemplateContainerMembersTopicAll"><u>GridViewBaseRowTemplateContainer</u></a> that has the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewBaseRowTemplateContainer_KeyValuetopic"><u>KeyValue</u></a> property. </p>

```cs
 protected object GetMasterRowKeyValue(ASPxTreeList treeList) {<newline/>
       GridViewBaseRowTemplateContainer container = null;<newline/>
       Control control = treeList;<newline/>
       while(control.Parent != null) {<newline/>
           container = control.Parent as GridViewBaseRowTemplateContainer;<newline/>
           if(container != null) break;<newline/>
           control = control.Parent;<newline/>
       }<newline/>
       return container.KeyValue;<newline/>
   }<newline/>

```

<p>This is a universal solution and it can be applied to any of ASP.NET control held in a grid template.</p><p><strong>See a</strong><strong>l</strong><strong>s</strong><strong>o:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E3604">How to use different components to display details of a master-detail ASPxGridView </a></p>

<br/>


