using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace De_Thi_Mau.Models;

public partial class HangHoa
{
    public int MaHang { get; set; }
    [Required(ErrorMessage = "Vui lòng chọn loại hàng")]
    public int MaLoai { get; set; }
    [Required(ErrorMessage = "Không để trống tên hàng")]
    [StringLength(50)]
    public string TenHang { get; set; } = null!;
    [Required(ErrorMessage = "Giá không được để trống")]
    [Range(100, 5000, ErrorMessage = "Giá phải là số và nằm trong giới hạn 100 đến 5000")]
    public decimal? Gia { get; set; }
    [Required(ErrorMessage = "Tên file ảnh không được để trống")]
    [RegularExpression(@"^.*\.(jpg|JPG|png|PNG|gif|GIF|tiff|TIFF)$", ErrorMessage = "Tên file ảnh phải có đuôi: .jpg | .png | .gif | .tiff")]
    public string? Anh { get; set; }

    public virtual LoaiHang MaLoaiNavigation { get; set; } = null!;
}
