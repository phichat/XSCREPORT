using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using XSCREPORT.App_Start;
using cf = XSCREPORT.App_Start.Configs;
namespace XSCREPORT.Models
{
    public class OperModels
    {

        public DataTable Lawsuitgetbycon(LawsuitArrestgetByConModels model)
        {
            var cc = new cf();
            try
            {

                var db = new Configs();
                JObject jsonobj = (JObject)JToken.FromObject(model);
                //var client = new RestClient("http://150.95.81.223:8083/XCS60/LawsuitArrestgetByCon");
                var client = new RestClient("http://103.233.193.62:8083/XCS60/LawsuitArrestgetByCon");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Postman-Token", "0d7a7694-f469-49b6-b944-8bbfe790bbec");
                request.AddHeader("Cache-Control", "no-cache");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("undefined", jsonobj.ToString(), RestSharp.ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                //var content = response.Content;
                IRestResponse<List<LawsuitArrestgetByConJson>> response2 = client.Execute<List<LawsuitArrestgetByConJson>>(request);
                //Console.WriteLine(response.Content);
                DATASETREPORT.LawsuitArrestgetByConDataTable dts = new DATASETREPORT.LawsuitArrestgetByConDataTable();
                DATASETREPORT.LawsuitArrestgetByConRow dr2;



                if (response2.Data == null)
                {
                    return null;
                }
                else
                {
                    if (response2.Data != null)
                    {
                        foreach (var x in response2.Data)
                        {
                            if (x.ArrestCode != null)
                            {
                                dr2 = dts.NewLawsuitArrestgetByConRow();
                                dr2.ArrestCode = x.ArrestCode;
                                //Console.WriteLine(x.ArrestCode);
                                foreach (var x1 in x.LawsuitArrestIndicment)
                                {
                                    foreach (var x2 in x1.Lawsuit)
                                    {
                                        if (x2.LawsuiteStaff != null)
                                        {
                                            foreach (var x3 in x2.LawsuiteStaff)
                                            {

                                                dr2._ls_OfficeName = x3.OfficeName;

                                            }
                                        }

                                        dr2.LawsuitStation = x2.LawsuitStation;
                                        dr2.LawsuitNo = x2.LawsuitNo;
                                        dr2.LawsuitDate = DateTime.Parse(x2.LawsuitDate);
                                        dr2.Lawsuitday = DateTime.Parse(x2.LawsuitDate).ToString("dd");
                                        string[] mounth = { "", "มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม" };
                                        string dayint = DateTime.Parse(x2.LawsuitDate).ToString("MM");
                                        dr2.Lawsuitmonth = mounth[int.Parse(dayint)];
                                        string sdadasd = DateTime.Parse(x2.LawsuitDate).ToString("yyyy");
                                        int fff = int.Parse(sdadasd) + 543;
                                        dr2.Lawsuityear = fff.ToString();

                                        dr2.IsLawsuit = x2.IsLawsuit;
                                        dr2.ReasonDontLawsuit = x2.ReasonDontLawsuit;
                                    }
                                    foreach (var x4 in x1.LawsuitArrestIndicmentDetail)
                                    {
                                        if (x4.LawsuitArrestLawbreaker != null)
                                        {
                                            dr2.LawbreakerName = "";
                                            foreach (var x5 in x4.LawsuitArrestLawbreaker)
                                            {
                                                dr2.LawbreakerName += x5.LawbreakerTitleName + " " + x5.LawbreakerFirstName + " " + x5.LawbreakerMiddleName + " " + x5.LawbreakerLastName + " " + x5.LawbreakerOtherName;
                                            }
                                        }
                                        if (x4.LawsuitArrestProductDetail != null)
                                        {
                                            dr2.ProductDesc = "";
                                            foreach (var x6 in x4.LawsuitArrestProductDetail)
                                            {
                                                dr2.ProductDesc += x6.ProductDesc + " " + x6.ProductSize + " " + x6.ProductSizeUnitName + " " + x6.ProductQty + " " + x6.ProductNetVolume + " " + x6.ProductNetVolumeUnit;
                                            }
                                        }
                                    }
                                    if (x1.LawsuitLawGuiltbase != null)
                                    {
                                        dr2.GuiltBaseName = "";
                                        foreach (var x7 in x1.LawsuitLawGuiltbase)
                                        {
                                            dr2.GuiltBaseName += x7.GuiltBaseName;

                                        }
                                    }

                                }
                                foreach (var x1 in x.LawsuitArrestStaff)
                                {
                                    if (x1.ContributorID == 6)
                                    {
                                        dr2._las_Name = x1.TitleName + " " + x1.FirstName + " " + x1.LastName;
                                        dr2._las_PositionName = x1.PositionName;
                                        dr2._las_OfficeShortName = x1.OfficeShortName;
                                    }

                                }
                                dts.Rows.Add(dr2);
                            }
                        }
                    }
                }

                return dts;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return null;
            }
        }

        public DataSet ArrestgetByCon(ArrestgetByConmodel model)
        {
            var cc = new cf();
            try
            {
                var db = new Configs();
                JObject jsonobj = (JObject)JToken.FromObject(model);
                var client = new RestClient("http://" + cc.GetIP + "/ArrestgetByCon");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Postman-Token", "0d7a7694-f469-49b6-b944-8bbfe790bbec");
                request.AddHeader("Cache-Control", "no-cache");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("undefined", jsonobj.ToString(), RestSharp.ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                //var content = response.Content;
                IRestResponse<List<ArrestgetByCon>> response2 = client.Execute<List<ArrestgetByCon>>(request);
                //Console.WriteLine(response.Content);
                DataSet dtsr = new DataSet();
                DATASETREPORT.ArrestgetByConDataTable dts1 = new DATASETREPORT.ArrestgetByConDataTable();
                DATASETREPORT.ArrestgetByConRow dr1;
                DATASETREPORT.ArrestgetByCon2DataTable dts2 = new DATASETREPORT.ArrestgetByCon2DataTable();
                DATASETREPORT.ArrestgetByCon2Row dr2;
                if (response2.Data == null)
                {
                    return null;
                }
                else
                {
                    foreach (var x in response2.Data)
                    {
                        dr1 = dts1.NewArrestgetByConRow();
                        dr1.ArrestCode = x.ArrestCode;
                        dr1.ArrestStation = x.ArrestStation;
                        dr1.ArrestDay = DateTime.Parse(x.ArrestDate).ToString("dd");
                        string[] mounth = { "", "มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม" };
                        string dayint = DateTime.Parse(x.ArrestDate).ToString("MM");
                        dr1.ArrestMonth = mounth[int.Parse(dayint)];
                        string sdadasd = DateTime.Parse(x.ArrestDate).ToString("yyyy");
                        int fff = int.Parse(sdadasd) + 543;
                        dr1.ArrestYear = fff.ToString();
                        dr1.ArrestTime = x.ArrestTime;
                        dr1.Behaviour = x.Behaviour;
                        if (x.ArrestStaff != null)
                        {
                            dr1._AS_Nameup6 = "";
                            foreach (var y in x.ArrestStaff)
                            {

                                if (y.ContributorCode == 6)
                                {
                                    dr1._AS_Name6 = y.TitleName + " " + y.FirstName + " " + y.LastName;
                                    dr1._AS_PositionName = y.PositionName;
                                    dr1._AS_OfficeName = y.OfficeName;
                                }
                                else if (y.ContributorCode != 6)
                                {
                                    dr1._AS_Nameup6 += y.TitleName + " " + y.FirstName + " " + y.LastName + " ";
                                }

                            }
                        }
                        if (x.ArrestIndictment != null)
                        {
                            foreach (var y in x.ArrestIndictment)
                            {
                                if (y.ArrestIndictmentDetail != null)
                                {
                                    foreach (var z in y.ArrestIndictmentDetail)
                                    {
                                        if (z.ArrestLawbreaker != null)
                                        {
                                            dr1._AL_Name = "";
                                            foreach (var o in z.ArrestLawbreaker)
                                            {
                                                if (o.EntityType == 1)
                                                {
                                                    dr1._AL_Name += o.LawbreakerTitleName + " " + o.LawbreakerFirstName + " " + o.LawbreakerLastName + " ";
                                                }
                                                else if (o.EntityType == 2)
                                                {
                                                    dr1._AL_Name += o.CompanyTitle + " " + o.CompanyName + " " + o.CompanyOtherName + " ";
                                                }
                                            }
                                        }
                                    }
                                }
                                if (y.ArrestLawGuitbase != null)
                                {
                                    dr1.GuiltBaseName = "";
                                    foreach (var z in y.ArrestLawGuitbase)
                                    {
                                        dr1.GuiltBaseName += z.GuiltBaseName + " ";
                                    }
                                }
                            }
                        }
                        if (x.ArrestProduct != null)
                        {
                            dr1._AP_ProductDesc = "";
                            dr1._AL_count = x.ArrestProduct.Count.ToString();
                            foreach (var y in x.ArrestProduct)
                            {
                                dr1._AP_ProductDesc += y.ProductDesc + " ";
                                dr2 = dts2.NewArrestgetByCon2Row();
                                dr2.ArrestCode = x.ArrestCode;
                                dr2._ap_ProductDesc = y.ProductDesc;
                                dr2.Qty = y.Qty + " " + y.QtyUnit;
                                dts2.Rows.Add(dr2);
                            }

                        }
                        if (x.ArrestLocale != null)
                        {
                            foreach (var z in x.ArrestLocale)
                            {
                                dr1._ai_Location = z.Location + " " + z.Address + " " + z.Village + " " + z.Building + " " + z.Floor + " " + z.Room + " " + z.SubDistrict + " " + z.District + " " + z.Province;
                                dr1._ai_Address = z.Address;
                                dr1._ai_Village = z.Village;
                                dr1._ai_SubDistrict = z.SubDistrict;
                                dr1._ai_District = z.District;
                                dr1._ai_Province = z.Province;
                                dr1._ai_Road = z.Road;
                            }
                        }
                        dr1.OccurrenceDay = DateTime.Parse(x.OccurrenceDate).ToString("dd");
                        string odayint = DateTime.Parse(x.ArrestDate).ToString("MM");
                        dr1.OccurrenceMonth = mounth[int.Parse(odayint)];
                        string sadsasas = DateTime.Parse(x.OccurrenceDate).ToString("yyyy");
                        int offf = int.Parse(sadsasas) + 543;
                        dr1.OccurrenceYear = offf.ToString();
                        dr1.OccurrenceTime = x.OccurrenceTime;
                        dr1.Prompt = x.Prompt;
                        dts1.Rows.Add(dr1);

                    }

                    dtsr.Tables.Add(dts1);
                    dtsr.Tables.Add(dts2);
                    return dtsr;
                }

            }
            catch
            {
                return null;
            }
        }

        public DataSet GetReportForm252(GetReportForm252Model model)
        {
            var cc = new cf();
            try
            {
                var db = new Configs();

                var client = new RestClient("http://" + cc.GetIPCompare + "/ComparegetByCon");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Postman-Token", "7328f72d-a9e8-4e4c-bf18-03794e2b5f3b");
                request.AddHeader("Cache-Control", "no-cache");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("undefined", "{\"CompareID\": " + model.CompareID + "}", RestSharp.ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                IRestResponse<List<ComparegetByCon>> resA = client.Execute<List<ComparegetByCon>>(request);


                client = new RestClient("http://" + cc.GetIPCompare + "/CompareArrestgetByIndictmentID");
                request = new RestRequest(Method.POST);
                request.AddHeader("Postman-Token", "0d7a7694-f469-49b6-b944-8bbfe790bbec");
                request.AddHeader("Cache-Control", "no-cache");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("undefined", "{\"IndictmentID\": " + model.IndictmentID + "}", RestSharp.ParameterType.RequestBody);
                response = client.Execute(request);
                IRestResponse<List<CompareArrestIndictmentDetail>> resB = client.Execute<List<CompareArrestIndictmentDetail>>(request);


                client = new RestClient("http://" + cc.GetIP + "/ArrestgetByCon");
                request = new RestRequest(Method.POST);
                request.AddHeader("Postman-Token", "0d7a7694-f469-49b6-b944-8bbfe790bbec");
                request.AddHeader("Cache-Control", "no-cache");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("undefined", "{\"ArrestCode\": " + model.ArrestCode + "}", RestSharp.ParameterType.RequestBody);
                response = client.Execute(request);
                IRestResponse<List<ArrestgetByCon>> resC = client.Execute<List<ArrestgetByCon>>(request);


                DataSet dtsr = new DataSet();

                if (resA.Data == null)
                    return null;

                return dtsr;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}