using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_DaiLy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "HeThongPhanPhoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DienThoai",
                table: "HeThongPhanPhoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "HeThongPhanPhoi",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaDaiLy",
                table: "HeThongPhanPhoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiDaiDien",
                table: "HeThongPhanPhoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenDaiLy",
                table: "HeThongPhanPhoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ma_HTPP",
                table: "HeThongPhanPhoi",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "DienThoai",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "MaDaiLy",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "NguoiDaiDien",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "TenDaiLy",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "ma_HTPP",
                table: "HeThongPhanPhoi");
        }
    }
}
