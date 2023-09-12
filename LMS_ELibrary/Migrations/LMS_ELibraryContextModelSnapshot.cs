﻿// <auto-generated />
using System;
using LMS_ELibrary.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LMS_ELibrary.Migrations
{
    [DbContext(typeof(LMS_ELibraryContext))]
    partial class LMS_ELibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LMS_ELibrary.Data.Avt_Db", b =>
            {
                b.Property<int>("AvtID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AvtID"), 1L, 1);

                b.Property<DateTime>("Ngay_tai_len")
                    .HasColumnType("datetime2");

                b.Property<string>("Path")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<double>("Size")
                    .HasColumnType("float");

                b.Property<int?>("UserId")
                    .HasColumnType("int");

                b.HasKey("AvtID");

                b.HasIndex("UserId");

                b.ToTable("Avt");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Chude_Db", b =>
            {
                b.Property<int>("ChudeID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChudeID"), 1L, 1);

                b.Property<string>("Tenchude")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.HasKey("ChudeID");

                b.ToTable("Chude");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Dethi_Db", b =>
            {
                b.Property<int>("DethiID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DethiID"), 1L, 1);

                b.Property<string>("File_Path")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Madethi")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");

                b.Property<int?>("MonhocID")
                    .HasColumnType("int");

                b.Property<DateTime>("Ngaytao")
                    .HasColumnType("datetime2");

                b.Property<int>("Status")
                    .HasColumnType("int");

                b.Property<int?>("UserID")
                    .HasColumnType("int");

                b.HasKey("DethiID");

                b.HasIndex("MonhocID");

                b.HasIndex("UserID");

                b.ToTable("Dethi");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Ex_QA_Db", b =>
            {
                b.Property<int>("EXQAID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EXQAID"), 1L, 1);

                b.Property<int?>("DethiID")
                    .HasColumnType("int");

                b.Property<int?>("QAID")
                    .HasColumnType("int");

                b.HasKey("EXQAID");

                b.HasIndex("DethiID");

                b.HasIndex("QAID");

                b.ToTable("Ex_QA");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Help_Db", b =>
            {
                b.Property<int>("HelpID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HelpID"), 1L, 1);

                b.Property<DateTime>("NgayGui")
                    .HasColumnType("datetime2");

                b.Property<string>("Noidung")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Tieude")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<int?>("UserID")
                    .HasColumnType("int");

                b.HasKey("HelpID");

                b.HasIndex("UserID");

                b.ToTable("Help");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Lopgiangday_Db", b =>
            {
                b.Property<int>("LopgiangdayID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LopgiangdayID"), 1L, 1);

                b.Property<int?>("MonhocID")
                    .HasColumnType("int");

                b.Property<string>("TenLop")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("Thoigian")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>("Truycapgannhat")
                    .HasColumnType("datetime2");

                b.Property<int?>("UserID")
                    .HasColumnType("int");

                b.HasKey("LopgiangdayID");

                b.HasIndex("MonhocID");

                b.HasIndex("UserID");

                b.ToTable("LopGiangday");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Monhoc_Db", b =>
            {
                b.Property<int>("MonhocID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MonhocID"), 1L, 1);

                b.Property<string>("MaMonhoc")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");

                b.Property<string>("Mota")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("TenMonhoc")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<int>("Tinhtrang")
                    .HasColumnType("int");

                b.Property<int?>("TobomonId")
                    .HasColumnType("int");

                b.HasKey("MonhocID");

                b.HasIndex("TobomonId");

                b.ToTable("Monhoc");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.QA_Db", b =>
            {
                b.Property<int>("QAID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QAID"), 1L, 1);

                b.Property<string>("Cauhoi")
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnType("nvarchar(300)");

                b.Property<string>("Cautrl")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("Lancuoisua")
                    .HasColumnType("datetime2");

                b.Property<int?>("MonhocID")
                    .HasColumnType("int");

                b.HasKey("QAID");

                b.HasIndex("MonhocID");

                b.ToTable("QA");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Tailieu_Baigiang_Db", b =>
            {
                b.Property<int>("DocId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocId"), 1L, 1);

                b.Property<int?>("ChudeID")
                    .HasColumnType("int");

                b.Property<double?>("Kichthuoc")
                    .HasColumnType("float");

                b.Property<int?>("MonhocID")
                    .HasColumnType("int");

                b.Property<string>("Path")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Status")
                    .HasColumnType("int");

                b.Property<DateTime?>("Sualancuoi")
                    .HasColumnType("datetime2");

                b.Property<string>("TenDoc")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Type")
                    .HasColumnType("int");

                b.Property<int?>("UserId")
                    .HasColumnType("int");

                b.HasKey("DocId");

                b.HasIndex("ChudeID");

                b.HasIndex("MonhocID");

                b.HasIndex("UserId");

                b.ToTable("Tailieu_Baigiang");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Thongbao_Db", b =>
            {
                b.Property<int>("ThongbaoID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ThongbaoID"), 1L, 1);

                b.Property<string>("Noidung")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Status")
                    .HasColumnType("int");

                b.Property<DateTime>("Thoigian")
                    .HasColumnType("datetime2");

                b.Property<string>("Tieude")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("UserID")
                    .HasColumnType("int");

                b.HasKey("ThongbaoID");

                b.HasIndex("UserID");

                b.ToTable("Thongbao");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Tobomon_Db", b =>
            {
                b.Property<int>("TobomonId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TobomonId"), 1L, 1);

                b.Property<string>("TobomonName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("TobomonId");

                b.ToTable("Tobomon");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.User_Db", b =>
            {
                b.Property<int>("UserID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                b.Property<string>("Avt")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("AvtId")
                    .HasColumnType("int");

                b.Property<string>("Diachi")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<bool?>("Gioitinh")
                    .HasColumnType("bit");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Role")
                    .HasColumnType("int");

                b.Property<string>("Sdt")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserFullname")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("UserName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("UserID");

                b.ToTable("User");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Avt_Db", b =>
            {
                b.HasOne("LMS_ELibrary.Data.User_Db", "User")
                    .WithMany("ListAvt")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Avt_User");

                b.Navigation("User");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Dethi_Db", b =>
            {
                b.HasOne("LMS_ELibrary.Data.Monhoc_Db", "Monhoc")
                    .WithMany("ListDethi")
                    .HasForeignKey("MonhocID");

                b.HasOne("LMS_ELibrary.Data.User_Db", "User")
                    .WithMany("ListDethi")
                    .HasForeignKey("UserID");

                b.Navigation("Monhoc");

                b.Navigation("User");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Ex_QA_Db", b =>
            {
                b.HasOne("LMS_ELibrary.Data.Dethi_Db", "Dethi")
                    .WithMany("ListExQA")
                    .HasForeignKey("DethiID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Ex_Qa_Dethi");

                b.HasOne("LMS_ELibrary.Data.QA_Db", "QA")
                    .WithMany("ListExQA")
                    .HasForeignKey("QAID");

                b.Navigation("Dethi");

                b.Navigation("QA");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Help_Db", b =>
            {
                b.HasOne("LMS_ELibrary.Data.User_Db", "User")
                    .WithMany("ListHelp")
                    .HasForeignKey("UserID");

                b.Navigation("User");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Lopgiangday_Db", b =>
            {
                b.HasOne("LMS_ELibrary.Data.Monhoc_Db", "Monhoc")
                    .WithMany("ListLopgiangday")
                    .HasForeignKey("MonhocID");

                b.HasOne("LMS_ELibrary.Data.User_Db", "User")
                    .WithMany("ListLopgiangday")
                    .HasForeignKey("UserID");

                b.Navigation("Monhoc");

                b.Navigation("User");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Monhoc_Db", b =>
            {
                b.HasOne("LMS_ELibrary.Data.Tobomon_Db", "Tobomon")
                    .WithMany("ListMonhoc")
                    .HasForeignKey("TobomonId");

                b.Navigation("Tobomon");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.QA_Db", b =>
            {
                b.HasOne("LMS_ELibrary.Data.Monhoc_Db", "Monhoc")
                    .WithMany("ListCauhoi")
                    .HasForeignKey("MonhocID");

                b.Navigation("Monhoc");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Tailieu_Baigiang_Db", b =>
            {
                b.HasOne("LMS_ELibrary.Data.Chude_Db", "Chude")
                    .WithMany("ListTailieu_Baigiang")
                    .HasForeignKey("ChudeID");

                b.HasOne("LMS_ELibrary.Data.Monhoc_Db", "Monhoc")
                    .WithMany("ListTailieu_Baigiang")
                    .HasForeignKey("MonhocID");

                b.HasOne("LMS_ELibrary.Data.User_Db", "User")
                    .WithMany("ListTailieu_Baigiang")
                    .HasForeignKey("UserId");

                b.Navigation("Chude");

                b.Navigation("Monhoc");

                b.Navigation("User");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Thongbao_Db", b =>
            {
                b.HasOne("LMS_ELibrary.Data.User_Db", "User")
                    .WithMany("ListThongbao")
                    .HasForeignKey("UserID");

                b.Navigation("User");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Chude_Db", b =>
            {
                b.Navigation("ListTailieu_Baigiang");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Dethi_Db", b =>
            {
                b.Navigation("ListExQA");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Monhoc_Db", b =>
            {
                b.Navigation("ListCauhoi");

                b.Navigation("ListDethi");

                b.Navigation("ListLopgiangday");

                b.Navigation("ListTailieu_Baigiang");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.QA_Db", b =>
            {
                b.Navigation("ListExQA");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.Tobomon_Db", b =>
            {
                b.Navigation("ListMonhoc");
            });

            modelBuilder.Entity("LMS_ELibrary.Data.User_Db", b =>
            {
                b.Navigation("ListAvt");

                b.Navigation("ListDethi");

                b.Navigation("ListHelp");

                b.Navigation("ListLopgiangday");

                b.Navigation("ListTailieu_Baigiang");

                b.Navigation("ListThongbao");
            });
#pragma warning restore 612, 618
        }
    }
}