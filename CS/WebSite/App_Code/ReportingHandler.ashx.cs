using System;
using System.IO;
using System.Web;

public class ReportingHandler : IHttpHandler {

    public void ProcessRequest(HttpContext context) {
        XtraReport1 report = new XtraReport1();
        MemoryStream memoryStream = new MemoryStream();

        report.Parameters["CategoryId"].Value = Convert.ToInt32(context.Request["catid"]);
        report.ExportOptions.Image.ExportMode = DevExpress.XtraPrinting.ImageExportMode.SingleFile;
        report.ExportOptions.Image.Format = System.Drawing.Imaging.ImageFormat.Png;
        report.ExportToImage(memoryStream);
        memoryStream.Seek(0, SeekOrigin.Begin);

        context.Response.ContentType = "image/png";
        context.Response.BinaryWrite(memoryStream.ToArray());
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}