using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FirstName = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsArchived = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AuthorId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsArchived = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedAt", "FirstName", "IsArchived", "LastModifiedAt", "LastName" },
                values: new object[,]
                {
                    { new Guid("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(682), "James", false, new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(682), "Elroy" },
                    { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(682), "Douglas", false, new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(682), "Adams" },
                    { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(672), "George", false, new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(672), "RR Martin" },
                    { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(679), "Stephen", false, new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(679), "Fry" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Description", "IsArchived", "LastModifiedAt", "Title" },
                values: new object[,]
                {
                    { new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"), new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(745), "In The Hitchhiker's Guide to the Galaxy, the characters visit the legendary planet Magrathea, home to the now-collapsed planet-building industry, and meet Slartibartfast, a planetary coastline designer who was responsible for the fjords of Norway. Through archival recordings, he relates the story of a race of hyper-intelligent pan-dimensional beings who built a computer named Deep Thought to calculate the Answer to the Ultimate Question of Life, the Universe, and Everything.", false, new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(745), "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"), new Guid("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(743), "American Tabloid is a 1995 novel by James Ellroy that chronicles the events surrounding three rogue American law enforcement officers from November 22, 1958 through November 22, 1963. Each becomes entangled in a web of interconnecting associations between the FBI, the CIA, and the mafia, which eventually leads to their collective involvement in the John F. Kennedy assassination.", false, new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(743), "American Tabloid" },
                    { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(739), "The book that seems impossible to write.", false, new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(739), "The Winds of Winter" },
                    { new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(742), "The Greek myths are amongst the best stories ever told, passed down through millennia and inspiring writers and artists as varied as Shakespeare, Michelangelo, James Joyce and Walt Disney.  They are embedded deeply in the traditions, tales and cultural DNA of the West.You'll fall in love with Zeus, marvel at the birth of Athena, wince at Cronus and Gaia's revenge on Ouranos, weep with King Midas and hunt with the beautiful and ferocious Artemis. Spellbinding, informative and moving, Stephen Fry's Mythos perfectly captures these stories for the modern age - in all their rich and deeply human relevance.", false, new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(742), "Mythos" },
                    { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(741), "A Game of Thrones is the first novel in A Song of Ice and Fire, a series of fantasy novels by American author George R. R. ... In the novel, recounting events from various points of view, Martin introduces the plot-lines of the noble houses of Westeros, the Wall, and the Targaryens.", false, new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(741), "A Game of Thrones" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
