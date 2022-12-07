using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web;
using DevExpress.Web.ASPxTreeList;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected object GetMasterRowKeyValue(ASPxTreeList treeList) {
        GridViewBaseRowTemplateContainer container = null;
        Control control = treeList;
        while(control.Parent != null) {
            container = control.Parent as GridViewBaseRowTemplateContainer;
            if(container != null) break;
            control = control.Parent;
        }
        return container.KeyValue;
    }

    protected void ASPxTreeList1_Init(object sender, EventArgs e) {
        ASPxTreeList treeList = sender as ASPxTreeList;
        object keyValue = GetMasterRowKeyValue(treeList);
        treeList.RootValue = keyValue;
    }
}
