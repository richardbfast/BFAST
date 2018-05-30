using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CORE.JGC.Models;
using iTextSharp.text.pdf.qrcode;
using System.IO;
using System.Drawing;
using iTextSharp.text.pdf;

namespace CORE.JGC.Controllers
{
    public class AssetController : Controller
    {
        DCAssetDataContext dc = null;
        // GET: Asset
        private Ms_Asset[] GridAsset()
        {
            dc = new DCAssetDataContext();
            List<Ms_Asset> msasset = new List<Ms_Asset>();
            try
            {
                var query = dc.MsAsset_View("", "G");
                foreach (var res in query)
                {
                    Ms_Asset asset = new Ms_Asset();
                    asset.Photo = res.AssetPhoto;
                    asset.AssetCode = res.AssetTagID;
                    asset.AssetName = res.AssetName;
                    asset.AssetBrandCode = res.AssetBrand;
                    asset.PurchaseDate = res.PurchaseDate;
                    double price = Convert.ToDouble(res.PurchasePrice);
                    asset.PurchasePrice = res.CurrencyCode +" " + price.ToString("N0");
                    asset.bStatus = res.NamaStatus;
                    msasset.Add(asset); 
                }
            }
            catch
            {
                msasset = null;
            }
            return msasset.ToArray();
        }
        public MsSite[] GetSite()
        {
            List<MsSite> msite = new List<MsSite>();
            dc = new DCAssetDataContext();
            try
            {
                var query = dc.MsSite_View("","G");
                foreach (var res in query)
                {
                    MsSite site = new MsSite();
                    site.SiteCode = res.SiteCode;
                    site.SiteName = res.SiteName;
                    msite.Add(site);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return msite.ToArray();
        }
        public MsLocation[] GetLocation()
        {
            List<MsLocation> mLocation = new List<MsLocation>();
            dc = new DCAssetDataContext();
            try
            {
                var query = dc.MsLocation_View("", "G");
                foreach (var res in query)
                {
                    MsLocation location = new MsLocation();
                    location.LocationCode = res.LocationCode;
                    location.LocationName = res.LocationName;
                    mLocation.Add(location);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return mLocation.ToArray();
        }
        public MsAssetCategory[] GetCategory()
        {
            List<MsAssetCategory> mCategory = new List<MsAssetCategory>();
            dc = new DCAssetDataContext();
            try
            {
                var query = dc.MsAssetCategory_View("", "G");
                foreach (var res in query)
                {
                    MsAssetCategory category = new MsAssetCategory();
                    category.AssetCategoryCode = res.AssetCategoryCode;
                    category.AssetCategoryName = res.AssetCategoryName;
                    mCategory.Add(category);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return mCategory.ToArray();
        }
        public MsDepartment[] GetDept()
        {
            List<MsDepartment> mDept = new List<MsDepartment>();
            dc = new DCAssetDataContext();
            try
            {
                var query = dc.MsDepartment_View("", "G");
                foreach (var res in query)
                {
                    MsDepartment dept = new MsDepartment();
                    dept.DeptCode = res.DeptCode;
                    dept.DeptName = res.DeptName;
                    mDept.Add(dept);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return mDept.ToArray();
        }
        public MsAssetType[] GetAssetType()
        {
            List<MsAssetType> mAssetType = new List<MsAssetType>();
            dc = new DCAssetDataContext();
            try
            {
                var query = dc.MsAssetType_View("", "G");
                foreach (var res in query)
                {
                    MsAssetType assettype = new MsAssetType();
                    assettype.AssetTypeCode = res.AssetTypeCode;
                    assettype.AssetTypeName = res.AssetTypeName;
                    mAssetType.Add(assettype);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return mAssetType.ToArray();
        }
        public MsSupplier[] GetSupplier()
        {
            List<MsSupplier> mSupplier = new List<MsSupplier>();
            dc = new DCAssetDataContext();
            try
            {
                var query = dc.MsSupplier_View("", "G");
                foreach (var res in query)
                {
                    MsSupplier supplier = new MsSupplier();
                    supplier.SupplierCode = res.SupplierCode;
                    supplier.SupplierName = res.SupplierName;
                    mSupplier.Add(supplier);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return mSupplier.ToArray();
        }
        public MsAssetBrand[] GetAssetBrand()
        {
            List<MsAssetBrand> mAssetBrand = new List<MsAssetBrand>();
            dc = new DCAssetDataContext();
            try
            {
                var query = dc.MsAssetBrand_View("", "G");
                foreach (var res in query)
                {
                    MsAssetBrand assetbrand = new MsAssetBrand();
                    assetbrand.BrancCode = res.BrandCode;
                    assetbrand.BrandName = res.BrandName;
                    mAssetBrand.Add(assetbrand);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return mAssetBrand.ToArray();
        }
        public MsAssetModel[] GetAssetModel()
        {
            List<MsAssetModel> mAssetModel = new List<MsAssetModel>();
            dc = new DCAssetDataContext();
            try
            {
                var query = dc.MsAssetModel_View("", "G");
                foreach (var res in query)
                {
                    MsAssetModel assetmodel = new MsAssetModel();
                    assetmodel.ModelCode = res.ModelCode;
                    assetmodel.ModelName = res.ModelName;
                    mAssetModel.Add(assetmodel);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return mAssetModel.ToArray();
        }
        public MsCurrency[] GetCurrency()
        {
            List<MsCurrency> mCurrency = new List<MsCurrency>();
            dc = new DCAssetDataContext();
            try
            {
                var query = dc.MsCurrency_View("", "G");
                foreach (var res in query)
                {
                    MsCurrency currency = new MsCurrency();
                    currency.CurrencyCode = res.CurrencyCode;
                    currency.CurrencyName = res.CurrencyName;
                    mCurrency.Add(currency);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return mCurrency.ToArray();
        }
        public MsCompany[] GetCompany()
        {
            List<MsCompany> mCompany = new List<MsCompany>();
            dc = new DCAssetDataContext();
            try
            {
                var query = dc.MsCompany_View("", "G");
                foreach (var res in query)
                {
                    MsCompany company = new MsCompany();
                    company.CompanyCode = res.CompanyCode;
                    company.CompanyName = res.CompanyName;
                    mCompany.Add(company);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return mCompany.ToArray();
        }
        private string GenerateQrCode(string assettagid)
        {
            string base64;
            //iTextSharp.text.Document doc = new iTextSharp.text.Document(new iTextSharp.text.Rectangle(4.5f, 5.5f), 0.5f, 0.5f, 0, 0);
            //string filepathimg = Path.Combine(Server.MapPath("~/Views/QrCode/"), assettagid + ".jpg");

            ByteMatrix btm;
            MemoryStream ms = null;
            Bitmap bmp = null;
            try
            {
                BarcodeQRCode qrcode = new BarcodeQRCode(assettagid, 200, 200, null);
                QRCodeWriter qrwriter = new QRCodeWriter();
                btm = qrwriter.Encode(assettagid, 200, 200, null);
                qrcode.GetImage();
                sbyte[][] imgQr = btm.GetArray();
                bmp = new Bitmap(200, 200);
                Graphics gpr = Graphics.FromImage(bmp);
                gpr.Clear(Color.White);
                for (int i = 0; i < imgQr.Length; i++)
                {
                    for (int j = 0; j <= imgQr[i].Length - 1; j++)
                    {
                        if (imgQr[j][i] == 0)
                        {
                            gpr.FillRectangle(Brushes.Black, i, j, 1, 1);
                        }
                        else
                        {
                            gpr.FillRectangle(Brushes.White, i, j, 1, 1);
                        }
                    }
                }
                Response.ContentType = "image/jpeg";
                //fs = new FileStream(filepathimg, FileMode.Create);
                ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] byteImg = ms.ToArray();
                base64 = Convert.ToBase64String(byteImg);
                
            }
            catch (Exception ex)
            {
                base64 = "";
                string msg = ex.Message;
            }
            bmp.Dispose();
            ms.Close();
            return base64;
        }
        private string GeneratePhoto(string filePath)
        {
            string base64 = string.Empty;
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);
            base64 = Convert.ToBase64String(photo);
            reader.Close();
            stream.Close();

            return base64;
        }
        public ActionResult Index()
        {
            Ms_Asset[] msasset = null;
            msasset = GridAsset();
            
            return View(msasset);
        }

        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Create()
        {
            ViewBag.Sitecode = GetSite();
            ViewBag.Location = GetLocation();
            ViewBag.Category = GetCategory();
            ViewBag.Dept = GetDept();
            ViewBag.AssetType = GetAssetType();
            ViewBag.Suppliername = GetSupplier();
            ViewBag.BrandName = GetAssetBrand();
            ViewBag.ModelName = GetAssetModel();
            ViewBag.Currencyname = GetCurrency();
            ViewBag.Companyname = GetCompany();
            return View();
        }
        
        
        [HttpPost]
        public ActionResult InputData(string site, string category, string location, string departement, string assetname, string supplier, string purchaseno,
            string brand, string purchasedateid, string model, string price, string serialno, string type,string company, string currency, string floor, string warranty, 
            string cap, string active)
        {
            string userid = "system";
            //string Photo = GeneratePhoto(path);
            string hasil= string.Empty;

            dc = new DCAssetDataContext();
            try
            {
                var query = dc.MsAsset_IUD(assetname, brand, model, category, serialno, type, Convert.ToInt32(active), Convert.ToInt32(cap), "", site, location, Convert.ToInt32(floor),
                    purchaseno, currency, Convert.ToDecimal(price), Convert.ToDateTime(purchasedateid), supplier, company, departement, Convert.ToInt32(warranty), userid, 1);
                foreach(var res in query)
                {
                    if (res.Status == "Err This Data Already Exists")
                    {
                        hasil = "Data Already Exists";
                    }
                    else
                    {
                        string qrcode = GenerateQrCode(res.Status);
                        var qr = dc.MsQrCode_IUD(res.Status, qrcode, userid, 1);
                        hasil = res.Status;
                    }                        
                }                
            }
            catch (Exception ex)
            {
                return Json(new { error = true, responseText = ex.Message.ToString().Trim() }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success=true, responseText = hasil }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Createmaintenance()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult Checkin()
        {
            return View();
        }

        public ActionResult Lease()
        {
            return View();
        }

        public ActionResult Leasereturn()
        {
            return View();
        }
    
        public ActionResult Dispose()
        {
            return View();
        }

        public ActionResult Move()
        {
            return View();
        }

        public ActionResult Assetpastdue()
        {
            return View();
        }

        public ActionResult Maintenancedue()
        {
            return View();
        }

        public ActionResult Warrantiesexpiring()
        {
            return View();
        }
    }
}