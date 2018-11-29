<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TEST1.aspx.cs" Inherits="XSCREPORT.TEST1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<script type="text/javascript">
    function ReOpenScoreHome() {
        window.open("Form2.aspx", "reopenwindow");
    }
</script>--%>
    
    <%--function ReceiveTypeChange(ReceiveType) {
                var hdnCustValue = document.getElementById('<%=ArrestCode.Text%>');             
                
                if (ReceiveType == "1") {
                    var vOrgID = '<%=Config.GetLogOnUser.ORG_DATA.ID %>';                    
                    var pageUrl = '<%=ResolveUrl("~/Template/AjaxScript.asmx")%>';
                    $.ajax({
                        type: "POST",
                        url: pageUrl + "/GetCompanyNameByOrgID",
                        data: "{'OrgID':'" + vOrgID + "'}",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function(msg) {
                            var ret = msg.d;
                            hdnCustValue.value = ret[0];
                            txtCustName.value = ret[1];
                            txtCompanyRegisNo.value = ret[2];
                            
                            txtCustName.disabled = true;
                            txtCompanyRegisNo.disabled = true;
                        }
                    });
                } else {
                    hdnCustValue.value = "";
                    txtCustName.value = "";
                    txtCustName.disabled = false;
                    txtCompanyRegisNo.disabled = false;
                }
            }--%>
    
</head>
<body>
    <%--<body onload="ReOpenScoreHome()">--%>
    <form id="form1" runat="server" action="ILL_P025.aspx" method="post" >
        <div>
           <asp:TextBox ID="IndictmentID" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button"   />
          
        </div>
         
          
        
    </form>
    
       
</body>
</html>
