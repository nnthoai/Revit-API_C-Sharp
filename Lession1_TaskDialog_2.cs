using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitAPI_MEP
{
    [Transaction(TransactionMode.Manual)]
    public class Lession1_TaskDialog_2 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // TaskDialog : Hiển Thị Thông Báo Với Nhiều Nút (Yes/No/Cancel)
            // 📌 Dùng khi bạn cần xác nhận hành động từ người dùng.

            // Hộp thoại 1 : Yêu cầu xác nhận hành động
            TaskDialog td = new TaskDialog("Xác nhận hành động"); // Tiêu đề chính của hộp thoại.

            td.MainInstruction = "Bạn có muốn tiếp tục?"; // Tiêu đề của nội dung.
            td.MainContent = "Hành động này có thể làm thay đổi mô hình Revit."; // Nội dung chi tiết.
            td.CommonButtons = TaskDialogCommonButtons.Yes | TaskDialogCommonButtons.No; // Các nút có thể chọn (Yes, No).
            td.DefaultButton = TaskDialogResult.Yes; // Nút mặc định khi nhấn Enter.


            // Hộp thoại 2 : Thông báo ket qua
            TaskDialogResult result = td.Show();

            if (result == TaskDialogResult.Yes)
            {
                TaskDialog.Show("Thông báo", "Bạn đã chọn YES!");
            }
            else
            {
                TaskDialog.Show("Thông báo", "Bạn đã chọn NO!");
            }
            // End Code
            return Result.Succeeded;
        }
    }
}