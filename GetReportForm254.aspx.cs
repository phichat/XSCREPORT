using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XSCREPORT.Models;

namespace XSCREPORT
{
    public partial class GetReportForm254 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    string requestFromPost = "";
                    using (StreamReader reader = new StreamReader(HttpContext.Current.Request.InputStream))
                    {
                        requestFromPost = reader.ReadToEnd();
                    }

                    if (requestFromPost.Trim() != "")
                    {
                        var js = JsonConvert.DeserializeObject<ArrestgetByConmodel>(requestFromPost);
                        if (js != null)
                        {
                            if (js.ArrestCode.Trim() != "")
                            {
                                DataSet dtt = new OperModels().ArrestgetByCon(js);
                                ReportDocument rpt = new ReportDocument();

                                rpt.Load(Server.MapPath("~/ReportModels/ILL_P030.rpt"));

                                rpt.SetDataSource(dtt);
                                CrystalReportViewer1.ReportSource = rpt;
                                rpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "ILL_P030");

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}