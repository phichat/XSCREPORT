using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XSCREPORT.Models;

namespace XSCREPORT
{
    public partial class LawsuitArrestgetByCon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    StreamReader reader = new StreamReader(HttpContext.Current.Request.InputStream);
                    string requestFromPost = reader.ReadToEnd();
                    if (requestFromPost != null)
                    {
                        var js = JsonConvert.DeserializeObject<LawsuitArrestgetByConModels>(requestFromPost);
                        if (js != null)
                        {
                            if (js.IndictmentID > 0)
                            {
                                DataTable dtt = new OperModels().Lawsuitgetbycon(js);
                                ReportDocument rpt = new ReportDocument();
                                rpt.Load(Server.MapPath("~/ReportModels/ILL_P025.rpt"));
                                rpt.SetDataSource(dtt);
                                this.CrystalReportViewer1.ReportSource = rpt;
                                //rpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "ILL_P025");
                                var s = rpt.ExportToStream(ExportFormatType.PortableDocFormat);
                                byte[] b = new byte[s.Length];
                                s.Read(b, 0, Convert.ToInt32(s.Length.ToString()));
                                s.Close();
                                //--------------------------------------------


                                Byte[] inArray = new Byte[(int)s.Length];
                                Char[] outArray = new Char[(int)(s.Length * 1.34)];
                                s.Read(inArray, 0, (int)s.Length);
                                Convert.ToBase64CharArray(inArray, 0, inArray.Length, outArray, 0);
                                //return new MemoryStream(Encoding.UTF8.GetBytes(outArray));

                                //---------------------------------------------
                                HttpContext.Current.Response.Clear();
                                HttpContext.Current.Response.ClearHeaders();
                                HttpContext.Current.Response.ContentType = "application/pdf";

                                HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=ILL_P025.pdf");
                                HttpContext.Current.Response.BinaryWrite(Encoding.UTF8.GetBytes(outArray));
                                HttpContext.Current.Response.Flush();
                                HttpContext.Current.Response.SuppressContent = true;
                                HttpContext.Current.ApplicationInstance.CompleteRequest();
                                HttpContext.Current.Response.End();
                            }
                        }
                    }
            }
                catch (Exception ex)
            {

            }

        }
        }
    }
}