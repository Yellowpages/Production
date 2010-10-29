<%@ WebHandler Language="C#" Class="GetLineImageNoServer" %>

using System;
using System.Drawing;
using System.Collections;
using System.Web;
using System.IO;

public class GetLineImageNoServer : IHttpHandler
{
    
    public void ProcessRequest (HttpContext context) {
        string ndc = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        
        double x = Convert.ToDouble(context.Request.Params["x"].Replace(",", ndc).Replace(".", ndc));
        double y = Convert.ToDouble(context.Request.Params["y"].Replace(",", ndc).Replace(".", ndc));

        
        int w = 2000;
        if (context.Request.Params["w"]!=null)
            w=Convert.ToInt32(context.Request.Params["w"]);

        int h = 2000;
        if (context.Request.Params["h"] != null)
            h=Convert.ToInt32(context.Request.Params["h"]);

        string line = context.Request.Params["line"];

        string[] line_segments = null;
        line_segments = line.Split('@');
        Bitmap lineImage = new Bitmap(w, h);
        Graphics gra = null; 
        gra = Graphics.FromImage(lineImage);
        Pen myPen = new Pen(Color.FromArgb(128, Color.Blue));
        myPen.Width = 4;
        if (line_segments != null)
        {
            for (int oo = 0; oo < line_segments.Length; oo++)
            {
                string[] lineArray = null;
                if (line != null)
                    lineArray = line_segments[oo].Split('$');

                
                if (lineArray != null)
                {
                    //lineImage.MakeTransparent();
                    for (int i = 0; i < (lineArray.Length / 2) - 1; i++)
                    {
                        int j = 2 * i;
                        gra.DrawLine(myPen, Convert.ToInt32(lineArray[j]), Convert.ToInt32(lineArray[j + 1]), Convert.ToInt32(lineArray[j + 2]), Convert.ToInt32(lineArray[j + 3]));
                    }
                }
            }
        }

        MemoryStream MemStream = new MemoryStream();
        lineImage.Save(MemStream, System.Drawing.Imaging.ImageFormat.Png);
        context.Response.ContentType = "image/png";
        MemStream.WriteTo(context.Response.OutputStream);
        lineImage.Dispose();
        MemStream.Dispose();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }



    
}