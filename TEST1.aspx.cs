using CrystalDecisions.CrystalReports.Engine;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using XSCREPORT.Models;

namespace XSCREPORT
{
    public class HHHH
    {
        public string user { get; set; }
        public string pass { get; set; }
    }
    public partial class TEST1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //GetRouteUrl("someaction", "somecontroller", new { id = "123" });
            //string URI = "http://localhost:57424/ILL_P025.aspx";
            //WebRequest req = WebRequest.Create("http://localhost:57424/ILL_P025.aspx");
            //string postData = "IndictmentID=" + IndictmentID.Text;

            //byte[] send = Encoding.Default.GetBytes(postData);
            //req.Method = "POST";
            //req.ContentType = "application/x-www-form-urlencoded";
            //req.ContentLength = send.Length;

            //Stream sout = req.GetRequestStream();
            //sout.Write(send, 0, send.Length);
            //sout.Flush();
            //sout.Close();

            //WebResponse res = req.GetResponse();
            //var popupScript = "<script language='javascript'>  PreviewReport('" + URI + "');  </script>";
            //    ScriptManager.RegisterStartupScript(frm, GetType(String), "PreviewReport", popupScript, False)
            //sout = res.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            //StreamReader reader = new StreamReader(sout);
            //// Read the content.  
            //string responseFromServer = reader.ReadToEnd();
            //reader.Close();
            //sout.Close();
            //res.Close();
            //StreamReader sr = new StreamReader(res.GetResponseStream());
            //string returnvalue = sr.ReadToEnd();


            //string URI = "http://localhost:57424/ILL_P025.aspx";
            //var data = IndictmentID.Text;
            //using (WebClient wc = new WebClient())
            //{

            //    string HtmlResult = wc.UploadString(URI, data);
            //    Response.Redirect("ArrestgetByCon.aspx");
            //    //var pdfPath = Server.MapPath("~\\FTP\\BiWeeklyReport.pdf");
            //    //WebClient client = new WebClient();
            //    //Byte[] buffer = client.DownloadData(pdfPath);
            //    //Response.ContentType = "application/pdf";
            //    //Response.AddHeader("content-length", buffer.Length.ToString());
            //    //Response.BinaryWrite(buffer);
            //    //var bytes = System.IO.File.ReadAllBytes(pdfPath);
            //    //System.IO.File.Delete(pdfPath);
            //}
            //string url2 = "webForm2.html";
            //using (WebClient wc = new WebClient())
            //{
            //    System.Collections.Specialized.NameValueCollection cc = new System.Collections.Specialized.NameValueCollection();
            //    cc.Add("{\"IndictmentID\"", "100");
            //    wc.UploadString(URI, data);
            //    ReportDocument rpt = new ReportDocument();
            //    rpt.Load(Server.MapPath("D:\\FTP\\BiWeeklyReport.rpt"));

            //}

            //var client = new RestClient("http://localhost:57424/ILL_P025.aspx");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Postman-Token", "d8a96776-c4e5-4afb-bfb9-9fbed27d4dcd");
            //request.AddHeader("Cache-Control", "no-cache");
            //request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("undefined", "{\"IndictmentID\":100}\n", ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);



            //WebRequest request = WebRequest.Create("http://localhost:57424/ILL_P025.aspx");
            //// Set the Method property of the request to POST.  
            //request.Method = "POST";
            //// Create POST data and convert it to a byte array.  
            //string postData = "IndictmentID=" + IndictmentID.Text;
            //byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            //// Set the ContentType property of the WebRequest.  
            //request.ContentType = "application/x-www-form-urlencoded";
            //// Set the ContentLength property of the WebRequest.  
            //request.ContentLength = byteArray.Length;
            //// Get the request stream.  
            //Stream dataStream = request.GetRequestStream();
            //// Write the data to the request stream.  
            //dataStream.Write(byteArray, 0, byteArray.Length);
            //// Close the Stream object.  
            //dataStream.Close();
            //// Get the response.  


            //WebResponse response = request.GetResponse();
            //// Display the status.  
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            //// Get the stream containing content returned by the server.  
            //dataStream = response.GetResponseStream();
            //// Open the stream using a StreamReader for easy access.  
            //StreamReader reader = new StreamReader(dataStream);
            //// Read the content.  
            //string responseFromServer = reader.ReadToEnd();
            //// Display the content.  
            //Console.WriteLine(responseFromServer);
            //// Clean up the streams.  
            //reader.Close();
            //dataStream.Close();
            //response.Close();

            //Response.Redirect("ILL_P025.aspx");
        }
        public string name
        {
            get
            {
                return "IndictmentID.Text";
            }
        }
        
    }
}