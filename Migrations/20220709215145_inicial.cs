﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HermanosApi.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hermanos",
                columns: table => new
                {
                    ImagenUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<int>(type: "INTEGER", nullable: false),
                    Edad = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hermanos", x => x.ImagenUrl);
                });

            migrationBuilder.InsertData(
                table: "Hermanos",
                columns: new[] { "ImagenUrl", "Edad", "Nombre", "Telefono" },
                values: new object[] { "https://lh3.googleusercontent.com/-CySSivfhg1zbfy_JBUOcXAE3S8Sga0kX5vHvQ3tqwJF7jTOvOZURHYJRrNXZeXn_0UHgYkH3wQJcOqmPONpe2S1uYu_Z1IQoEGKmHaYMI_aCfQhz4v6L9n_yb6l68iljXTpEfQ-dEAK9yMxnMeqmHIvtSMGON4WY_5REoQUGYE2zZueUY7pEJVS9RqW4D4xQi5QXito0dFIIKG9azG8n_hlHooEjc3tb5UKz_qvqDdM7tE3_yStCFAL6Ww67V_VuKBva_dwLrStKIWRVrhQ23BdhNJ_09clvhMhEwQ9SjMtm_Q4v1a2_kIFsfpoUOt0EQd8VTTGAzNwW6r4KfmY08BuvrakfLpctvXurRiOyiLqY7XveiYB4WHnzy_RdS8g6NZk8AUY2wWj0QDYPtkeBiPOU8sNOpebaPmC7QKy0kKdiiktAmSqC-Uff6ZyczWNJHibgqIDVA78xHzpTtNN-d_x_mSaIVBZQqd4IWJw4OjOM917mubbf9TmWyzm3kyCIs4HeBxRdw0EZ0QNxHq43xJBwefwhTIxoGUVs67zuWNswE2RTy1NxCRkHG6blxdNMXbCQk5dv7Zum_hs8z5_dEI3nSSjj3wtuai9hxx8RNVOtD5TwEQx2XhKpIVzmSzufmeBW42yXPfdGB99eqEIXLm0I2Ul5Z3k5VCmpP1m-TCyKtFqFGMQJHQLgSW_VdeaE7wSDROj23nWws533XCociX8PD8-tUqEEswFek_rdiW-Jm4-1QYhLxav-FlPA-Fj9lXR2pxcE9_ZSO5xXrwFuiNQclORcwuYnJygznCEWCiDULx3n5EkPKh54AKuUCNxKAEu5eHdaX7FMTfvycw9qCRhTlbZEhImoFyociFFXFA=s80-no?authuser=0", (byte)25, "Julio Jimeno", -1453 });

            migrationBuilder.InsertData(
                table: "Hermanos",
                columns: new[] { "ImagenUrl", "Edad", "Nombre", "Telefono" },
                values: new object[] { "https://lh3.googleusercontent.com/iyZaXsCJo4Lk-xZXzKOJeN0B8e2psdA9x3arX4bnGQcdjIRFWn57-gpBAucGmbUZNHqsBr5SBS9bL9nZGGIRUDiQchmIFP0AifcGHjUHWtSzef1ONRY3x2foPSQO3Fq3qtUltbgKaddbu4Keyv0ff-ee2q3HLqCqW54CVd0vvam3ir4N_4APjY2airtQkHmjJxOCVGU-Xkt3i6KlddWny-8ZzSA9wYMCB20yNCGQEKbdwZZKp0WnrdWY-G80Yev1EPWHvCVd3SRR6mGU6yJ9GD63ESiDy3Ggl-SLjRbmLtpAM3Zm0lAJlgcBeuay2TpyC7NH4hyGEM-UPdR6y0dOHgZHFkpK8l-GhVxmPZ3suAbp9rmox9WL_-9xBcJMwkpBQxVWqj0QF1PWab7S5lOoZSAFP6YhrdaWRHjpcBRUkl3dDFc-Fk-uM-aIqURfaOeIWCkA8-XUXzO10o1JX0TNHE_UH-ww80GwvgGwRoKwPtys1rg7NMJ_6jEnzxiSWRHLK93V2tYMgyHhfRMo50R86mbSJzMFXZXSgnM2BGeMwXMYFiaE59aQe0RlV5988cZaakGow9JpTOwX6VhJuyIRP-BT4t3es3A3rW_ieVMDiU9yO9g9T-kS5X2RQzitGHs3-ojHUbTxmUvyqYLA_I1jDG1CX_FcJOYIzIxb4qfl8kWgtWWXUo05zFjT7Xf8vsiwt2R69b4lw3QrEp1KUdKpdOjRr7bI_-NjuHG6UwipHdN9FeOq7x77VlC1Ak3j8hSYtLsZc1VsMyhQxqkQtLyz7tMjCHg8YZgCeFUt2cE3aAXx4FiaICgh6JPJPAWs0HCNhLkdehjbRYfTqDDiWTfdhFkLf4fdHjC0oOMTD2B6sy0=s80-no?authuser=0", (byte)27, "Enel Almonte", -6745 });

            migrationBuilder.InsertData(
                table: "Hermanos",
                columns: new[] { "ImagenUrl", "Edad", "Nombre", "Telefono" },
                values: new object[] { "https://lh3.googleusercontent.com/RB_-1MJ9oRNJNCuBlsjDLhcs6ZMmpigOUMS-VrqhTyw4ke-_aMtr08ueImIQ_HBhq1Q5TW3ui26k7i0ewQIdETB0W2ee5k7Eo12N1hfPfeUV0lipM8_6SVghT1KusbuO4Bx8r_EA8nIpPnA__qkShSIhF-jYzTOm_pdVX-MJg86_H1Ku1xHbEq8YugAQEdsfDRHs0C2fb9dFe3iEkS5Tg1ZsYtVGNozTOxebrQsTTIc94-VxHcp6nLNnHeZcK0eZM2LZPXZ6Z7Ul08Jg3lAAM-Nf0i66yMM75H4j3J5NfyRdd5VvrI5RyY9znl1UgzXcFuq49OFHI_NzUbflBKHTF1DUfvdAI-M35xLC8j4DlhejhxcBBbOlg_G2PsPOjSEoUYlbBxKcePJILUnpl9t-Lz5eWypUwBjZxZ4pBdIB35rugpgQMKGKfV7lJEE9BbF7q8eGTmC7voma8SRA1TuKusU5Fh4rZaO-P1-wq_5qWA2sX-57jaJg-LCSKlCWSW4yx9U2VXON-GptQbww2M0nxAWVnHL5wKq7ISWLRuOgvWJrrIkV0juIcgnCNz8_brRIQD9gdGWSuENBTvlDJZXm9U7w4tRgdFiXgd4BEM6g4bVbhEOAOHph7WFdDQ9Ak4Tgk1oWXNnxMlgvQoA0FFoJh5WGwyZKMTMXxA4gQ7gRl5J5PQLLuJhsHXQ3rIj9_WqDaeSLZeGzEaRYUwDF7WLJxM-H4wVpaHMdcqGTH-DbYHCWzDhS-LxlRVkht0sEmuRXRrLEA7_SZVX7QYb5yL-fx5YnpoLriGt1cPNNTqe_JH4WTWJ6bImU4LGVd99sqNJLPsEq4Ev5R3ZakwwGVnzJofc1l-yC5s1wzizBz77s5iQ=s80-no?authuser=0", (byte)21, "Ismarlyn Mendoza", -2961 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hermanos");
        }
    }
}
