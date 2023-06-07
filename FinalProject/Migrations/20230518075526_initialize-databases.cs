using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class initializedatabases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HocViens",
                columns: table => new
                {
                    HocVienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hoten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhThanh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuanHuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhuongXa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoNha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocViens", x => x.HocVienId);
                });

            migrationBuilder.CreateTable(
                name: "LoaiBaiViets",
                columns: table => new
                {
                    LoaiBaiVietId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiBaiViets", x => x.LoaiBaiVietId);
                });

            migrationBuilder.CreateTable(
                name: "LoaiKhoaHocs",
                columns: table => new
                {
                    LoaiKhoaHocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiKhoahoc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiKhoaHocs", x => x.LoaiKhoaHocId);
                });

            migrationBuilder.CreateTable(
                name: "QuyenHans",
                columns: table => new
                {
                    QuyenHanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQuyenhan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyenHans", x => x.QuyenHanId);
                });

            migrationBuilder.CreateTable(
                name: "TinhTrangHocs",
                columns: table => new
                {
                    TinhTrangHocid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhTrangHocs", x => x.TinhTrangHocid);
                });

            migrationBuilder.CreateTable(
                name: "ChuDes",
                columns: table => new
                {
                    ChuDeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuDe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiBaiVietId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuDes", x => x.ChuDeId);
                    table.ForeignKey(
                        name: "FK_ChuDes_LoaiBaiViets_LoaiBaiVietId",
                        column: x => x.LoaiBaiVietId,
                        principalTable: "LoaiBaiViets",
                        principalColumn: "LoaiBaiVietId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHocs",
                columns: table => new
                {
                    KhoaHocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoaHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiThieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaikhoaHocId = table.Column<int>(type: "int", nullable: false),
                    SoLuongMon = table.Column<int>(type: "int", nullable: false),
                    SoHocVien = table.Column<int>(type: "int", nullable: false),
                    HocPhi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHocs", x => x.KhoaHocId);
                    table.ForeignKey(
                        name: "FK_KhoaHocs_LoaiKhoaHocs_LoaikhoaHocId",
                        column: x => x.LoaikhoaHocId,
                        principalTable: "LoaiKhoaHocs",
                        principalColumn: "LoaiKhoaHocId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    TaiKhoanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNguoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuyenHanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.TaiKhoanId);
                    table.ForeignKey(
                        name: "FK_TaiKhoans_QuyenHans_QuyenHanId",
                        column: x => x.QuyenHanId,
                        principalTable: "QuyenHans",
                        principalColumn: "QuyenHanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaiViets",
                columns: table => new
                {
                    BaiVietId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBaiViet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenTacGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiDungNgan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChuDeId = table.Column<int>(type: "int", nullable: false),
                    TaiKhoanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiViets", x => x.BaiVietId);
                    table.ForeignKey(
                        name: "FK_BaiViets_ChuDes_ChuDeId",
                        column: x => x.ChuDeId,
                        principalTable: "ChuDes",
                        principalColumn: "ChuDeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaiViets_TaiKhoans_TaiKhoanId",
                        column: x => x.TaiKhoanId,
                        principalTable: "TaiKhoans",
                        principalColumn: "TaiKhoanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DangKiHocs",
                columns: table => new
                {
                    DangKiHocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoaHocId = table.Column<int>(type: "int", nullable: false),
                    HocVienId = table.Column<int>(type: "int", nullable: false),
                    NgayDangKi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinhTrangHocId = table.Column<int>(type: "int", nullable: false),
                    TaiKhoanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangKiHocs", x => x.DangKiHocId);
                    table.ForeignKey(
                        name: "FK_DangKiHocs_HocViens_HocVienId",
                        column: x => x.HocVienId,
                        principalTable: "HocViens",
                        principalColumn: "HocVienId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DangKiHocs_KhoaHocs_KhoaHocId",
                        column: x => x.KhoaHocId,
                        principalTable: "KhoaHocs",
                        principalColumn: "KhoaHocId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DangKiHocs_TaiKhoans_TaiKhoanId",
                        column: x => x.TaiKhoanId,
                        principalTable: "TaiKhoans",
                        principalColumn: "TaiKhoanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DangKiHocs_TinhTrangHocs_TinhTrangHocId",
                        column: x => x.TinhTrangHocId,
                        principalTable: "TinhTrangHocs",
                        principalColumn: "TinhTrangHocid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaiViets_ChuDeId",
                table: "BaiViets",
                column: "ChuDeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaiViets_TaiKhoanId",
                table: "BaiViets",
                column: "TaiKhoanId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuDes_LoaiBaiVietId",
                table: "ChuDes",
                column: "LoaiBaiVietId");

            migrationBuilder.CreateIndex(
                name: "IX_DangKiHocs_HocVienId",
                table: "DangKiHocs",
                column: "HocVienId");

            migrationBuilder.CreateIndex(
                name: "IX_DangKiHocs_KhoaHocId",
                table: "DangKiHocs",
                column: "KhoaHocId");

            migrationBuilder.CreateIndex(
                name: "IX_DangKiHocs_TaiKhoanId",
                table: "DangKiHocs",
                column: "TaiKhoanId");

            migrationBuilder.CreateIndex(
                name: "IX_DangKiHocs_TinhTrangHocId",
                table: "DangKiHocs",
                column: "TinhTrangHocId");

            migrationBuilder.CreateIndex(
                name: "IX_KhoaHocs_LoaikhoaHocId",
                table: "KhoaHocs",
                column: "LoaikhoaHocId");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_QuyenHanId",
                table: "TaiKhoans",
                column: "QuyenHanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaiViets");

            migrationBuilder.DropTable(
                name: "DangKiHocs");

            migrationBuilder.DropTable(
                name: "ChuDes");

            migrationBuilder.DropTable(
                name: "HocViens");

            migrationBuilder.DropTable(
                name: "KhoaHocs");

            migrationBuilder.DropTable(
                name: "TaiKhoans");

            migrationBuilder.DropTable(
                name: "TinhTrangHocs");

            migrationBuilder.DropTable(
                name: "LoaiBaiViets");

            migrationBuilder.DropTable(
                name: "LoaiKhoaHocs");

            migrationBuilder.DropTable(
                name: "QuyenHans");
        }
    }
}
