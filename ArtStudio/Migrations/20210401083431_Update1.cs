using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtStudio.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInfos_AspNetUsers_ApplicationUserId1",
                table: "PaymentInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCartContents_AspNetUsers_ApplicationUserId1",
                table: "UserCartContents");

            migrationBuilder.DropIndex(
                name: "IX_UserCartContents_ApplicationUserId1",
                table: "UserCartContents");

            migrationBuilder.DropIndex(
                name: "IX_PaymentInfos_ApplicationUserId1",
                table: "PaymentInfos");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("411e6e51-588e-49a2-b429-e8410361079d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("496a074f-c0f9-4abf-b6f3-d5364d2c8584"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5007b09b-2596-455d-967b-260ed8fee077"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51e51f21-ed0f-4907-88e5-22c9c24ec05d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61fcbc5e-3858-4a32-91cf-ffc4ea5a4151"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a06c057-f79c-4a97-8e1d-8ad5e489a062"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bcfe1406-90d5-4c69-bb4e-8d11f122f116"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bdc3bae7-06a2-4c30-9dd0-2c6331af5723"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c00c72c4-943b-4904-8b86-3fde1e76b78e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2c9d0b1-55c8-4ac3-a02b-a42b8730b90b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e93e553d-5712-42fd-b5e0-ce9a99be667f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efb4b96a-e757-4c47-92d2-17a6c9946dfa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb5a4057-068f-4ed7-95a9-7bd2b3b92d51"));

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("3736f545-a2bb-4bfa-9daf-9a10011f0a13"));

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("c64376c4-e42d-407e-851a-caf6c6606b59"));

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("c74454b1-471e-44de-87fd-b8f1e8d88c66"));

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "UserCartContents");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "PaymentInfos");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "UserCartContents",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "PaymentInfos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayAlias", "Enabled" },
                values: new object[,]
                {
                    { new Guid("ffa7fcb3-c5b7-4c33-ab39-c815d6512384"), "Цвет — все, но черно-белый — еще больше", "Черно-белая", true },
                    { new Guid("1b604960-0fed-43bf-a678-22bf1abc6ccd"), "Вы наполняете кадр чувствами, энергией, жаждой открытий и риском и оставляете достаточно места, чтобы туда мог попасть кто-нибудь еще", "Рекламная", true },
                    { new Guid("0c0c7810-3f94-4e94-8150-b3d5fa20e691"), "Еще одна невероятная революция произошла в фотографии, но и на нее оказало влияние Концептуальное Искусство", "Концептуальная", true },
                    { new Guid("d9e99671-4abe-4f52-a927-8a8b4cf94bc3"), "Мою жизнь формирует неудержимая потребность странствовать и наблюдать, а мой фотоаппарат — это паспорт", "Туристическая", true },
                    { new Guid("a6ee58e3-6aed-4ff5-8730-3195ff7d3bae"), "Пейзажная фотография переступает все политические и национальные границы, выходит за рамки языковых и культурных ограничений", "Пейзажная", true },
                    { new Guid("74499731-a311-4f6a-bf6d-53146dd664bd"), "Фотография — это кнопка паузы, на которую поставлена жизнь", "Свадебная", true },
                    { new Guid("04913a5e-f730-4af9-9936-1ffabcbee704"), "Фотография уловила факт из жизни, и этот факт будет жить вечно", "Уличная", true },
                    { new Guid("98ba11a6-f4e0-4647-aad3-6e547770141b"), "Фотография - обьяснение вещам", "Спортивная", true },
                    { new Guid("1ea41780-d46c-4070-8788-66156c11cd5c"), "Одно дело — сфотографировать, как человек выглядит, и совсем другое, отобразить, что он из себя представляет", "Портретная", true },
                    { new Guid("8f172b25-e93d-49f6-b238-7886d1a40762"), "Не каждый верит картинам, но фотографиям верят все", "HDR", true },
                    { new Guid("94f2d50a-c423-4964-91e1-48c8c941c72d"), "Важнее вызвать отклик у людей, чем нажать на кнопку затвора", "Фэшн-фотография", true },
                    { new Guid("1d6d5cfe-78d1-4d2f-9824-919ac1f2621c"), "Фотография — это искусство созерцания. Ее суть в том, чтобы найти что-то интересное в обычном месте", "Предметная", true },
                    { new Guid("ee9cc6ec-9f0a-41f7-a673-686a9b8e1146"), "Существуют вещи, которые никто никогда никто не увидел , если бы их не сфотографировали", "Аэрофотография", true }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "CountOfDownlaods", "Description", "DisplayAlias", "Enabled", "Order", "Price" },
                values: new object[,]
                {
                    { new Guid("b02ab3da-0719-4846-becc-2a1d32560840"), 10, "Пакет с минимальными возможностями", "Начальный", true, 1, 3.0 },
                    { new Guid("1bde001b-ae80-4a69-bb7f-71ef3e5274e0"), 25, "Средний пакет", "Продвинутый", true, 2, 6.0 },
                    { new Guid("95072784-e133-4fa7-92d1-83bfc684f06f"), 35, "Пакет с максимальными возможностями", "Профи", true, 3, 8.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserCartContents_ApplicationUserId",
                table: "UserCartContents",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInfos_ApplicationUserId",
                table: "PaymentInfos",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInfos_AspNetUsers_ApplicationUserId",
                table: "PaymentInfos",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCartContents_AspNetUsers_ApplicationUserId",
                table: "UserCartContents",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInfos_AspNetUsers_ApplicationUserId",
                table: "PaymentInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCartContents_AspNetUsers_ApplicationUserId",
                table: "UserCartContents");

            migrationBuilder.DropIndex(
                name: "IX_UserCartContents_ApplicationUserId",
                table: "UserCartContents");

            migrationBuilder.DropIndex(
                name: "IX_PaymentInfos_ApplicationUserId",
                table: "PaymentInfos");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04913a5e-f730-4af9-9936-1ffabcbee704"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0c0c7810-3f94-4e94-8150-b3d5fa20e691"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b604960-0fed-43bf-a678-22bf1abc6ccd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d6d5cfe-78d1-4d2f-9824-919ac1f2621c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ea41780-d46c-4070-8788-66156c11cd5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74499731-a311-4f6a-bf6d-53146dd664bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8f172b25-e93d-49f6-b238-7886d1a40762"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94f2d50a-c423-4964-91e1-48c8c941c72d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98ba11a6-f4e0-4647-aad3-6e547770141b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6ee58e3-6aed-4ff5-8730-3195ff7d3bae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9e99671-4abe-4f52-a927-8a8b4cf94bc3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee9cc6ec-9f0a-41f7-a673-686a9b8e1146"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffa7fcb3-c5b7-4c33-ab39-c815d6512384"));

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("1bde001b-ae80-4a69-bb7f-71ef3e5274e0"));

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("95072784-e133-4fa7-92d1-83bfc684f06f"));

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: new Guid("b02ab3da-0719-4846-becc-2a1d32560840"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ApplicationUserId",
                table: "UserCartContents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "UserCartContents",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ApplicationUserId",
                table: "PaymentInfos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "PaymentInfos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayAlias", "Enabled" },
                values: new object[,]
                {
                    { new Guid("8a06c057-f79c-4a97-8e1d-8ad5e489a062"), "Цвет — все, но черно-белый — еще больше", "Черно-белая", true },
                    { new Guid("411e6e51-588e-49a2-b429-e8410361079d"), "Вы наполняете кадр чувствами, энергией, жаждой открытий и риском и оставляете достаточно места, чтобы туда мог попасть кто-нибудь еще", "Рекламная", true },
                    { new Guid("efb4b96a-e757-4c47-92d2-17a6c9946dfa"), "Еще одна невероятная революция произошла в фотографии, но и на нее оказало влияние Концептуальное Искусство", "Концептуальная", true },
                    { new Guid("c00c72c4-943b-4904-8b86-3fde1e76b78e"), "Мою жизнь формирует неудержимая потребность странствовать и наблюдать, а мой фотоаппарат — это паспорт", "Туристическая", true },
                    { new Guid("fb5a4057-068f-4ed7-95a9-7bd2b3b92d51"), "Пейзажная фотография переступает все политические и национальные границы, выходит за рамки языковых и культурных ограничений", "Пейзажная", true },
                    { new Guid("61fcbc5e-3858-4a32-91cf-ffc4ea5a4151"), "Фотография — это кнопка паузы, на которую поставлена жизнь", "Свадебная", true },
                    { new Guid("bdc3bae7-06a2-4c30-9dd0-2c6331af5723"), "Фотография уловила факт из жизни, и этот факт будет жить вечно", "Уличная", true },
                    { new Guid("bcfe1406-90d5-4c69-bb4e-8d11f122f116"), "Фотография - обьяснение вещам", "Спортивная", true },
                    { new Guid("496a074f-c0f9-4abf-b6f3-d5364d2c8584"), "Одно дело — сфотографировать, как человек выглядит, и совсем другое, отобразить, что он из себя представляет", "Портретная", true },
                    { new Guid("d2c9d0b1-55c8-4ac3-a02b-a42b8730b90b"), "Не каждый верит картинам, но фотографиям верят все", "HDR", true },
                    { new Guid("51e51f21-ed0f-4907-88e5-22c9c24ec05d"), "Важнее вызвать отклик у людей, чем нажать на кнопку затвора", "Фэшн-фотография", true },
                    { new Guid("5007b09b-2596-455d-967b-260ed8fee077"), "Фотография — это искусство созерцания. Ее суть в том, чтобы найти что-то интересное в обычном месте", "Предметная", true },
                    { new Guid("e93e553d-5712-42fd-b5e0-ce9a99be667f"), "Существуют вещи, которые никто никогда никто не увидел , если бы их не сфотографировали", "Аэрофотография", true }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "CountOfDownlaods", "Description", "DisplayAlias", "Enabled", "Order", "Price" },
                values: new object[,]
                {
                    { new Guid("c74454b1-471e-44de-87fd-b8f1e8d88c66"), 10, "Пакет с минимальными возможностями", "Начальный", true, 1, 3.0 },
                    { new Guid("3736f545-a2bb-4bfa-9daf-9a10011f0a13"), 25, "Средний пакет", "Продвинутый", true, 2, 6.0 },
                    { new Guid("c64376c4-e42d-407e-851a-caf6c6606b59"), 35, "Пакет с максимальными возможностями", "Профи", true, 3, 8.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserCartContents_ApplicationUserId1",
                table: "UserCartContents",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInfos_ApplicationUserId1",
                table: "PaymentInfos",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInfos_AspNetUsers_ApplicationUserId1",
                table: "PaymentInfos",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCartContents_AspNetUsers_ApplicationUserId1",
                table: "UserCartContents",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
