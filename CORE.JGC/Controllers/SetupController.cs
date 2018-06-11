using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CORE.JGC.Models;


namespace CORE.JGC.Controllers
{
    public class SetupController : Controller
    {
        // Untuk ke data dbml
        //Lokasi
        DCAssetDataContext dc = null;
        //string UserId = Session["UserID"].ToString().Trim();
        string UserId = "ADMIN";
        private MsLocation[] GridLokasi()
        {
            dc = new DCAssetDataContext();
            List<MsLocation> mslocation = new List<MsLocation>();
            try
            {
                var query = dc.MsLocation_View("", "G");
                foreach (var res in query)
                {
                    string Aktif = "";
                    MsLocation lokasi = new MsLocation();
                    if (res.bActive.ToString() == "True")
                    {
                        Aktif = "Y";
                    }
                    else {
                        Aktif = "T";
                    }
                    lokasi.Id = res.Id;
                    lokasi.LocationCode = res.LocationCode;
                    lokasi.LocationName = res.LocationName;
                    lokasi.SiteCode = res.SiteCode;
                    lokasi.SiteName = res.SiteName;
                    lokasi.bActive = res.bActive;
                    lokasi.Aktif = Aktif;

                    mslocation.Add(lokasi);
                }
            }
            catch
            {
                mslocation = null;
            }
            return mslocation.ToArray();
        }

        //Site
        private MsSite[] GridSite()
        {
            dc = new DCAssetDataContext();
            List<MsSite> mssite = new List<MsSite>();
            try
            {
                var query = dc.MsSite_View("", "G");
                foreach (var res in query)
                {
                    string Aktif = "";
                    MsSite site = new MsSite();
                    if (res.bActive.ToString() == "True")
                    {
                        Aktif = "Y";
                    }
                    else
                    {
                        Aktif = "T";
                    }

                    site.Id = res.Id;
                    site.SiteCode = res.SiteCode;
                    site.SiteName = res.SiteName;
                    site.Address = res.Address;
                    site.City = res.City;
                    site.PostalCode = res.PostalCode;
                    site.Telephone = res.Telephone;
                    site.bActive = res.bActive;
                    site.Aktif = Aktif;

                    mssite.Add(site);
                }
            }
            catch
            {
                mssite = null;
            }
            return mssite.ToArray();
        }

        //Departemen
        //Site
        private MsDepartment[] GridDepartment()
        {
            dc = new DCAssetDataContext();
            List<MsDepartment> msdepartment = new List<MsDepartment>();
            try
            {
                var query = dc.MsDepartment_View("", "G");
                foreach (var res in query)
                {
                    MsDepartment department = new MsDepartment();
                    
                    department.Id = res.Id;
                    department.DeptCode = res.DeptCode;
                    department.DeptName = res.DeptName;

                    msdepartment.Add(department);
                }
            }
            catch
            {
                msdepartment = null;
            }
            return msdepartment.ToArray();
        }

        //Departemen
        //Site
        private MsCurrency[] GridCurrency()
        {
            dc = new DCAssetDataContext();
            List<MsCurrency> mscurrency = new List<MsCurrency>();
            try
            {
                var query = dc.MsCurrency_View("", "G");
                foreach (var res in query)
                {
                    MsCurrency currency = new MsCurrency();

                    currency.Id = res.Id;
                    currency.CurrencyCode = res.CurrencyCode;
                    currency.CurrencyName = res.CurrencyName;

                    mscurrency.Add(currency);
                }
            }
            catch
            {
                mscurrency = null;
            }
            return mscurrency.ToArray();
        }

        //Brand
        private MsAssetBrand[] GridAssetBrand()
        {
            dc = new DCAssetDataContext();
            List<MsAssetBrand> msassetbrand = new List<MsAssetBrand>();
            try
            {
                var query = dc.MsAssetBrand_View("", "G");
                foreach (var res in query)
                {
                    MsAssetBrand assetbrand = new MsAssetBrand();

                    assetbrand.Id = res.Id;
                    assetbrand.BrandCode = res.BrandCode;
                    assetbrand.BrandName = res.BrandName;

                    msassetbrand.Add(assetbrand);
                }
            }
            catch
            {
                msassetbrand = null;
            }
            return msassetbrand.ToArray();
        }

        //Type
        private MsAssetType[] GridAssetType()
        {
            dc = new DCAssetDataContext();
            List<MsAssetType> msassettype = new List<MsAssetType>();
            try
            {
                var query = dc.MsAssetType_View("", "G");
                foreach (var res in query)
                {
                    MsAssetType assettype = new MsAssetType();

                    assettype.Id = res.Id;
                    assettype.AssetTypeCode = res.AssetTypeCode;
                    assettype.AssetTypeName = res.AssetTypeName;

                    msassettype.Add(assettype);
                }
            }
            catch
            {
                msassettype = null;
            }
            return msassettype.ToArray();
        }

        //Asset Status
        private MsAssetModel[] GridAssetModel()
        {
            dc = new DCAssetDataContext();
            List<MsAssetModel> msassetmodel = new List<MsAssetModel>();
            try
            {
                var query = dc.MsAssetModel_View("", "G");
                foreach (var res in query)
                {
                    MsAssetModel assetmodel = new MsAssetModel();

                    assetmodel.Id = res.Id;
                    assetmodel.ModelCode = res.ModelCode;
                    assetmodel.ModelName = res.ModelName;
                    assetmodel.BrandCode = res.BrandCode;
                    assetmodel.BrandName = res.BrandName;

                    msassetmodel.Add(assetmodel);
                }
            }
            catch
            {
                msassetmodel = null;
            }
            return msassetmodel.ToArray();
        }

        //Asset Status
        private MsAssetStatus[] GridAssetStatus()
        {
            dc = new DCAssetDataContext();
            List<MsAssetStatus> msassetstatus = new List<MsAssetStatus>();
            try
            {
                var query = dc.MsAssetStatus_View("", "G");
                foreach (var res in query)
                {
                    MsAssetStatus assetstatus = new MsAssetStatus();

                    assetstatus.Id = res.Id;
                    assetstatus.Status = res.Status;
                    assetstatus.NameStatus = res.NamaStatus;

                    msassetstatus.Add(assetstatus);
                }
            }
            catch
            {
                msassetstatus = null;
            }
            return msassetstatus.ToArray();
        }

        //Category
        private MsAssetCategory[] GridAssetCategory()
        {
            dc = new DCAssetDataContext();
            List<MsAssetCategory> msassetcategory = new List<MsAssetCategory>();
            try
            {
                var query = dc.MsAssetCategory_View("", "G");
                foreach (var res in query)
                {
                    MsAssetCategory assetcategory = new MsAssetCategory();

                    assetcategory.Id = res.Id;
                    assetcategory.AssetCategoryCode = res.AssetCategoryCode;
                    assetcategory.AssetCategoryName = res.AssetCategoryName;

                    msassetcategory.Add(assetcategory);
                }
            }
            catch
            {
                msassetcategory = null;
            }
            return msassetcategory.ToArray();
        }

        //Untuk action
        public ActionResult Companyinfo()
        {
            return View();
        }

        //sites
        public ActionResult Sites()
        {
            MsSite[] mssite= null;
            mssite = GridSite();
            return View(mssite);
        }

        [HttpPost]
        public ActionResult InsertSite(string SiteCodeId, string SiteNameId, string AddressId, string CityId, string PostalCodeId, string TelephoneId, int ActiveId)
        {
            
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsSite_IUD(SiteCodeId, SiteNameId, AddressId, CityId, PostalCodeId, TelephoneId, ActiveId, UserId, 1);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult UpdateSite(string EditSiteCodeId, string EditSiteNameId, string EditAddressId, string EditCityId, string EditPostalCodeId, string EditTelephoneId, int ActiveId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsSite_IUD(EditSiteCodeId, EditSiteNameId, EditAddressId, EditCityId, EditPostalCodeId, EditTelephoneId, ActiveId, UserId, 2);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }

                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        //----------------------

        //Lokasi
        public ActionResult Locations()
        {
            MsLocation[] mslocation = null;
            mslocation = GridLokasi();
            return View(mslocation);
        }

        [HttpPost]
        public ActionResult InsertLocation(string LocationCodeId, string LocationNameId, string SiteCode, int ActiveId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsLocation_IUD(LocationCodeId, LocationNameId, SiteCode, ActiveId, UserId, 1);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ","") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult UpdateLocation(string NoID, string EditLocationCodeId, string EditLocationNameId, string EditSiteCode, int ActiveId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsLocation_IUD(EditLocationCodeId, EditLocationNameId, EditSiteCode, ActiveId, UserId, 2);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }

                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        //----------------------
        //Asset Category
        public ActionResult Categories()
        {
            MsAssetCategory[] msassetcategory = null;
            msassetcategory = GridAssetCategory();
            return View(msassetcategory);
        }

        [HttpPost]
        public ActionResult InsertAssetCategory(string AssetCategoryCodeId, string AssetCategoryNameId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsAssetCategory_IUD(AssetCategoryCodeId, AssetCategoryNameId, UserId, 1);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult UpdateAssetCategory(string NoID, string EditAssetCategoryCodeId, string EditAssetCategoryNameId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsAssetCategory_IUD(EditAssetCategoryCodeId, EditAssetCategoryNameId, UserId, 2);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }

                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        //----------------------
        //Asset Category
        public ActionResult Assetmodel()
        {
            MsAssetModel[] msassetmodel = null;
            msassetmodel = GridAssetModel();
            return View(msassetmodel);
        }


        [HttpPost]
        public ActionResult InsertAssetModel(string AssetModelCodeId, string AssetModelNameId, string AssetBrandCodeId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsAssetModel_IUD(AssetModelCodeId, AssetModelNameId, AssetBrandCodeId, UserId, 1);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult UpdateAssetModel(string NoID, string EditAssetModelCodeId, string EditAssetModelNameId, string EditAssetBrandCodeId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsAssetModel_IUD(EditAssetModelCodeId, EditAssetModelNameId, EditAssetBrandCodeId, UserId, 2);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }

                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        //----------------------
        //Asset Brand
        public ActionResult Assetbrand()
        {
            MsAssetBrand[] msassetbrand = null;
            msassetbrand = GridAssetBrand();
            return View(msassetbrand);
        }

        [HttpPost]
        public ActionResult InsertAssetBrand(string AssetBrandCodeId, string AssetBrandNameId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsAssetBrand_IUD(AssetBrandCodeId, AssetBrandNameId, UserId, 1);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult UpdateAssetBrand(string NoID, string EditAssetBrandCodeId, string EditAssetBrandNameId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsAssetBrand_IUD(EditAssetBrandCodeId, EditAssetBrandNameId, UserId, 2);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }

                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }
        //----------------------
        //Asset Status
        public ActionResult Assetstatus()
        {
            MsAssetStatus[] msassetstatus = null;
            msassetstatus = GridAssetStatus();
            return View(msassetstatus);
        }

        [HttpPost]
        public ActionResult InsertAssetStatus(string AssetStatusCodeId, string AssetStatusNameId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsAssetStatus_IUD(AssetStatusCodeId, AssetStatusNameId, UserId, 1);
                    string Exx = "";
                    foreach (var res in query)
                    {
                        Exx = res.Exx;
                    }

                    if (Exx.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = Exx.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = Exx.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult UpdateAssetStatus(string NoID, string EditAssetStatusCodeId, string EditAssetStatusNameId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsAssetStatus_IUD(EditAssetStatusCodeId, EditAssetStatusNameId, UserId, 2);
                    string Exx = "";
                    foreach (var res in query)
                    {
                        Exx = res.Exx;
                    }

                    if (Exx.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = Exx.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = Exx.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }

                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        //----------------------
        //Asset Types
        public ActionResult Assettypes()
        {
            MsAssetType[] msassettype = null;
            msassettype = GridAssetType();
            return View(msassettype);
        }

        [HttpPost]
        public ActionResult InsertAssetType(string AssetTypeCodeId, string AssetTypeNameId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsAssetType_IUD(AssetTypeCodeId, AssetTypeNameId, UserId, 1);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult UpdateAssetType(string NoID, string EditAssetTypeCodeId, string EditAssetTypeNameId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsAssetType_IUD(EditAssetTypeCodeId, EditAssetTypeNameId, UserId, 2);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }

                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }
        //-------------------------------------
        //Departemen
        public ActionResult Departments()
        {
            MsDepartment[] msdepartment = null;
            msdepartment = GridDepartment();
            return View(msdepartment);
        }

        [HttpPost]
        public ActionResult Insertdepartment(string DepartmentCodeId, string DepartmentNameId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsDepartment_IUD(DepartmentCodeId, DepartmentNameId, UserId, 1);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult UpdateDepartment(string EditDepartmentCodeId, string EditDepartmentNameId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsDepartment_IUD(EditDepartmentCodeId, EditDepartmentNameId, UserId, 2);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }

                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        //Currency

        //Asset Types
        public ActionResult Currencies()
        {
            MsCurrency[] mscurrency = null;
            mscurrency = GridCurrency();
            return View(mscurrency);
        }

        [HttpPost]
        public ActionResult InsertCurrency(string CurrencyCodeId, string CurrencyNameId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsCurrency_IUD(CurrencyCodeId, CurrencyNameId, UserId, 1);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult UpdateCurrency(string NoID, string EditCurrencyCodeId, string EditCurrencyNameId)
        {
            try
            {

                dc = new DCAssetDataContext();
                try
                {
                    var query = dc.MsCurrency_IUD(EditCurrencyCodeId, EditCurrencyNameId, UserId, 2);
                    string status = "";
                    foreach (var res in query)
                    {
                        status = res.Status;
                    }

                    if (status.Trim().Substring(0, 4) == "Err ")
                    {
                        return Json(new { success = false, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { success = true, responseText = status.Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                    }

                }
                catch (Exception ex)
                {
                    return Json(new { success = false, responseText = ex.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, responseText = ex.Message.ToString().Trim().Replace("err ", "") }, JsonRequestBehavior.AllowGet);
            }
        }


        //----------------------------------------------------------
        public ActionResult Types()
        {
            return View();
        }

        public ActionResult Status()
        {
            return View();
        }

        

        public ActionResult Exchangerate()
        {
            return View();
        }

        public ActionResult Persons()
        {
            return View();
        }

        public ActionResult Autonumber()
        {
            return View();
        }

        public ActionResult Barcode()
        {
            return View();
        }

        public ActionResult Suppliers()
        {
            return View();
        }

        public ActionResult Users()
        {
            return View();
        }

        public ActionResult Createusers()
        {
            return View();
        }

        public ActionResult Createcompany()
        {
            return View();
        }

        //POPUP
        //PopUp Site
        [HttpPost]
        public JsonResult GetPopupSite()
        {
            MsSite[] mssite = null;
            mssite = GridSite();

            return Json(new
            {
                data = mssite.Select(x => new[] { x.SiteCode, x.SiteName, x.Address, x.City, x.PostalCode, x.Telephone})
            }, JsonRequestBehavior.AllowGet);
        }

        //PopUp Site
        [HttpPost]
        public JsonResult GetPopupBrand()
        {
            MsAssetBrand[] msassetbrand = null;
            msassetbrand = GridAssetBrand();

            return Json(new
            {
                data = msassetbrand.Select(x => new[] { x.BrandCode, x.BrandName})
            }, JsonRequestBehavior.AllowGet);
        }

    }
}