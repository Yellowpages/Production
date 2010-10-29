using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TerraJsonClasses;

using Microsoft.SqlServer.Types;

namespace xo_test_app
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_findReverse_Click(object sender, EventArgs e)
        {

            txt_reverse.Text = "";

            // to webservice exei dimiourgithei apo Deksi click sto c# project -> Add Service Reference
            xoServices.xoServiceSoapClient newRequest = new xoServices.xoServiceSoapClient("xoServiceSoap");

            double x = double.Parse(txt_x.Text);
            double y = double.Parse(txt_y.Text);

            xoServices.webResponse tmpRes = newRequest.getReverseAddressXML2(30, x, y, 2100);


            if (tmpRes.resType == xo_test_app.xoServices.webResponseType.Ok)
            {

                // cast to geoAddress[]
                xoServices.geoAddress2[] addresses = (xoServices.geoAddress2[])tmpRes.resObject;

                // epistrefei toulaxiston ena geoAddress
                // pithanotata na epistrefei san defteri epilogi kai diastavrosi.
                // an den theleis diastavroseis perneis mono to addresses[0]
                foreach (xoServices.geoAddress2 foundAdd in addresses)
                {

                    string lektiko = string.Empty;

                    //elenxos tipou proeretiko.
                    switch (foundAdd.addType)
                    {

                        case 1:
                            {
                                lektiko = "Οδός";
                                break;
                            }
                        case 5:
                            {
                                lektiko = "Οδός";
                                break;
                            }
                        case 3:
                            {
                                lektiko = "Διασταύρωση";
                                break;
                            }
                        case 4:
                            {
                                lektiko = "Τοποθεσία";
                                break;
                            }
                    }


                    txt_reverse.Text += Environment.NewLine;
                    txt_reverse.Text += lektiko + ": " + foundAdd.addFormated;

                }


            }
            else
            {

                // error on server
                txt_reverse.Text = tmpRes.resDescription;

            }




        }

        private void btn_driving_times_Click(object sender, EventArgs e)
        {

            // i diadikasia afti apeti reference tou Microsoft.SqlServer.Types;
            //   opou exei mesa to SqlGeometry pou theloume na xrisimopoisoume
            //   Ta bimata einai 
            // 1. ypologisomos tou polygonou (sqlgeometry) apo to webservice TERRA apo 2 inputs CenterPoint + DriveTime (mins)
            // 2. ypologismos tou minX,minY,maxX,maxY tou polygonou.
            // 3. select * from pois in database where poiX>=minX and poiY>=minY and poiX<=maxX and poiY<=maxY
            //    to select tha mas ferei osa simeia einai sto extent tou polygonou, periorizontas ton arithmo ton simeion.
            //    Tora prepei na ta kanoume intersect ena ena na doume pia simeia einai mesa sto polygono.
            // 4. Epistrefoume sto site osa pois kanoun intersect me to polygono


            // 1. ypologisomos tou polygonou (sqlgeometry) apo to webservice TERRA
            xoServices.xoServiceSoapClient newRequest = new xoServices.xoServiceSoapClient("xoServiceSoap");

            // oi 3 parametri einai 
            double x = double.Parse(center_x.Text);
            double y = double.Parse(center_y.Text);
            string drivemin = txt_drivemin.Text; // <--- PROSOXH afto einai STRING

            SqlGeometry centerPoint = SqlGeometry.Point(x, y, 2100);

            //to sqlgeometry prepei na ginei byte[] gia na perasei sto webservice
            List<byte[]> pointGeom = new List<byte[]>();
            pointGeom.Add(centerPoint.STAsBinary().Buffer);

            xoServices.webResponse tmpRes = newRequest.getDrivingTimesForGeometries("", "", pointGeom.ToArray(), drivemin, 30, 2100);

            if (tmpRes.resType == xo_test_app.xoServices.webResponseType.Ok)
            {

                xoServices.terraFeature[] results = (xoServices.terraFeature[])tmpRes.resObject;
                System.Data.SqlTypes.SqlBytes sBytes = new System.Data.SqlTypes.SqlBytes(results[0].geometryWKB);

                // to proto result einai to polygono pou theloume.
                SqlGeometry polygDrive = SqlGeometry.STGeomFromWKB(sBytes, 2100);

                // tora exoume polygDrive. prepei na kanoume intersect ta simeia tis baseis 
                int MinX = 0, MinY = 0, MaxX = 0, MaxY = 0;

                getBoundsFromPolygon(polygDrive, ref MinX, ref MinY, ref MaxX, ref  MaxY);


                // SELECT * FROM POIS WHERE poiX >= MinX AND poiX <=MaxX AND poiY <= MaxY AND poiY >=MinY

                // FOR EACH FOUND POI
                int poiX = 0, poiY = 0;

                SqlGeometry poiGeom = SqlGeometry.Point(poiX, poiY, 2100);

                if (polygDrive.STIntersects(poiGeom))
                {

                    // FOUND VALID POI INTO DRIVING TIME

                }

                //NEXT

            }
            else
            {
                // error on server
                txt_reverse.Text = tmpRes.resDescription;
            }

        }

        void getBoundsFromPolygon(SqlGeometry pol, ref int MinX, ref int MinY, ref int MaxX, ref int MaxY)
        {

            for (int i = 1; i <= pol.STNumPoints(); i++)
            {

                int x = (int)pol.STPointN(i).STX.Value;
                int y = (int)pol.STPointN(i).STY.Value;

                if (x < MinX) { MinX = x; }
                if (y < MinX) { MinY = y; }
                if (x > MinX) { MaxX = x; }
                if (y > MinX) { MaxY = y; }

            }

        }

        private void btn_buffer_route_Click(object sender, EventArgs e)
        {

            Terra_Buffer.BufferEngine newEng = new Terra_Buffer.BufferEngine(2);
            SqlGeometry gm = newEng.getLineBuffer(txt_linebuffer.Text,100);

        }

    }

    
}
