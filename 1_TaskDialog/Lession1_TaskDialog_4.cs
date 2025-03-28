using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitAPI_MEP
{
    [Transaction(TransactionMode.Manual)]
    public class Lession1_TaskDialog_4 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // TaskDialog : Hiển Thị các lựa chọn.
            // 📌 Dùng khi cần cung cấp nhiều lựa chọn hơn Yes/No.

            // Hộp thoại Cảnh báo
            TaskDialog td = new TaskDialog("Chọn phương án"); // Tiêu đề chính của hộp thoại.

            td.MainInstruction = "Hiển thị các lựa chọn."; // Tiêu đề của nội dung.
            td.MainContent = "Bạn muốn thực hiện thao tác nào?"; // Nội dung chi tiết.
            td.AddCommandLink(TaskDialogCommandLinkId.CommandLink1, "Lựa chọn 1: Xử lý dữ liệu 1");
            td.AddCommandLink(TaskDialogCommandLinkId.CommandLink2, "Lựa chọn 2: Xử lý dữ liệu 2");
            td.AddCommandLink(TaskDialogCommandLinkId.CommandLink3, "Lựa chọn 3: Thoát mà không thay đổi");

            TaskDialogResult result = td.Show();

            if (result == TaskDialogResult.CommandLink1)
            {
                TaskDialog.Show("Thông báo", "Bạn đã chọn Xử lý dữ liệu 1.");
            }
            else if (result == TaskDialogResult.CommandLink2)
            {
                TaskDialog.Show("Thông báo", "Bạn đã chọn Xử lý dữ liệu 2.");
            }
            else
            {
                TaskDialog.Show("Thông báo", "Bạn đã chọn Thoát mà không thay đổi.");
            }

            // End Code
            return Result.Succeeded;
        }
    }
}