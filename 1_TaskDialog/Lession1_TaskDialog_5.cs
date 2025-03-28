using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitAPI_MEP
{
    [Transaction(TransactionMode.Manual)]
    public class Lession1_TaskDialog_5 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // TaskDialog với Checkbox : Xác Nhận Trước Khi Tiếp Tục.
            // 📌 Dùng khi cần người dùng đánh dấu checkbox trước khi tiếp tục.

            // Hộp thoại Cảnh báo
            TaskDialog td = new TaskDialog("Xác nhận"); // Tiêu đề chính của hộp thoại.

            td.MainInstruction = "Bạn có chắc chắn muốn tiếp tục?"; // Tiêu đề của nội dung.
            td.MainContent = "Hành động này không thể hoàn tác."; // Nội dung chi tiết.
            td.VerificationText = "Tôi đã đọc và đồng ý."; // Checkbox
            td.CommonButtons = TaskDialogCommonButtons.Ok | TaskDialogCommonButtons.Cancel;

            TaskDialogResult result = td.Show();

            if (td.WasVerificationChecked())
            {
                TaskDialog.Show("Thông báo", "Bạn đã xác nhận đồng ý!");
            }
            else
            {
                TaskDialog.Show("Thông báo", "Bạn chưa xác nhận!");
            }

            // End Code
            // End Code của TakeDialog_5
            return Result.Succeeded;
        }
    }
}