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
    public partial class ArrestgetByCon : System.Web.UI.Page
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
                        //var js = new ArrestgetByConmodel();
                        //js.ArrestCode = Request.Form["ArrestCode"].ToString();
                        if (js != null)
                        {
                            if (js.ArrestCode.Trim() != "")
                            {
                                DataSet dtt = new OperModels().ArrestgetByCon(js);
                                ReportDocument rpt = new ReportDocument();
                                //CrystalReport1 rpt = new CrystalReport1();
                                
                                rpt.Load(Server.MapPath("~/ReportModels/ILL2010_60.rpt"));
                                
                                rpt.SetDataSource(dtt);

                                //rpt.SetDataSource(dtt.Tables[1]);
                                //rpt.SetDataSource(dtt.Tables[1]);
                                //rpt.Database.Tables["ArrestgetByCon"].SetDataSource(dtt.Tables[0]);
                                //rpt.Database.Tables["ArrestgetByCon2"].SetDataSource(dtt.Tables[1]);

                                CrystalReportViewer1.ReportSource = rpt;
                                //rpt.ExportToDisk(ExportFormatType.PortableDocFormat, Server.MapPath("~/FTP/BiWeeklyReport.pdf"));
                                //Response.ContentType = "Application/pdf";
                                //Response.AppendHeader("Content-Disposition", "attachment; filename=File1.pdf");
                                //Response.TransmitFile(Server.MapPath("../ReportModels/ILL2010_60.rpt"));
                                //Response.Flush();
                                //HttpContext.Current.ApplicationInstance.CompleteRequest();
                                //CrystalReportViewer1.ReportSource = rpt;
                                //CrystalReportViewer1.RefreshReport();
                                rpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "ILL2010_60");
                                //var s = rpt.ExportToStream(ExportFormatType.PortableDocFormat);
                                //byte[] b = new byte[s.Length];
                                //s.Read(b,0,int.Parse(s.Length.ToString()));
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
                    }
                }
            }
            catch(Exception ex)
            {
                return;
            }
            
        }
    }
}