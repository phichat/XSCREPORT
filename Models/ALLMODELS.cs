using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSCREPORT.Models
{
    public class ALLMODELS
    {
    }
    public class testjson1
    {
        public int aaa { set; get; }
        public List<testjson2> ts2 { set; get; }

    }
    public class testjson2
    {

        public string bbb { set; get; }
    }

    #region lawsuitgetbycon
    public class LawsuitArrestgetByConModels
    {
        public int IndictmentID { get; set; }
    }
    public class LawsuitArrestgetByConJson
    {
        public string ArrestCode { get; set; }
        public List<LawsuitArrestIndicment> LawsuitArrestIndicment { get; set; }
        public List<LawsuitArrestStaff> LawsuitArrestStaff { get; set; }
    }
    public class LawsuitArrestIndicment
    {
        public List<LawsuitArrestIndicmentDetail> LawsuitArrestIndicmentDetail { get; set; }


        public List<Lawsuit> Lawsuit { get; set; }
        public List<LawsuitLawGuiltbase> LawsuitLawGuiltbase { get; set; }
    }
    public class Lawsuit
    {
        public string LawsuitNo { get; set; }
        public string LawsuitDate { get; set; }
        public string LawsuitTime { get; set; }
        public int IsLawsuit { get; set; }
        public string ReasonDontLawsuit { get; set; }
        public string LawsuitStation { get; set; }
        public List<LawsuiteStaff> LawsuiteStaff { get; set; }

    }
    public class LawsuitLawGuiltbase
    {
        public string GuiltBaseName { get; set; }
    }
    public class LawsuitArrestProductDetail
    {
        public string ProductDesc { get; set; }
        public string ProductSize { get; set; }
        public string ProductSizeUnitName { get; set; }
        public string ProductQty { get; set; }
        public string ProductNetVolume { get; set; }
        public string ProductNetVolumeUnit { get; set; }
    }
    public class LawsuitArrestIndicmentDetail
    {
        public List<LawsuitArrestProductDetail> LawsuitArrestProductDetail { get; set; }
        public List<LawsuitArrestLawbreaker> LawsuitArrestLawbreaker { get; set; }
    }
    public class LawsuitArrestLawbreaker
    {
        //public int EntityType { get; set; }
        public string LawbreakerTitleName { get; set; }
        public string LawbreakerFirstName { get; set; }
        public string LawbreakerMiddleName { get; set; }
        public string LawbreakerLastName { get; set; }
        public string LawbreakerOtherName { get; set; }
        //public string CompanyTitle { get; set; }
        //public string CompanyName { get; set; }
        //public string CompanyOtherName { get; set; }
    }
    public class LawsuiteStaff
    {
        //public string TitleName { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string PositionName { get; set; }
        //public string DepartmentName { get; set; }
        public string OfficeName { get; set; }
        public string OfficeShortName { get; set; }
    }
    public class LawsuitArrestStaff
    {
        public string DepartmentName { get; set; }
        public string TitleName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PositionName { get; set; }
        public int ContributorID { get; set; }
        public string OfficeShortName { get; set; }
    }
    #endregion

    #region ArrestgetByCon
    public class ArrestgetByConmodel
    {
        public string ArrestCode { get; set; }
    }
    public class ArrestgetByCon
    {
        public string ArrestCode { get; set; }
        public string ArrestStation { get; set; }
        public string ArrestDate { get; set; }
        public string ArrestTime { get; set; }
        public string OccurrenceDate { get; set; }
        public string OccurrenceTime { get; set; }
        public string Behaviour { get; set; }
        public string Prompt { get; set; }
        public List<ArrestLocale> ArrestLocale { get; set; }
        public List<ArrestStaff> ArrestStaff { get; set; }
        public List<ArrestProduct> ArrestProduct { get; set; }
        public List<ArrestIndictment> ArrestIndictment { get; set; }
    }
    public class ArrestLocale
    {
        public string Location { get; set; }
        public string Address { get; set; }
        public string Village { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string Room { get; set; }
        public string Alley { get; set; }
        public string Road { get; set; }
        public string SubDistrict { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
    }
    public class ArrestStaff
    {
        public string TitleName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PositionName { get; set; }
        public string OfficeName { get; set; }
        public int ContributorCode { get; set; }
    }
    public class ArrestIndictment
    {
        public List<ArrestIndictmentDetail> ArrestIndictmentDetail { get; set; }
        public List<ArrestLawGuitbase> ArrestLawGuitbase { get; set; }

    }
    public class ArrestIndictmentDetail
    {
        public List<ArrestLawbreaker> ArrestLawbreaker { set; get; }

    }
    public class ArrestLawbreaker
    {
        public int EntityType { get; set; }
        public string LawbreakerTitleName { get; set; }
        public string LawbreakerFirstName { get; set; }
        public string LawbreakerMiddleName { get; set; }
        public string LawbreakerLastName { get; set; }
        public string LawbreakerOtherName { get; set; }
        public string CompanyTitle { get; set; }
        public string CompanyName { get; set; }
        public string CompanyOtherName { get; set; }
    }
    public class ArrestProduct
    {
        public string ProductDesc { get; set; }
        public string Qty { get; set; }
        public string QtyUnit { get; set; }
    }
    public class ArrestLawGuitbase
    {
        public string GuiltBaseName { get; set; }
    }
    #endregion

    #region GetReportForm252
    public class GetReportForm252Model
    {
        public DateTime PaymentDate { get; set; }
        public int CompareID { get; set; }
        public int IndictmentID { get; set; }
        public string ArrestCode { get; set; }
    }

    public class ComparegetByCon
    {
        public int CompareID { get; set; }
        public string CompareCode { get; set; }
        public DateTime CompareDate { get; set; }
        public string CompareStation { get; set; }
        public List<CompareDetail> CompareDetail { get; set; }
    }

    public class CompareDetail
    {
        public int CompareDetailID { get; set; }
        public int CompareID { get; set; }
        public int IndictmentDetailID { get; set; }
        public int IsRequest { get; set; }
        public DateTime PaymentFineAppointDate { get; set; }
        public List<CompareDetailFine> CompareDetailFine { get; set; }
    }

    public class CompareDetailFine
    {
        public int CompareFineID { get; set; }
        public int CompareDetailID { get; set; }
        public int ProductID { get; set; }
        public double? ProductFine { get; set; }
        public List<CompareDetailReceipt> CompareDetailReceipt { get; set; }
    }

    public class CompareDetailReceipt
    {
        public int CompareReceiptID { get; set; }
        public int CompareDetailID { get; set; }
        public DateTime PaymentDate { get; set; }
        public double? TotalFine { get; set; }
    }

    public class CompareArrestgetByIndictmentID
    {
        public string ArrestCode { get; set; }
        public int IndictmentID { get; set; }
        public string TitleName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SubDistrict { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string SubSectionType { get; set; }
        public string GuiltbaseName { get; set; }
        public string SectionNo { get; set; }
        public List<CompareArrestIndictmentDetail> CompareArrestIndictmentDetail { get; set; }
    }

    public class CompareArrestIndictmentDetail
    {
        public int IndictmentDetailID { get; set; }
        public int IndictmentID { get; set; }
        public int LawbreakerID { get; set; }
        public List<CompareArrestLawbreaker> CompareArrestLawbreaker { get; set; }
    }

    public class CompareArrestLawbreaker
    {
        public int LawbreakerID { get; set; }
        public string LawbreakerTitleName { get; set; }
        public string LawbreakerFirstName { get; set; }
        public string LawbreakerMiddleName { get; set; }
        public string LawbreakerLastName { get; set; }
        public string LawbreakerOtherName { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalityNameTH { get; set; }
        public string RaceName { get; set; }
        public string ReligionName { get; set; }
        public string Career { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Village { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string Room { get; set; }
        public string Alley { get; set; }
        public string Road { get; set; }
        public string SubDistrict { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string ZipCode { get; set; }
    }
    #endregion
}