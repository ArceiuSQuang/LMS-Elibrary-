﻿namespace LMS_ELibrary.Model.DTO
{
    public class Xetduyet_Request_DTO
    {
        public int ID_Canduyet { get; set; }
        public int Status { get; set; }
        public string? Ghichu { get; set; }
        public int? ID_Nguoiduyet { get; set; }
    }
}