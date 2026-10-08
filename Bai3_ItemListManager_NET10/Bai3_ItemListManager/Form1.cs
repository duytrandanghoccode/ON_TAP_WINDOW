using System.Globalization;

namespace Bai3_ItemListManager;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        cboDonViTinh.SelectedIndex = 0;
    }

    private bool KiemTraDuLieu(out decimal donGia)
    {
        donGia = 0;

        if (string.IsNullOrWhiteSpace(txtMaVT.Text))
        {
            MessageBox.Show("Vui lòng nhập Mã vật tư!", "Thiếu dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaVT.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtTenVT.Text))
        {
            MessageBox.Show("Vui lòng nhập Tên vật tư!", "Thiếu dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenVT.Focus();
            return false;
        }

        if (!decimal.TryParse(txtDonGia.Text, out donGia) || donGia < 0)
        {
            MessageBox.Show("Đơn giá phải là số hợp lệ và không âm!", "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDonGia.Focus();
            return false;
        }

        return true;
    }

    private bool MaDaTonTai(string ma, ListViewItem? boQua = null)
    {
        foreach (ListViewItem item in lvVatTu.Items)
        {
            if (item == boQua) continue;

            if (string.Equals(item.Text.Trim(), ma.Trim(), StringComparison.OrdinalIgnoreCase))
                return true;
        }

        return false;
    }

    private void btnThemMoi_Click(object sender, EventArgs e)
    {
        if (!KiemTraDuLieu(out decimal donGia)) return;

        string ma = txtMaVT.Text.Trim();

        if (MaDaTonTai(ma))
        {
            MessageBox.Show("Mã vật tư đã tồn tại trong danh sách!", "Trùng mã",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaVT.Focus();
            txtMaVT.SelectAll();
            return;
        }

        ListViewItem item = new(ma);
        item.SubItems.Add(txtTenVT.Text.Trim());
        item.SubItems.Add(cboDonViTinh.Text);
        item.SubItems.Add(donGia.ToString("N0"));

        lvVatTu.Items.Add(item);
        XoaOThongTin();

        MessageBox.Show("Thêm vật tư thành công!", "Thông báo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnCapNhat_Click(object sender, EventArgs e)
    {
        if (lvVatTu.SelectedItems.Count == 0)
        {
            MessageBox.Show("Hãy chọn một dòng cần cập nhật!", "Chưa chọn dòng",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!KiemTraDuLieu(out decimal donGia)) return;

        ListViewItem item = lvVatTu.SelectedItems[0];
        string maMoi = txtMaVT.Text.Trim();

        if (MaDaTonTai(maMoi, item))
        {
            MessageBox.Show("Mã vật tư mới bị trùng với một dòng khác!", "Trùng mã",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        item.Text = maMoi;
        item.SubItems[1].Text = txtTenVT.Text.Trim();
        item.SubItems[2].Text = cboDonViTinh.Text;
        item.SubItems[3].Text = donGia.ToString("N0");

        MessageBox.Show("Cập nhật thành công!", "Thông báo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnXoaDong_Click(object sender, EventArgs e)
    {
        if (lvVatTu.SelectedItems.Count == 0)
        {
            MessageBox.Show("Hãy chọn dòng cần xóa!", "Chưa chọn dòng",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DialogResult result = MessageBox.Show(
            "Bạn có chắc muốn xóa dòng đang chọn không?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            lvVatTu.Items.Remove(lvVatTu.SelectedItems[0]);
            XoaOThongTin();
        }
    }

    private void btnXoaTatCa_Click(object sender, EventArgs e)
    {
        if (lvVatTu.Items.Count == 0) return;

        DialogResult result = MessageBox.Show(
            "Bạn có chắc muốn xóa TOÀN BỘ danh sách không?",
            "Xác nhận xóa toàn bộ",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (result == DialogResult.Yes)
        {
            lvVatTu.Items.Clear();
            XoaOThongTin();
        }
    }

    private void lvVatTu_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvVatTu.SelectedItems.Count == 0) return;

        ListViewItem item = lvVatTu.SelectedItems[0];

        txtMaVT.Text = item.Text;
        txtTenVT.Text = item.SubItems[1].Text;
        cboDonViTinh.Text = item.SubItems[2].Text;
        txtDonGia.Text = item.SubItems[3].Text.Replace(",", "");
    }

    private void XoaOThongTin()
    {
        txtMaVT.Clear();
        txtTenVT.Clear();
        txtDonGia.Clear();
        cboDonViTinh.SelectedIndex = 0;
        txtMaVT.Focus();
    }
}
