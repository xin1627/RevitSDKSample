//
// (C) Copyright 2003-2017 by Autodesk, Inc. All rights reserved.
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.

//
// AUTODESK PROVIDES THIS PROGRAM 'AS IS' AND WITH ALL ITS FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE. AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
//
// Use, duplication, or disclosure by the U.S. Government is subject to
// restrictions set forth in FAR 52.227-19 (Commercial Computer
// Software - Restricted Rights) and DFAR 252.227-7013(c)(1)(ii)
// (Rights in Technical Data and Computer Software), as applicable. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;

namespace Revit.SDK.Samples.Site.CS
{
    /// <summary>
    /// A command that adds a new circular retaining pond to a TopographySurface where the user selects.
    /// </summary>
    /// <remarks>This command demonstrates how the Site API supports creation of standard topography "families" representing
    /// commonly used landscape structures.</remarks>
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class TestRedLine : IExternalCommand
    {
        static PropertyLine pl = null;
        /// <summary>
        /// Implementation of the external command.
        /// </summary>
        /// <param name="commandData"></param>
        /// <param name="message"></param>
        /// <param name="elements"></param>
        /// <returns></returns>
        public Result Execute(ExternalCommandData commandData, ref string message, Autodesk.Revit.DB.ElementSet elements)
        {
            //AddNewRetainingPond(commandData.Application.ActiveUIDocument, 32);
            pl = PickPropertyLines(commandData.Application.ActiveUIDocument);
            if(pl!=null)
            {
                TestDrawLine(commandData.Application.ActiveUIDocument);
            }

            return Result.Succeeded;
        }

        public void ImportDWG()
        {

        }

        public void CreateCurveLines(Document doc, CurveArray curveArr)
        {
            var curve = curveArr.get_Item(0);
            var point = curve.GetEndPoint(0);
            XYZ nomal = XYZ.BasisZ;
            Plane plane = Plane.CreateByNormalAndOrigin(nomal, point);
            SketchPlane sketchPlane = SketchPlane.Create(doc,plane);
            doc.Create.NewModelCurveArray(curveArr, sketchPlane);
        }

        public  PropertyLine PickPropertyLines(UIDocument uiDoc)
        {
            #region select ppline
            Document doc = uiDoc.Document;
            //Selection selection = uiDoc.Selection;
            //var ids = selection.GetElementIds();

            //List<ElementId> eids = ids.ToList();
            //return doc.GetElement(eids[0]) as PropertyLine;
            #endregion

            ElementId elemId = new ElementId(1250296);
            return doc.GetElement(elemId) as PropertyLine;
        }

        public void TestDrawLine(UIDocument uiDoc)
        {
            Document doc = uiDoc.Document;
            
            Selection selection = uiDoc.Selection;
            var ids = selection.GetElementIds();

            XYZ normal = XYZ.BasisZ;
            CurveArray array = new CurveArray();
            foreach (var id in ids)
            {
                Element element = doc.GetElement(id) as Element;

                if(element.GetType().ToString() == "Autodesk.Revit.DB.DetailArc")
                {
                    DetailArc da = element as DetailArc;
                    GeometryElement ge = da.get_Geometry(new Options());
                    foreach (var obj in ge)
                    {
                        if (obj is Arc)
                        {
                            Arc arc = obj as Arc;
                            array.Append(arc);
                        }
                    }
                }
                if(element.GetType().ToString() == "Autodesk.Revit.DB.DetailLine")
                {
                    DetailLine dl = element as DetailLine;
                    GeometryElement ge =  dl.get_Geometry(new Options());
                    foreach(var obj in ge)
                    {
                        if(obj is Line)
                        {
                            Line line = obj as Line;
                            array.Append(line);
                        }
                    }
                }
            }
            GeometryElement pg = pl.get_Geometry(new Options());
            
            using (Transaction ts = new Transaction(doc, "draw curves"))
            {
                ts.Start();
                CreateCurveLines(doc,array);
                ts.Commit();
            }
        }

        public void AddSiteSubRegion(UIDocument uiDoc)
        {
            Selection selection = uiDoc.Selection;
            var ids = selection.GetElementIds();
            var doc = uiDoc.Document;

            using (Transaction t1 = new Transaction(doc, "Delete subregion"))
            {
                XYZ normal = XYZ.BasisZ;

                foreach (var id in ids)
                {
                    BuildingPad buildingPad = doc.GetElement(id) as BuildingPad;
                    IList<CurveLoop> loops = buildingPad.GetBoundary();
                    var newLoops = new List<CurveLoop>();

                    foreach (var loop in loops)
                    {
                        newLoops.Add(loop);
                        newLoops.Add(CurveLoop.CreateViaOffset(loop, -10, normal));
                    }
                    TopographySurface ts = doc.GetElement(buildingPad.HostId) as TopographySurface;
                    t1.Start();
                    SiteSubRegion reg = SiteSubRegion.Create(doc, newLoops, buildingPad.HostId);
                    t1.Commit();
                    //buildingPad.SetParameterValue("绿地修正子面域ID", reg.TopographySurface.Id.ToString());//关联子面域id
                }
            }
        }

    }
}
