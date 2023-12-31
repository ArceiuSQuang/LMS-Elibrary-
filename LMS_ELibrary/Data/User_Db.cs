﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_ELibrary.Data
{
    [Table("User")]
    public class User_Db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public string? MaUser { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public int? Role { get; set; }
        public string? Avt { get; set; }
        [Required]
        public string UserFullname { get; set; }
        public bool? Gioitinh { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Sdt { get; set; }
        public string? Diachi { get; set; }
        public int? AvtId { get; set; }
        public string? Nganh { get; set; }
        public DateTime? Ngaysuadoi { get; set; }

        public virtual List<Avt_Db>? ListAvt { get; set; }
        public virtual List<Lopgiangday_Db>? ListLopgiangday { get; set; }
        public virtual List<Tailieu_Baigiang_Db>? ListTailieu_Baigiang { get; set; }
        public virtual List<Dethi_Db>? ListDethi { get; set; }
        public virtual List<Thongbao_Db>? ListThongbao { get; set; }
        public virtual List<Help_Db>? ListHelp { get; set; }
        public virtual List<File_Dethi_Db>? list_File_Dethi { get; set; }
        public virtual List<MonhocYeuthich_Db>? list_Monhocyeuthich { get; set; }
        public virtual List<CauhoiVandap_Db>? list_CauhoiVandap { get; set; }
        public virtual List<Cautrl_Db>? list_Cautrl { get; set; }
        public virtual List<CauhoiYeuthich_Db>? list_Cauhoiyeuthich { get; set; }
        public virtual List<Monhoc_Db>? list_Mongiangday { get; set; }
        public virtual Role_Db? RoleDb { get; set; }
        public virtual List<Hocvien_Lop_Db>? list_HocvienLop { get; set; }
        public virtual List<ThongbaoLop_Db>? list_Thongbao { get; set; }
        public virtual List<QA_Db>? list_Cauhoi_Datao { get; set; }
        public virtual List<File_Tailen_Db>? list_File_Tailen { get; set; }
        public virtual List<Tainguyen_Db>? list_Tainguyen { get; set; }

    }
}