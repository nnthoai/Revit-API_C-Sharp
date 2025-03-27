using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitAPI_MEP
{
    [Transaction(TransactionMode.Manual)]
    public class Lession1_TaskDialog_3 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // TaskDialog : Hiển Thị Thông Báo Với Icon (Warning, Error, Information)
            // 📌 Dùng khi cần hiển thị thông báo có icon cảnh báo hoặc lỗi.

            // Hộp thoại Cảnh báo
            TaskDialog td = new TaskDialog("Cảnh báo"); // Tiêu đề chính của hộp thoại.

            td.MainInstruction = "Hiển thị Icon Warning"; // Tiêu đề của nội dung.
            td.MainContent = "Bạn cần kiểm tra lại dữ liệu đầu vào."; // Nội dung chi tiết.
            td.MainIcon = TaskDialogIcon.TaskDialogIconWarning; // Hiển thị icon cảnh báo trong hộp thoại.
            //td.MainIcon = TaskDialogIcon.TaskDialogIconInformation; // Hiển thị icon thông tin trong hộp thoại.
            //td.MainIcon = TaskDialogIcon.TaskDialogIconNone; // Khong co icon trong hộp thoại.
            //td.MainIcon = TaskDialogIcon.TaskDialogIconError; // Hiển thị icon error trong hộp thoại.
            //td.MainIcon = TaskDialogIcon.TaskDialogIconShield; // Hiển thị icon Shield (Lá chắn) trong hộp thoại.
            td.CommonButtons = TaskDialogCommonButtons.Ok; // Hiển thị button OK / Yes / No / Retry....

            td.Show();

            // End Code
            return Result.Succeeded;
        }
    }
}