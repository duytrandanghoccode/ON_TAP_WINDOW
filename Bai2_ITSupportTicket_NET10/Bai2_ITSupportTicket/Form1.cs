using System.Text;

namespace Bai2_ITSupportTicket;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        cboLoaiSuCo.SelectedIndex = 0;
        radTrungBinh.Checked = true;
        dtpNgayGhiNhan.Value = DateTime.Now;
    }

    private void btnTaiAnh_Click(object sender, EventArgs e)
    {
        using OpenFileDialog dialog = new();
        dialog.Title = "Chọn ảnh chụp lỗi";
        dialog.Filter = "Tệp hình ảnh|*.jpg;*.jpeg;*.png|JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            using Image temp = Image.FromFile(dialog.FileName);
            picAnhLoi.Image?.Dispose();
            picAnhLoi.Image = new Bitmap(temp);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }

    private void btnGuiYeuCau_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
        {
            MessageBox.Show("Vui lòng nhập Mã phiếu!", "Thiếu dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaPhieu.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
        {
            MessageBox.Show("Vui lòng nhập Người yêu cầu!", "Thiếu dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNguoiYeuCau.Focus();
            return;
        }

        string mucDo = radThap.Checked ? "Thấp"
            : radKhanCap.Checked ? "Khẩn cấp"
            : "Trung bình";

        List<string> thietBi = new();
        if (chkMayTinhBan.Checked) thietBi.Add("Máy tính bàn");
        if (chkLaptop.Checked) thietBi.Add("Laptop");
        if (chkMayIn.Checked) thietBi.Add("Máy in");
        if (chkDienThoai.Checked) thietBi.Add("Điện thoại");

        string dsThietBi = thietBi.Count > 0
            ? string.Join(", ", thietBi)
            : "Chưa chọn";

        StringBuilder sb = new();
        sb.AppendLine("TÓM TẮT PHIẾU HỖ TRỢ IT");
        sb.AppendLine("------------------------------");
        sb.AppendLine($"Mã phiếu: {txtMaPhieu.Text.Trim()}");
        sb.AppendLine($"Người yêu cầu: {txtNguoiYeuCau.Text.Trim()}");
        sb.AppendLine($"Ngày ghi nhận: {dtpNgayGhiNhan.Value:dd/MM/yyyy}");
        sb.AppendLine($"Mức độ ưu tiên: {mucDo}");
        sb.AppendLine($"Loại sự cố: {cboLoaiSuCo.Text}");
        sb.AppendLine($"Thiết bị ảnh hưởng: {dsThietBi}");
        sb.AppendLine($"Ảnh lỗi: {(picAnhLoi.Image != null ? "Đã đính kèm" : "Chưa có")}");

        MessageBox.Show(sb.ToString(), "Gửi yêu cầu thành công",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnNhapLai_Click(object sender, EventArgs e)
    {
        txtMaPhieu.Clear();
        txtNguoiYeuCau.Clear();
        dtpNgayGhiNhan.Value = DateTime.Now;

        radThap.Checked = false;
        radTrungBinh.Checked = true;
        radKhanCap.Checked = false;

        cboLoaiSuCo.SelectedIndex = 0;

        chkMayTinhBan.Checked = false;
        chkLaptop.Checked = false;
        chkMayIn.Checked = false;
        chkDienThoai.Checked = false;

        picAnhLoi.Image?.Dispose();
        picAnhLoi.Image = null;

        txtMaPhieu.Focus();
    }
}
