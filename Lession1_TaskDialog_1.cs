using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitAPI_MEP
{
    [Transaction(TransactionMode.Manual)]
    public class Lession1_TaskDialog_1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Hiển Thị Thông Báo Đơn Giản
            // TaskDialog.Show("string Tieu de", "string Noi dung")
            TaskDialog.Show("Thông báo", "Hiển Thị Thông Báo Đơn Giản!");
            // End Code
            return Result.Succeeded;
        }
    }
}
