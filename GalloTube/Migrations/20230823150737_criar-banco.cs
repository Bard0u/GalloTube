using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalloTube.Migrations
{
    public partial class criarbanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "42097715-49f1-4435-a4bb-1f3bd3b579a9");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e7954d61-3d11-4fc5-aa77-0bd5e661d2b4");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "adc58412-d38c-4138-8142-78045f5db7b8", "3c5141ad-8abd-4e48-9a47-7668ddf369c8" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "adc58412-d38c-4138-8142-78045f5db7b8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3c5141ad-8abd-4e48-9a47-7668ddf369c8");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "51acc031-a3e6-4b1d-a742-7e6f716d1e99", "8f154bd7-7366-4c86-a041-f2fd2d1a8a86", "Moderador", "MODERADOR" },
                    { "be693ff1-206d-4e8c-870c-cd95816efd44", "1c485cae-5d42-42da-b1cf-1ee8f19db4e9", "Administrador", "ADMINISTRADOR" },
                    { "d7f37244-1229-43a8-9121-96020d496007", "18ae9673-df57-4e22-be67-7e10d9b16871", "Usuário", " USUÁRIO" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d0dbd86a-d05d-4626-8e4f-6fb2a415f8d2", 0, "348c7060-27ff-49b3-8cef-8f0936a84904", new DateTime(2005, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "admin@gmail.com", true, false, null, "Seu Nome Completo", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEPh4Q3Bhq/ewhE8bbjbcOzyu/Xr8ABHK09eJpGjLwAmiWPHtamrTQHL1dfZLvK897w==", "14912345678", true, "/img/users/avatar.png", "cd9c0afa-20fd-4093-831b-0deb5c3384b5", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "be693ff1-206d-4e8c-870c-cd95816efd44", "d0dbd86a-d05d-4626-8e4f-6fb2a415f8d2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "51acc031-a3e6-4b1d-a742-7e6f716d1e99");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d7f37244-1229-43a8-9121-96020d496007");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "be693ff1-206d-4e8c-870c-cd95816efd44", "d0dbd86a-d05d-4626-8e4f-6fb2a415f8d2" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "be693ff1-206d-4e8c-870c-cd95816efd44");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d0dbd86a-d05d-4626-8e4f-6fb2a415f8d2");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42097715-49f1-4435-a4bb-1f3bd3b579a9", "ec32e2c2-d3d1-4517-bbb5-e0d25387efef", "Usuário", " USUÁRIO" },
                    { "adc58412-d38c-4138-8142-78045f5db7b8", "39c90916-c50c-42d5-b983-acc65847c1d9", "Administrador", "ADMINISTRADOR" },
                    { "e7954d61-3d11-4fc5-aa77-0bd5e661d2b4", "9c5b08d1-0516-4264-b048-569836d1c23c", "Moderador", "MODERADOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3c5141ad-8abd-4e48-9a47-7668ddf369c8", 0, "9d044279-7e9a-4382-86aa-7fbe3816d630", new DateTime(2005, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "admin@gmail.com", true, false, null, "Seu Nome Completo", "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAELlyI7Dx4gPcxUndozMh3VuFc9jGEx61h9ZJQqgaEO0P9/oy+ISVw88HJmdVw0EoPw==", "14912345678", true, "/img/users/avatar.png", "777b35a7-117e-4ee5-9a28-8c8e20adca9f", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "adc58412-d38c-4138-8142-78045f5db7b8", "3c5141ad-8abd-4e48-9a47-7668ddf369c8" });
        }
    }
}
