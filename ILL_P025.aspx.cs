using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XSCREPORT.Models;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace XSCREPORT
{
    public partial class ILL_P025 : System.Web.UI.Page
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
                        //var res = new LawsuitArrestgetByConModels();
                        //res.IndictmentID = int.Parse(Request.Form["IndictmentID"]);
                        var js = JsonConvert.DeserializeObject<LawsuitArrestgetByConModels>(requestFromPost);
                        if (js.IndictmentID > 0)
                        {
                            DataTable dtt = new OperModels().Lawsuitgetbycon(js);
                            ReportDocument rpt = new ReportDocument();
                            rpt.Load(Server.MapPath("~/ReportModels/ILL_P025.rpt"));
                            rpt.SetDataSource(dtt);
                            CrystalReportViewer1.ReportSource = rpt;
                            rpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "ILL_P025");
                            //var s = rpt.ExportToStream(ExportFormatType.PortableDocFormat);
                            //byte[] b = new byte[s.Length];
                            //s.Read(b, 0, int.Parse(s.Length.ToString()));
                            //HttpContext.Current.Response.Clear();
                            //HttpContext.Current.Response.ClearHeaders();
                            //HttpContext.Current.Response.ContentType = "application/pdf";

                            //HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=ILL2010_60.pdf");
                            //HttpContext.Current.Response.BinaryWrite(b);
                            //HttpContext.Current.Response.Flush();
                            //HttpContext.Current.Response.SuppressContent = true;
                            //HttpContext.Current.ApplicationInstance.CompleteRequest();
                        }
                    }
                    //StreamReader reader = new StreamReader(HttpContext.Current.Request.InputStream);
                    //string requestFromPost = reader.ReadToEnd();



                }
            }
            catch
            {
                return;
            }
           
            

        

        }
    }
}