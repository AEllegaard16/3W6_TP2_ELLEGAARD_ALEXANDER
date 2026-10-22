using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriVie.Migrations
{
    /// <inheritdoc />
    public partial class AlimentRecette_DbSetSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlimentRecette_Aliment_AlimentsId",
                table: "AlimentRecette");

            migrationBuilder.DropForeignKey(
                name: "FK_AlimentRecette_Recette_RecettesId",
                table: "AlimentRecette");

            migrationBuilder.RenameColumn(
                name: "RecettesId",
                table: "AlimentRecette",
                newName: "AlimentId");

            migrationBuilder.RenameColumn(
                name: "AlimentsId",
                table: "AlimentRecette",
                newName: "RecetteId");

            migrationBuilder.RenameIndex(
                name: "IX_AlimentRecette_RecettesId",
                table: "AlimentRecette",
                newName: "IX_AlimentRecette_AlimentId");

            migrationBuilder.AddColumn<double>(
                name: "Poids",
                table: "AlimentRecette",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AlimentRecette",
                columns: new[] { "AlimentId", "RecetteId", "Poids" },
                values: new object[,]
                {
                    { 1, 1, 800.0 },
                    { 2, 1, 500.0 },
                    { 3, 1, 200.0 },
                    { 4, 1, 150.0 },
                    { 5, 2, 200.0 },
                    { 6, 2, 3.0 },
                    { 7, 2, 100.0 },
                    { 8, 2, 200.0 },
                    { 9, 3, 600.0 },
                    { 10, 3, 300.0 },
                    { 11, 3, 30.0 },
                    { 12, 3, 150.0 },
                    { 8, 4, 100.0 },
                    { 9, 4, 600.0 },
                    { 10, 4, 250.0 },
                    { 13, 4, 80.0 },
                    { 4, 5, 300.0 },
                    { 9, 5, 700.0 },
                    { 14, 5, 2.0 },
                    { 13, 6, 30.0 },
                    { 15, 6, 400.0 },
                    { 16, 6, 5.0 },
                    { 7, 7, 150.0 },
                    { 10, 7, 400.0 },
                    { 17, 7, 300.0 },
                    { 18, 7, 500.0 },
                    { 13, 8, 50.0 },
                    { 15, 8, 350.0 },
                    { 19, 8, 300.0 },
                    { 20, 8, 500.0 },
                    { 9, 9, 300.0 },
                    { 21, 9, 500.0 },
                    { 22, 9, 200.0 },
                    { 23, 9, 150.0 },
                    { 4, 10, 100.0 },
                    { 9, 10, 500.0 },
                    { 24, 10, 2.0 },
                    { 25, 10, 50.0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AlimentRecette_Aliment_AlimentId",
                table: "AlimentRecette",
                column: "AlimentId",
                principalTable: "Aliment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlimentRecette_Recette_RecetteId",
                table: "AlimentRecette",
                column: "RecetteId",
                principalTable: "Recette",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlimentRecette_Aliment_AlimentId",
                table: "AlimentRecette");

            migrationBuilder.DropForeignKey(
                name: "FK_AlimentRecette_Recette_RecetteId",
                table: "AlimentRecette");

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 21, 9 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 22, 9 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 23, 9 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 24, 10 });

            migrationBuilder.DeleteData(
                table: "AlimentRecette",
                keyColumns: new[] { "AlimentId", "RecetteId" },
                keyValues: new object[] { 25, 10 });

            migrationBuilder.DropColumn(
                name: "Poids",
                table: "AlimentRecette");

            migrationBuilder.RenameColumn(
                name: "AlimentId",
                table: "AlimentRecette",
                newName: "RecettesId");

            migrationBuilder.RenameColumn(
                name: "RecetteId",
                table: "AlimentRecette",
                newName: "AlimentsId");

            migrationBuilder.RenameIndex(
                name: "IX_AlimentRecette_AlimentId",
                table: "AlimentRecette",
                newName: "IX_AlimentRecette_RecettesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlimentRecette_Aliment_AlimentsId",
                table: "AlimentRecette",
                column: "AlimentsId",
                principalTable: "Aliment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlimentRecette_Recette_RecettesId",
                table: "AlimentRecette",
                column: "RecettesId",
                principalTable: "Recette",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
