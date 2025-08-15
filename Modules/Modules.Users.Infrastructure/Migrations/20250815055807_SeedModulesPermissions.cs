using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedModulesPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationModules",
                columns: new[] { "ModuleId", "ModuleName" },
                values: new object[,]
                {
                    { "0983f651-ea9", "Cashier" },
                    { "1e5b4b1c-b5d", "Complaints" },
                    { "23e7ffbf-762", "Billing" },
                    { "421070d5-37b", "Users" },
                    { "53a24ec6-b42", "Property" },
                    { "9a421337-c47", "Facilities" },
                    { "a4a39f7a-bd6", "Legal" },
                    { "e63107bf-457", "Customers" },
                    { "e6f9be9e-a28", "Notification" }
                });

            migrationBuilder.InsertData(
                table: "ModulesPermissions",
                columns: new[] { "ModulesPermissionsId", "ModuleId", "PermissionName" },
                values: new object[,]
                {
                    { 1, "0983f651-ea9", "CREATE" },
                    { 2, "0983f651-ea9", "READ" },
                    { 3, "0983f651-ea9", "UPDATE" },
                    { 4, "0983f651-ea9", "DELETE" },
                    { 5, "1e5b4b1c-b5d", "CREATE" },
                    { 6, "1e5b4b1c-b5d", "READ" },
                    { 7, "1e5b4b1c-b5d", "UPDATE" },
                    { 8, "1e5b4b1c-b5d", "DELETE" },
                    { 9, "1e5b4b1c-b5d", "ACKNOWLEDGE" },
                    { 10, "1e5b4b1c-b5d", "DISPATCH" },
                    { 11, "1e5b4b1c-b5d", "REVIEW" },
                    { 12, "1e5b4b1c-b5d", "ASSIGN" },
                    { 13, "1e5b4b1c-b5d", "RESOLVE" },
                    { 14, "1e5b4b1c-b5d", "REOPEN" },
                    { 15, "1e5b4b1c-b5d", "CLOSE" },
                    { 16, "1e5b4b1c-b5d", "CANCEL" },
                    { 17, "1e5b4b1c-b5d", "INPROGRESS" },
                    { 18, "23e7ffbf-762", "CREATE" },
                    { 19, "23e7ffbf-762", "READ" },
                    { 20, "23e7ffbf-762", "UPDATE" },
                    { 21, "23e7ffbf-762", "DELETE" },
                    { 22, "421070d5-37b", "CREATE" },
                    { 23, "421070d5-37b", "READ" },
                    { 24, "421070d5-37b", "UPDATE" },
                    { 25, "421070d5-37b", "DELETE" },
                    { 26, "421070d5-37b", "VERIFY" },
                    { 27, "421070d5-37b", "REJECT" },
                    { 28, "421070d5-37b", "APPROVE" },
                    { 29, "421070d5-37b", "DISAPPROVE" },
                    { 30, "421070d5-37b", "ACTIVATE" },
                    { 31, "421070d5-37b", "DEACTIVATE" },
                    { 32, "421070d5-37b", "ASSIGNUSER" },
                    { 33, "421070d5-37b", "ASSIGNPERMISSION" },
                    { 34, "53a24ec6-b42", "CREATE" },
                    { 35, "53a24ec6-b42", "READ" },
                    { 36, "53a24ec6-b42", "UPDATE" },
                    { 37, "53a24ec6-b42", "DELETE" },
                    { 38, "53a24ec6-b42", "STOPDEBIT" },
                    { 39, "53a24ec6-b42", "STARTDEBIT" },
                    { 40, "53a24ec6-b42", "ASSIGN" },
                    { 41, "53a24ec6-b42", "NEWLEASE" },
                    { 42, "53a24ec6-b42", "RENEWLEASE" },
                    { 43, "9a421337-c47", "CREATE" },
                    { 44, "9a421337-c47", "READ" },
                    { 45, "9a421337-c47", "UPDATE" },
                    { 46, "9a421337-c47", "DELETE" },
                    { 47, "a4a39f7a-bd6", "CREATE" },
                    { 48, "a4a39f7a-bd6", "READ" },
                    { 49, "a4a39f7a-bd6", "UPDATE" },
                    { 50, "a4a39f7a-bd6", "DELETE" },
                    { 51, "e63107bf-457", "CREATE" },
                    { 52, "e63107bf-457", "READ" },
                    { 53, "e63107bf-457", "UPDATE" },
                    { 54, "e63107bf-457", "DELETE" },
                    { 55, "e63107bf-457", "STOPDEBIT" },
                    { 56, "e63107bf-457", "STARTDEBIT" },
                    { 57, "e63107bf-457", "SUBMITCOMPLAINT" },
                    { 58, "e63107bf-457", "ACKNOWLEDGECOMPLAINT" },
                    { 59, "e63107bf-457", "DISPATCHCOMPLAINT" },
                    { 60, "e63107bf-457", "REVIEWCOMPLAINT" },
                    { 61, "e63107bf-457", "ASSIGNCOMPLAINT" },
                    { 62, "e63107bf-457", "RESOLVECOMPLAINT" },
                    { 63, "e63107bf-457", "REOPENCOMPLAINT" },
                    { 64, "e63107bf-457", "CLOSECOMPLAINT" },
                    { 65, "e63107bf-457", "CANCELCOMPLAINT" },
                    { 66, "e63107bf-457", "INPROGRESSCOMPLAINT" },
                    { 67, "e6f9be9e-a28", "CREATE" },
                    { 68, "e6f9be9e-a28", "READ" },
                    { 69, "e6f9be9e-a28", "UPDATE" },
                    { 70, "e6f9be9e-a28", "DELETE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationModules_ModuleName",
                table: "ApplicationModules",
                column: "ModuleName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ApplicationModules_ModuleName",
                table: "ApplicationModules");

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ModulesPermissions",
                keyColumn: "ModulesPermissionsId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ApplicationModules",
                keyColumn: "ModuleId",
                keyValue: "0983f651-ea9");

            migrationBuilder.DeleteData(
                table: "ApplicationModules",
                keyColumn: "ModuleId",
                keyValue: "1e5b4b1c-b5d");

            migrationBuilder.DeleteData(
                table: "ApplicationModules",
                keyColumn: "ModuleId",
                keyValue: "23e7ffbf-762");

            migrationBuilder.DeleteData(
                table: "ApplicationModules",
                keyColumn: "ModuleId",
                keyValue: "421070d5-37b");

            migrationBuilder.DeleteData(
                table: "ApplicationModules",
                keyColumn: "ModuleId",
                keyValue: "53a24ec6-b42");

            migrationBuilder.DeleteData(
                table: "ApplicationModules",
                keyColumn: "ModuleId",
                keyValue: "9a421337-c47");

            migrationBuilder.DeleteData(
                table: "ApplicationModules",
                keyColumn: "ModuleId",
                keyValue: "a4a39f7a-bd6");

            migrationBuilder.DeleteData(
                table: "ApplicationModules",
                keyColumn: "ModuleId",
                keyValue: "e63107bf-457");

            migrationBuilder.DeleteData(
                table: "ApplicationModules",
                keyColumn: "ModuleId",
                keyValue: "e6f9be9e-a28");
        }
    }
}
