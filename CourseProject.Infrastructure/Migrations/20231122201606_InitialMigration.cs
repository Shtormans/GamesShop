﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Username = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
            //        SecondName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
            //        ProfilePicture = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Friends",
            //    columns: table => new
            //    {
            //        FriendsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Friends", x => new { x.FriendsId, x.UserId });
            //        table.ForeignKey(
            //            name: "FK_Friends_Users_FriendsId",
            //            column: x => x.FriendsId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Friends_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Games",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Price_Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
            //        Price_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        Genre = table.Column<int>(type: "int", nullable: false),
            //        AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Image = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Games", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Games_Users_AuthorId",
            //            column: x => x.AuthorId,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Comments",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Comments", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Comments_Games_GameId",
            //            column: x => x.GameId,
            //            principalTable: "Games",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Comments_Users_AuthorId",
            //            column: x => x.AuthorId,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Libraries",
            //    columns: table => new
            //    {
            //        LibraryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Libraries", x => new { x.LibraryId, x.UserId });
            //        table.ForeignKey(
            //            name: "FK_Libraries_Games_LibraryId",
            //            column: x => x.LibraryId,
            //            principalTable: "Games",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Libraries_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Transactions",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        PayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Price_Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
            //        Price_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Transactions", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Transactions_Games_GameId",
            //            column: x => x.GameId,
            //            principalTable: "Games",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Transactions_Users_PayerId",
            //            column: x => x.PayerId,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Transactions_Users_ReceiverId",
            //            column: x => x.ReceiverId,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Comments_AuthorId",
            //    table: "Comments",
            //    column: "AuthorId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Comments_GameId",
            //    table: "Comments",
            //    column: "GameId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Friends_UserId",
            //    table: "Friends",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Games_AuthorId",
            //    table: "Games",
            //    column: "AuthorId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Games_Title",
            //    table: "Games",
            //    column: "Title",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Libraries_UserId",
            //    table: "Libraries",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Transactions_GameId",
            //    table: "Transactions",
            //    column: "GameId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Transactions_PayerId",
            //    table: "Transactions",
            //    column: "PayerId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Transactions_ReceiverId",
            //    table: "Transactions",
            //    column: "ReceiverId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_Email",
            //    table: "Users",
            //    column: "Email",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_Username",
            //    table: "Users",
            //    column: "Username",
            //    unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Libraries");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
