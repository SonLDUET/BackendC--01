using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class fix_somethings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaiViets_ChuDes_ChuDeId",
                table: "BaiViets");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiViets_TaiKhoans_TaiKhoanId",
                table: "BaiViets");

            migrationBuilder.DropForeignKey(
                name: "FK_ChuDes_LoaiBaiViets_LoaiBaiVietId",
                table: "ChuDes");

            migrationBuilder.DropForeignKey(
                name: "FK_DangKiHocs_HocViens_HocVienId",
                table: "DangKiHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_DangKiHocs_KhoaHocs_KhoaHocId",
                table: "DangKiHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_DangKiHocs_TaiKhoans_TaiKhoanId",
                table: "DangKiHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_DangKiHocs_TinhTrangHocs_TinhTrangHocId",
                table: "DangKiHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_KhoaHocs_LoaiKhoaHocs_LoaikhoaHocId",
                table: "KhoaHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_TaiKhoans_QuyenHans_QuyenHanId",
                table: "TaiKhoans");

            migrationBuilder.AlterColumn<string>(
                name: "TenTinhTrang",
                table: "TinhTrangHocs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TenTaiKhoan",
                table: "TaiKhoans",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TenNguoiDung",
                table: "TaiKhoans",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "QuyenHanId",
                table: "TaiKhoans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "TaiKhoans",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TenQuyenhan",
                table: "QuyenHans",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TenLoaiKhoahoc",
                table: "LoaiKhoaHocs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TenLoai",
                table: "LoaiBaiViets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TenKhoaHoc",
                table: "KhoaHocs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SoLuongMon",
                table: "KhoaHocs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NoiDung",
                table: "KhoaHocs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "LoaikhoaHocId",
                table: "KhoaHocs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HocPhi",
                table: "KhoaHocs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "HinhAnh",
                table: "KhoaHocs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GioiThieu",
                table: "KhoaHocs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ThoiGianHoc",
                table: "KhoaHocs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "TinhThanh",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SoNha",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SDT",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "QuanHuyen",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhuongXa",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Hoten",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HinhAnh",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySinh",
                table: "HocViens",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayKetThuc",
                table: "DangKiHocs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "TinhTrangHocId",
                table: "DangKiHocs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TaiKhoanId",
                table: "DangKiHocs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayDangKi",
                table: "DangKiHocs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "KhoaHocId",
                table: "DangKiHocs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HocVienId",
                table: "DangKiHocs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TenChuDe",
                table: "ChuDes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NoiDung",
                table: "ChuDes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "LoaiBaiVietId",
                table: "ChuDes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TenTacGia",
                table: "BaiViets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TenBaiViet",
                table: "BaiViets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TaiKhoanId",
                table: "BaiViets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NoiDungNgan",
                table: "BaiViets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NoiDung",
                table: "BaiViets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "BaiViets",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ChuDeId",
                table: "BaiViets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiViets_ChuDes_ChuDeId",
                table: "BaiViets",
                column: "ChuDeId",
                principalTable: "ChuDes",
                principalColumn: "ChuDeId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaiViets_TaiKhoans_TaiKhoanId",
                table: "BaiViets",
                column: "TaiKhoanId",
                principalTable: "TaiKhoans",
                principalColumn: "TaiKhoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuDes_LoaiBaiViets_LoaiBaiVietId",
                table: "ChuDes",
                column: "LoaiBaiVietId",
                principalTable: "LoaiBaiViets",
                principalColumn: "LoaiBaiVietId");

            migrationBuilder.AddForeignKey(
                name: "FK_DangKiHocs_HocViens_HocVienId",
                table: "DangKiHocs",
                column: "HocVienId",
                principalTable: "HocViens",
                principalColumn: "HocVienId");

            migrationBuilder.AddForeignKey(
                name: "FK_DangKiHocs_KhoaHocs_KhoaHocId",
                table: "DangKiHocs",
                column: "KhoaHocId",
                principalTable: "KhoaHocs",
                principalColumn: "KhoaHocId");

            migrationBuilder.AddForeignKey(
                name: "FK_DangKiHocs_TaiKhoans_TaiKhoanId",
                table: "DangKiHocs",
                column: "TaiKhoanId",
                principalTable: "TaiKhoans",
                principalColumn: "TaiKhoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_DangKiHocs_TinhTrangHocs_TinhTrangHocId",
                table: "DangKiHocs",
                column: "TinhTrangHocId",
                principalTable: "TinhTrangHocs",
                principalColumn: "TinhTrangHocid");

            migrationBuilder.AddForeignKey(
                name: "FK_KhoaHocs_LoaiKhoaHocs_LoaikhoaHocId",
                table: "KhoaHocs",
                column: "LoaikhoaHocId",
                principalTable: "LoaiKhoaHocs",
                principalColumn: "LoaiKhoaHocId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaiKhoans_QuyenHans_QuyenHanId",
                table: "TaiKhoans",
                column: "QuyenHanId",
                principalTable: "QuyenHans",
                principalColumn: "QuyenHanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaiViets_ChuDes_ChuDeId",
                table: "BaiViets");

            migrationBuilder.DropForeignKey(
                name: "FK_BaiViets_TaiKhoans_TaiKhoanId",
                table: "BaiViets");

            migrationBuilder.DropForeignKey(
                name: "FK_ChuDes_LoaiBaiViets_LoaiBaiVietId",
                table: "ChuDes");

            migrationBuilder.DropForeignKey(
                name: "FK_DangKiHocs_HocViens_HocVienId",
                table: "DangKiHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_DangKiHocs_KhoaHocs_KhoaHocId",
                table: "DangKiHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_DangKiHocs_TaiKhoans_TaiKhoanId",
                table: "DangKiHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_DangKiHocs_TinhTrangHocs_TinhTrangHocId",
                table: "DangKiHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_KhoaHocs_LoaiKhoaHocs_LoaikhoaHocId",
                table: "KhoaHocs");

            migrationBuilder.DropForeignKey(
                name: "FK_TaiKhoans_QuyenHans_QuyenHanId",
                table: "TaiKhoans");

            migrationBuilder.DropColumn(
                name: "ThoiGianHoc",
                table: "KhoaHocs");

            migrationBuilder.DropColumn(
                name: "NgaySinh",
                table: "HocViens");

            migrationBuilder.AlterColumn<string>(
                name: "TenTinhTrang",
                table: "TinhTrangHocs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenTaiKhoan",
                table: "TaiKhoans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenNguoiDung",
                table: "TaiKhoans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuyenHanId",
                table: "TaiKhoans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "TaiKhoans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenQuyenhan",
                table: "QuyenHans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenLoaiKhoahoc",
                table: "LoaiKhoaHocs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenLoai",
                table: "LoaiBaiViets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenKhoaHoc",
                table: "KhoaHocs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SoLuongMon",
                table: "KhoaHocs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoiDung",
                table: "KhoaHocs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LoaikhoaHocId",
                table: "KhoaHocs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HocPhi",
                table: "KhoaHocs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HinhAnh",
                table: "KhoaHocs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GioiThieu",
                table: "KhoaHocs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TinhThanh",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SoNha",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SDT",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "QuanHuyen",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhuongXa",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Hoten",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HinhAnh",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "HocViens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ngayKetThuc",
                table: "DangKiHocs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TinhTrangHocId",
                table: "DangKiHocs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaiKhoanId",
                table: "DangKiHocs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayDangKi",
                table: "DangKiHocs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KhoaHocId",
                table: "DangKiHocs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HocVienId",
                table: "DangKiHocs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenChuDe",
                table: "ChuDes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoiDung",
                table: "ChuDes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LoaiBaiVietId",
                table: "ChuDes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenTacGia",
                table: "BaiViets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenBaiViet",
                table: "BaiViets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaiKhoanId",
                table: "BaiViets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoiDungNgan",
                table: "BaiViets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoiDung",
                table: "BaiViets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayTao",
                table: "BaiViets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChuDeId",
                table: "BaiViets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BaiViets_ChuDes_ChuDeId",
                table: "BaiViets",
                column: "ChuDeId",
                principalTable: "ChuDes",
                principalColumn: "ChuDeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaiViets_TaiKhoans_TaiKhoanId",
                table: "BaiViets",
                column: "TaiKhoanId",
                principalTable: "TaiKhoans",
                principalColumn: "TaiKhoanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChuDes_LoaiBaiViets_LoaiBaiVietId",
                table: "ChuDes",
                column: "LoaiBaiVietId",
                principalTable: "LoaiBaiViets",
                principalColumn: "LoaiBaiVietId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DangKiHocs_HocViens_HocVienId",
                table: "DangKiHocs",
                column: "HocVienId",
                principalTable: "HocViens",
                principalColumn: "HocVienId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DangKiHocs_KhoaHocs_KhoaHocId",
                table: "DangKiHocs",
                column: "KhoaHocId",
                principalTable: "KhoaHocs",
                principalColumn: "KhoaHocId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DangKiHocs_TaiKhoans_TaiKhoanId",
                table: "DangKiHocs",
                column: "TaiKhoanId",
                principalTable: "TaiKhoans",
                principalColumn: "TaiKhoanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DangKiHocs_TinhTrangHocs_TinhTrangHocId",
                table: "DangKiHocs",
                column: "TinhTrangHocId",
                principalTable: "TinhTrangHocs",
                principalColumn: "TinhTrangHocid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KhoaHocs_LoaiKhoaHocs_LoaikhoaHocId",
                table: "KhoaHocs",
                column: "LoaikhoaHocId",
                principalTable: "LoaiKhoaHocs",
                principalColumn: "LoaiKhoaHocId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaiKhoans_QuyenHans_QuyenHanId",
                table: "TaiKhoans",
                column: "QuyenHanId",
                principalTable: "QuyenHans",
                principalColumn: "QuyenHanId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
