using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class seed_subscription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "subscriptions",
                columns: new[] { "Id", "agency_id", "destination_city_id", "origin_city_id" },
                values: new object[,]
                {
                    { 2, 1, 925, 4206 },
                    { 3, 1, 1046, 4206 },
                    { 4, 1, 1118, 4206 },
                    { 5, 1, 1192, 4206 },
                    { 6, 1, 1294, 4206 },
                    { 7, 1, 1485, 4206 },
                    { 8, 1, 4206, 925 },
                    { 9, 1, 217, 925 },
                    { 10, 1, 1587, 925 },
                    { 11, 1, 5330, 925 },
                    { 12, 1, 3398, 925 },
                    { 13, 1, 824, 925 },
                    { 14, 1, 152, 925 },
                    { 15, 1, 1294, 5086 },
                    { 16, 1, 925, 217 },
                    { 17, 1, 1046, 217 },
                    { 18, 1, 1118, 217 },
                    { 19, 1, 1192, 217 },
                    { 20, 1, 1046, 3596 },
                    { 21, 1, 1294, 3596 },
                    { 22, 1, 3398, 1003 },
                    { 23, 1, 824, 1005 },
                    { 24, 1, 3398, 1009 },
                    { 25, 1, 4206, 1046 },
                    { 26, 1, 217, 1046 },
                    { 27, 1, 3596, 1046 },
                    { 28, 1, 1587, 1046 },
                    { 29, 1, 3863, 1046 },
                    { 30, 1, 3398, 1046 },
                    { 31, 1, 824, 1046 },
                    { 32, 1, 4108, 1046 },
                    { 33, 1, 152, 1046 },
                    { 34, 1, 4206, 1118 },
                    { 35, 1, 217, 1118 },
                    { 36, 1, 1587, 1118 },
                    { 37, 1, 3863, 1118 },
                    { 38, 1, 3398, 1118 },
                    { 39, 1, 3398, 1124 },
                    { 40, 1, 4206, 1192 },
                    { 41, 1, 217, 1192 },
                    { 42, 1, 5330, 1192 },
                    { 43, 1, 3398, 1192 },
                    { 44, 1, 824, 1192 },
                    { 45, 1, 925, 1587 },
                    { 46, 1, 1118, 1587 },
                    { 47, 1, 1192, 1587 },
                    { 48, 1, 925, 5330 },
                    { 49, 1, 1009, 5330 },
                    { 50, 1, 1192, 5330 },
                    { 51, 1, 1118, 3863 },
                    { 52, 1, 1294, 3863 },
                    { 53, 1, 3398, 1253 },
                    { 54, 1, 4206, 1294 },
                    { 55, 1, 5086, 1294 },
                    { 56, 1, 3596, 1294 },
                    { 57, 1, 1587, 1294 },
                    { 58, 1, 3863, 1294 },
                    { 59, 1, 3398, 1294 },
                    { 60, 1, 824, 1294 },
                    { 61, 1, 4108, 1294 },
                    { 62, 1, 152, 1294 },
                    { 63, 1, 152, 1335 },
                    { 64, 1, 925, 3398 },
                    { 65, 1, 1009, 3398 },
                    { 66, 1, 1046, 3398 },
                    { 67, 1, 1118, 3398 },
                    { 68, 1, 1192, 3398 },
                    { 69, 1, 1253, 3398 },
                    { 70, 1, 1294, 3398 },
                    { 71, 1, 925, 824 },
                    { 72, 1, 1046, 824 },
                    { 73, 1, 1294, 824 },
                    { 74, 1, 3398, 1485 },
                    { 75, 1, 4108, 1485 },
                    { 76, 1, 1294, 4108 },
                    { 77, 1, 1294, 152 },
                    { 78, 1, 1294, 3594 },
                    { 79, 1, 1118, 925 },
                    { 80, 1, 1294, 925 },
                    { 81, 1, 1192, 925 },
                    { 82, 1, 1005, 925 },
                    { 83, 1, 1294, 1046 },
                    { 84, 1, 1485, 1046 },
                    { 85, 1, 1177, 1046 },
                    { 86, 1, 842, 1046 },
                    { 87, 1, 1046, 1192 },
                    { 88, 1, 1118, 1192 },
                    { 89, 1, 1051, 1192 },
                    { 90, 1, 44, 152 },
                    { 91, 1, 117, 152 },
                    { 92, 1, 68, 87 },
                    { 93, 1, 785, 1294 },
                    { 94, 1, 3596, 152 },
                    { 95, 1, 824, 152 },
                    { 96, 1, 3594, 152 },
                    { 97, 1, 4206, 3398 },
                    { 98, 1, 217, 3398 },
                    { 99, 1, 5330, 3398 },
                    { 100, 1, 213, 3398 },
                    { 101, 1, 1192, 3457 },
                    { 102, 1, 4651, 925 },
                    { 103, 1, 3353, 3398 },
                    { 104, 1, 3263, 3398 },
                    { 105, 1, 3464, 3398 },
                    { 106, 1, 5330, 842 },
                    { 107, 1, 3398, 842 },
                    { 108, 1, 1177, 4206 },
                    { 109, 1, 4163, 925 },
                    { 110, 1, 1046, 5086 },
                    { 111, 1, 4206, 963 },
                    { 112, 1, 217, 963 },
                    { 113, 1, 1587, 963 },
                    { 114, 1, 3398, 963 },
                    { 115, 1, 1003, 217 },
                    { 116, 1, 1294, 217 },
                    { 117, 1, 4206, 1003 },
                    { 118, 1, 217, 1003 },
                    { 119, 1, 3863, 1003 },
                    { 120, 1, 152, 1003 },
                    { 121, 1, 217, 1009 },
                    { 122, 1, 5330, 1009 },
                    { 123, 1, 1815, 1046 },
                    { 124, 1, 5086, 1046 },
                    { 125, 1, 3353, 1046 },
                    { 126, 1, 4020, 1046 },
                    { 127, 1, 3577, 1046 },
                    { 128, 1, 3594, 1046 },
                    { 129, 1, 1580, 1118 },
                    { 130, 1, 217, 1124 },
                    { 131, 1, 1587, 1124 },
                    { 132, 1, 5330, 1124 },
                    { 133, 1, 4206, 1177 },
                    { 134, 1, 3863, 1177 },
                    { 135, 1, 3398, 1177 },
                    { 136, 1, 4108, 1177 },
                    { 137, 1, 152, 1177 },
                    { 138, 1, 3353, 1192 },
                    { 139, 1, 3863, 1192 },
                    { 140, 1, 3577, 1192 },
                    { 141, 1, 3594, 1192 },
                    { 142, 1, 1294, 5093 },
                    { 143, 1, 4206, 1253 },
                    { 144, 1, 5330, 1253 },
                    { 145, 1, 3863, 1253 },
                    { 146, 1, 824, 1253 },
                    { 147, 1, 3577, 1253 },
                    { 148, 1, 152, 1253 },
                    { 149, 1, 3594, 1253 },
                    { 150, 1, 217, 1294 },
                    { 151, 1, 5093, 1294 },
                    { 152, 1, 3577, 1294 },
                    { 153, 1, 3594, 1294 },
                    { 154, 1, 4206, 1335 },
                    { 155, 1, 217, 1335 },
                    { 156, 1, 1587, 1335 },
                    { 157, 1, 5330, 1335 },
                    { 158, 1, 3863, 1335 },
                    { 159, 1, 3398, 1335 },
                    { 160, 1, 824, 1335 },
                    { 161, 1, 1003, 3398 },
                    { 162, 1, 1124, 3398 },
                    { 163, 1, 1177, 3398 },
                    { 164, 1, 1046, 3577 },
                    { 165, 1, 1192, 3577 },
                    { 166, 1, 1253, 3577 },
                    { 167, 1, 1294, 3577 },
                    { 168, 1, 217, 1485 },
                    { 169, 1, 3863, 1485 },
                    { 170, 1, 152, 1485 },
                    { 171, 1, 3594, 1485 },
                    { 172, 1, 3398, 1506 },
                    { 173, 1, 925, 152 },
                    { 174, 1, 1046, 152 },
                    { 175, 1, 1046, 3594 },
                    { 176, 1, 1192, 3594 },
                    { 177, 1, 1253, 3594 },
                    { 178, 1, 1485, 3594 },
                    { 179, 1, 1815, 925 },
                    { 180, 1, 5086, 925 },
                    { 181, 1, 3596, 925 },
                    { 182, 1, 5030, 925 },
                    { 183, 1, 925, 5086 },
                    { 184, 1, 1192, 5086 },
                    { 185, 1, 3398, 961 },
                    { 186, 1, 1192, 3596 },
                    { 187, 1, 3398, 984 },
                    { 188, 1, 1815, 1003 },
                    { 189, 1, 1587, 1003 },
                    { 190, 1, 5330, 1003 },
                    { 191, 1, 1587, 1005 },
                    { 192, 1, 152, 1005 },
                    { 193, 1, 217, 1007 },
                    { 194, 1, 5330, 1007 },
                    { 195, 1, 3398, 1007 },
                    { 196, 1, 4206, 1009 },
                    { 197, 1, 213, 1009 },
                    { 198, 1, 3596, 1009 },
                    { 199, 1, 213, 1029 },
                    { 200, 1, 217, 1029 },
                    { 201, 1, 3398, 1029 },
                    { 202, 1, 213, 1046 },
                    { 203, 1, 4225, 1046 },
                    { 204, 1, 4227, 1046 },
                    { 205, 1, 824, 1051 },
                    { 206, 1, 213, 1118 },
                    { 207, 1, 5330, 1118 },
                    { 208, 1, 6857, 1118 },
                    { 209, 1, 4231, 1118 },
                    { 210, 1, 4225, 1118 },
                    { 211, 1, 4206, 1124 },
                    { 212, 1, 785, 1124 },
                    { 213, 1, 1815, 1177 },
                    { 214, 1, 3596, 1177 },
                    { 215, 1, 213, 1192 },
                    { 216, 1, 5086, 1192 },
                    { 217, 1, 3596, 1192 },
                    { 218, 1, 925, 5030 },
                    { 219, 1, 3596, 1253 },
                    { 220, 1, 5330, 1294 },
                    { 221, 1, 5086, 1335 },
                    { 222, 1, 3596, 1335 },
                    { 223, 1, 5093, 1335 },
                    { 224, 1, 683, 1418 },
                    { 225, 1, 3863, 1418 },
                    { 226, 1, 3398, 1418 },
                    { 227, 1, 785, 1418 },
                    { 228, 1, 4206, 1485 },
                    { 229, 1, 1815, 1485 },
                    { 230, 1, 5086, 1485 },
                    { 231, 1, 3596, 1485 },
                    { 232, 1, 5330, 1485 },
                    { 233, 1, 824, 1485 },
                    { 234, 1, 4020, 1485 },
                    { 235, 1, 4042, 1485 },
                    { 236, 1, 785, 1485 },
                    { 237, 1, 3596, 1506 },
                    { 238, 1, 152, 1506 },
                    { 239, 1, 5093, 1253 },
                    { 240, 1, 4910, 925 },
                    { 241, 1, 4937, 925 },
                    { 242, 1, 197, 925 },
                    { 243, 1, 204, 925 },
                    { 244, 1, 3594, 925 },
                    { 245, 1, 160, 925 },
                    { 246, 1, 4910, 1003 },
                    { 247, 1, 3565, 1046 },
                    { 248, 1, 3562, 1046 },
                    { 249, 1, 3593, 1046 },
                    { 250, 1, 3551, 1046 },
                    { 251, 1, 4910, 1046 },
                    { 252, 1, 197, 1046 },
                    { 253, 1, 204, 1046 },
                    { 254, 1, 160, 1046 },
                    { 255, 1, 3584, 1046 },
                    { 256, 1, 3594, 1118 },
                    { 257, 1, 4910, 1118 },
                    { 258, 1, 160, 1118 },
                    { 259, 1, 4910, 6447 },
                    { 260, 1, 4910, 1192 },
                    { 261, 1, 4910, 1253 },
                    { 262, 1, 3565, 1294 },
                    { 263, 1, 3562, 1294 },
                    { 264, 1, 3593, 1294 },
                    { 265, 1, 3551, 1294 },
                    { 266, 1, 4937, 1294 },
                    { 267, 1, 4910, 1294 },
                    { 268, 1, 197, 1294 },
                    { 269, 1, 204, 1294 },
                    { 270, 1, 160, 1294 },
                    { 271, 1, 3584, 1294 },
                    { 272, 1, 3565, 1485 },
                    { 273, 1, 3562, 1485 },
                    { 274, 1, 3593, 1485 },
                    { 275, 1, 3577, 1485 },
                    { 276, 1, 3551, 1485 },
                    { 277, 1, 4937, 1485 },
                    { 278, 1, 4910, 1485 },
                    { 279, 1, 197, 1485 },
                    { 280, 1, 204, 1485 },
                    { 281, 1, 160, 1485 },
                    { 282, 1, 3584, 1485 },
                    { 283, 1, 3574, 1294 },
                    { 284, 1, 3574, 1485 },
                    { 285, 1, 3574, 1046 },
                    { 286, 3, 925, 785 },
                    { 287, 3, 1294, 785 },
                    { 288, 3, 1485, 785 },
                    { 289, 3, 1197, 785 },
                    { 290, 3, 3398, 785 },
                    { 291, 3, 1118, 785 },
                    { 292, 3, 1192, 785 },
                    { 293, 3, 3457, 785 },
                    { 294, 3, 3863, 785 },
                    { 295, 3, 7469, 785 },
                    { 296, 3, 152, 785 },
                    { 297, 3, 4123, 785 },
                    { 298, 3, 3791, 785 },
                    { 299, 3, 3353, 785 },
                    { 300, 3, 925, 713 },
                    { 301, 3, 1294, 713 },
                    { 302, 3, 1485, 713 },
                    { 303, 3, 1197, 713 },
                    { 304, 3, 3398, 713 },
                    { 305, 3, 1118, 713 },
                    { 306, 3, 1192, 713 },
                    { 307, 3, 3457, 713 },
                    { 308, 3, 3863, 713 },
                    { 309, 3, 7469, 713 },
                    { 310, 3, 152, 713 },
                    { 311, 3, 4123, 713 },
                    { 312, 3, 3791, 713 },
                    { 313, 3, 3353, 713 },
                    { 314, 3, 925, 683 },
                    { 315, 3, 1294, 683 },
                    { 316, 3, 1485, 683 },
                    { 317, 3, 1197, 683 },
                    { 318, 3, 3398, 683 },
                    { 319, 3, 1118, 683 },
                    { 320, 3, 1192, 683 },
                    { 321, 3, 3457, 683 },
                    { 322, 3, 3863, 683 },
                    { 323, 3, 7469, 683 },
                    { 324, 3, 152, 683 },
                    { 325, 3, 4123, 683 },
                    { 326, 3, 3791, 683 },
                    { 327, 3, 3353, 683 },
                    { 328, 4, 1221, 925 },
                    { 329, 4, 1170, 925 },
                    { 330, 4, 1025, 925 },
                    { 331, 4, 1079, 925 },
                    { 332, 4, 1046, 925 },
                    { 333, 4, 1170, 1221 },
                    { 334, 4, 1025, 1221 },
                    { 335, 4, 1079, 1221 },
                    { 336, 4, 1046, 1221 },
                    { 337, 4, 1079, 1170 },
                    { 338, 4, 1046, 1170 },
                    { 339, 4, 1079, 1025 },
                    { 340, 4, 1046, 1025 },
                    { 341, 4, 1025, 1046 },
                    { 342, 4, 1170, 1046 },
                    { 343, 4, 1221, 1046 },
                    { 344, 4, 925, 1046 },
                    { 345, 4, 1025, 1079 },
                    { 346, 4, 1170, 1079 },
                    { 347, 4, 1221, 1079 },
                    { 348, 4, 925, 1079 },
                    { 349, 4, 1221, 1025 },
                    { 350, 4, 925, 1025 },
                    { 351, 4, 1221, 1170 },
                    { 352, 4, 925, 1170 },
                    { 353, 4, 925, 1221 },
                    { 354, 4, 1046, 1079 },
                    { 355, 4, 1079, 1046 },
                    { 356, 4, 1170, 1222 },
                    { 357, 4, 1025, 1222 },
                    { 358, 4, 1079, 1222 },
                    { 359, 4, 1046, 1222 },
                    { 360, 4, 925, 1222 },
                    { 361, 4, 1222, 1046 },
                    { 362, 4, 1222, 1079 },
                    { 363, 4, 1222, 1025 },
                    { 364, 4, 1222, 1170 },
                    { 365, 5, 1118, 925 },
                    { 366, 6, 925, 1118 },
                    { 367, 2, 1593, 1587 },
                    { 368, 7, 7911, 7116 },
                    { 369, 7, 5214, 7116 },
                    { 370, 7, 7285, 7116 },
                    { 371, 7, 6021, 5587 },
                    { 372, 7, 6526, 6021 },
                    { 373, 7, 5587, 6526 },
                    { 374, 7, 7202, 6964 },
                    { 375, 7, 7202, 7747 },
                    { 376, 7, 7747, 6964 },
                    { 377, 7, 7116, 7911 },
                    { 378, 7, 7116, 5214 },
                    { 379, 7, 7116, 7285 },
                    { 380, 7, 5587, 6021 },
                    { 381, 7, 6021, 6526 },
                    { 382, 7, 6526, 5587 },
                    { 383, 7, 6964, 7202 },
                    { 384, 7, 7747, 7202 },
                    { 385, 7, 6964, 7747 },
                    { 386, 7, 6572, 7116 },
                    { 387, 7, 7116, 6572 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "subscriptions",
                keyColumn: "Id",
                keyValue: 387);
        }
    }
}
