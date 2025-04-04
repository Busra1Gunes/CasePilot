using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BasvuruTurleri",
                columns: new[] { "Id", "Adi", "DavaTurId", "Durum", "EklenmeTarihi", "GuncellenmeTarihi", "SilinmeTarihi" },
                values: new object[,]
                {
                    { 1, "Araç Hasarı", 1, false, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(2943), null, null },
                    { 2, "Manevi", 1, false, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(2959), null, null },
                    { 3, "İdari Dava", 1, false, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(2959), null, null },
                    { 4, "Kamulaştırma", 4, false, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(2961), null, null }
                });

            migrationBuilder.InsertData(
                table: "DavaTurleri",
                columns: new[] { "Id", "Adi", "Durum", "EklenmeTarihi", "GuncellenmeTarihi", "SilinmeTarihi" },
                values: new object[,]
                {
                    { 1, "Trafik Kazası", false, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3146), null, null },
                    { 2, "Arabuluculuk", false, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3148), null, null },
                    { 3, "İdari Dava", false, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3149), null, null },
                    { 4, "Kamulaştırma", false, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3149), null, null }
                });

            migrationBuilder.InsertData(
                table: "EvrakTurler",
                columns: new[] { "Id", "Durum", "EklenmeTarihi", "EvrakTurAdi", "GuncellenmeTarihi", "SilinmeTarihi", "Tur" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3350), "TcKimlik", null, null, "DosyaEvrak" },
                    { 2, false, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3352), "Sici Kaydı", null, null, "KullaniciEvrak" }
                });

            migrationBuilder.InsertData(
                table: "Iller",
                columns: new[] { "Id", "Adi" },
                values: new object[,]
                {
                    { 1, "Adana" },
                    { 2, "Adıyaman" },
                    { 3, "Afyonkarahisar" },
                    { 4, "Ağrı" },
                    { 5, "Amasya" },
                    { 6, "Ankara" },
                    { 7, "Antalya" },
                    { 8, "Artvin" },
                    { 9, "Aydın" },
                    { 10, "Balıkesir" },
                    { 11, "Bilecik" },
                    { 12, "Bingöl" },
                    { 13, "Bitlis" },
                    { 14, "Bolu" },
                    { 15, "Burdur" },
                    { 16, "Bursa" },
                    { 17, "Çanakkale" },
                    { 18, "Çankırı" },
                    { 19, "Çorum" },
                    { 20, "Denizli" },
                    { 21, "Diyarbakır" },
                    { 22, "Edirne" },
                    { 23, "Elazığ" },
                    { 24, "Erzincan" },
                    { 25, "Erzurum" },
                    { 26, "Eskişehir" },
                    { 27, "Gaziantep" },
                    { 28, "Giresun" },
                    { 29, "Gümüşhane" },
                    { 30, "Hakkari" },
                    { 31, "Hatay" },
                    { 32, "Isparta" },
                    { 33, "Mersin" },
                    { 34, "İstanbul" },
                    { 35, "İzmir" },
                    { 36, "Kars" },
                    { 37, "Kastamonu" },
                    { 38, "Kayseri" },
                    { 39, "Kırklareli" },
                    { 40, "Kırşehir" },
                    { 41, "Kocaeli" },
                    { 42, "Konya" },
                    { 43, "Kütahya" },
                    { 44, "Malatya" },
                    { 45, "Manisa" },
                    { 46, "Kahramanmaraş" },
                    { 47, "Mardin" },
                    { 48, "Muğla" },
                    { 49, "Muş" },
                    { 50, "Nevşehir" },
                    { 51, "Niğde" },
                    { 52, "Ordu" },
                    { 53, "Rize" },
                    { 54, "Sakarya" },
                    { 55, "Samsun" },
                    { 56, "Siirt" },
                    { 57, "Sinop" },
                    { 58, "Sivas" },
                    { 59, "Tekirdağ" },
                    { 60, "Tokat" },
                    { 61, "Trabzon" },
                    { 62, "Tunceli" },
                    { 63, "Şanlıurfa" },
                    { 64, "Uşak" },
                    { 65, "Van" },
                    { 66, "Yozgat" },
                    { 67, "Zonguldak" },
                    { 68, "Aksaray" },
                    { 69, "Bayburt" },
                    { 70, "Karaman" },
                    { 71, "Kırıkkale" },
                    { 72, "Batman" },
                    { 73, "Şırnak" },
                    { 74, "Bartın" },
                    { 75, "Ardahan" },
                    { 76, "Iğdır" },
                    { 77, "Yalova" },
                    { 78, "Karabük" },
                    { 79, "Kilis" },
                    { 80, "Osmaniye" },
                    { 81, "Düzce" }
                });

            migrationBuilder.InsertData(
                table: "ilceler",
                columns: new[] { "Id", "IlId", "IlceAdi" },
                values: new object[,]
                {
                    { 1, 1, "ALADAĞ" },
                    { 2, 1, "CEYHAN" },
                    { 3, 1, "ÇUKUROVA" },
                    { 4, 1, "FEKE" },
                    { 5, 1, "İMAMOĞLU" },
                    { 6, 1, "KARAİSALI" },
                    { 7, 1, "KARATAŞ" },
                    { 8, 1, "KOZAN" },
                    { 9, 1, "POZANTI" },
                    { 10, 1, "SAİMBEYLİ" },
                    { 11, 1, "SARIÇAM" },
                    { 12, 1, "SEYHAN" },
                    { 13, 1, "TUFANBEYLİ" },
                    { 14, 1, "YUMURTALIK" },
                    { 15, 1, "YÜREĞİR" },
                    { 16, 2, "BESNİ" },
                    { 17, 2, "ÇELİKHAN" },
                    { 18, 2, "GERGER" },
                    { 19, 2, "GÖLBAŞI" },
                    { 20, 2, "KAHTA" },
                    { 21, 2, "MERKEZ" },
                    { 22, 2, "SAMSAT" },
                    { 23, 2, "SİNCİK" },
                    { 24, 2, "TUT" },
                    { 25, 3, "BAŞMAKÇI" },
                    { 26, 3, "BAYAT" },
                    { 27, 3, "BOLVADİN" },
                    { 28, 3, "ÇAY" },
                    { 29, 3, "ÇOBANLAR" },
                    { 30, 3, "DAZKIRI" },
                    { 31, 3, "DİNAR" },
                    { 32, 3, "EMİRDAĞ" },
                    { 33, 3, "EVCİLER" },
                    { 34, 3, "HOCALAR" },
                    { 35, 3, "İHSANİYE" },
                    { 36, 3, "İSCEHİSAR" },
                    { 37, 3, "KIZILÖREN" },
                    { 38, 3, "MERKEZ" },
                    { 39, 3, "SANDIKLI" },
                    { 40, 3, "SİNANPAŞA" },
                    { 41, 3, "SULTANDAĞI" },
                    { 42, 3, "ŞUHUT" },
                    { 43, 4, "DİYADİN" },
                    { 44, 4, "DOĞUBAYAZIT" },
                    { 45, 4, "ELEŞKİRT" },
                    { 46, 4, "HAMUR" },
                    { 47, 4, "MERKEZ" },
                    { 48, 4, "PATNOS" },
                    { 49, 4, "TAŞLIÇAY" },
                    { 50, 4, "TUTAK" },
                    { 51, 5, "GÖYNÜCEK" },
                    { 52, 5, "GÜMÜŞHACIKÖY" },
                    { 53, 5, "HAMAMÖZÜ" },
                    { 54, 5, "MERKEZ" },
                    { 55, 5, "MERZİFON" },
                    { 56, 5, "SULUOVA" },
                    { 57, 5, "TAŞOVA" },
                    { 58, 6, "AKYURT" },
                    { 59, 6, "ALTINDAĞ" },
                    { 60, 6, "AYAŞ" },
                    { 61, 6, "BALA" },
                    { 62, 6, "BEYPAZARI" },
                    { 63, 6, "ÇAMLIDERE" },
                    { 64, 6, "ÇANKAYA" },
                    { 65, 6, "ÇUBUK" },
                    { 66, 6, "ELMADAĞ" },
                    { 67, 6, "ETİMESGUT" },
                    { 68, 6, "EVREN" },
                    { 69, 6, "GÖLBAŞI" },
                    { 70, 6, "GÜDÜL" },
                    { 71, 6, "HAYMANA" },
                    { 72, 6, "KAHRAMANKAZAN" },
                    { 73, 6, "KALECİK" },
                    { 74, 6, "KEÇİÖREN" },
                    { 75, 6, "KIZILCAHAMAM" },
                    { 76, 6, "MAMAK" },
                    { 77, 6, "NALLIHAN" },
                    { 78, 6, "POLATLI" },
                    { 79, 6, "PURSAKLAR" },
                    { 80, 6, "SİNCAN" },
                    { 81, 6, "ŞEREFLİKOÇHİSAR" },
                    { 82, 6, "YENİMAHALLE" },
                    { 83, 7, "AKSEKİ" },
                    { 84, 7, "AKSU" },
                    { 85, 7, "ALANYA" },
                    { 86, 7, "DEMRE" },
                    { 87, 7, "DÖŞEMEALTI" },
                    { 88, 7, "ELMALI" },
                    { 89, 7, "FİNİKE" },
                    { 90, 7, "GAZİPAŞA" },
                    { 91, 7, "GÜNDOĞMUŞ" },
                    { 92, 7, "İBRADI" },
                    { 93, 7, "KAŞ" },
                    { 94, 7, "KEMER" },
                    { 95, 7, "KEPEZ" },
                    { 96, 7, "KONYAALTI" },
                    { 97, 7, "KORKUTELİ" },
                    { 98, 7, "KUMLUCA" },
                    { 99, 7, "MANAVGAT" },
                    { 100, 7, "MURATPAŞA" },
                    { 101, 7, "SERİK" },
                    { 102, 8, "ARDANUÇ" },
                    { 103, 8, "ARHAVİ" },
                    { 104, 8, "BORÇKA" },
                    { 105, 8, "HOPA" },
                    { 106, 8, "KEMALPAŞA" },
                    { 107, 8, "MERKEZ" },
                    { 108, 8, "MURGUL" },
                    { 109, 8, "ŞAVŞAT" },
                    { 110, 8, "YUSUFELİ" },
                    { 111, 9, "BOZDOĞAN" },
                    { 112, 9, "BUHARKENT" },
                    { 113, 9, "ÇİNE" },
                    { 114, 9, "DİDİM" },
                    { 115, 9, "EFELER" },
                    { 116, 9, "GERMENCİK" },
                    { 117, 9, "İNCİRLİOVA" },
                    { 118, 9, "KARACASU" },
                    { 119, 9, "KARPUZLU" },
                    { 120, 9, "KOÇARLI" },
                    { 121, 9, "KÖŞK" },
                    { 122, 9, "KUŞADASI" },
                    { 123, 9, "KUYUCAK" },
                    { 124, 9, "NAZİLLİ" },
                    { 125, 9, "SÖKE" },
                    { 126, 9, "SULTANHİSAR" },
                    { 127, 9, "YENİPAZAR" },
                    { 128, 10, "ALTIEYLÜL" },
                    { 129, 10, "AYVALIK" },
                    { 130, 10, "BALYA" },
                    { 131, 10, "BANDIRMA" },
                    { 132, 10, "BİGADİÇ" },
                    { 133, 10, "BURHANİYE" },
                    { 134, 10, "DURSUNBEY" },
                    { 135, 10, "EDREMİT" },
                    { 136, 10, "ERDEK" },
                    { 137, 10, "GÖMEÇ" },
                    { 138, 10, "GÖNEN" },
                    { 139, 10, "HAVRAN" },
                    { 140, 10, "İVRİNDİ" },
                    { 141, 10, "KARESİ" },
                    { 142, 10, "KEPSUT" },
                    { 143, 10, "MANYAS" },
                    { 144, 10, "MARMARA" },
                    { 145, 10, "SAVAŞTEPE" },
                    { 146, 10, "SINDIRGI" },
                    { 147, 10, "SUSURLUK" },
                    { 148, 11, "BOZÜYÜK" },
                    { 149, 11, "GÖLPAZARI" },
                    { 150, 11, "İNHİSAR" },
                    { 151, 11, "MERKEZ" },
                    { 152, 11, "OSMANELİ" },
                    { 153, 11, "PAZARYERİ" },
                    { 154, 11, "SÖĞÜT" },
                    { 155, 11, "YENİPAZAR" },
                    { 156, 12, "ADAKLI" },
                    { 157, 12, "GENÇ" },
                    { 158, 12, "KARLIOVA" },
                    { 159, 12, "KİĞI" },
                    { 160, 12, "MERKEZ" },
                    { 161, 12, "SOLHAN" },
                    { 162, 12, "YAYLADERE" },
                    { 163, 12, "YEDİSU" },
                    { 164, 13, "ADİLCEVAZ" },
                    { 165, 13, "AHLAT" },
                    { 166, 13, "GÜROYMAK" },
                    { 167, 13, "HİZAN" },
                    { 168, 13, "MERKEZ" },
                    { 169, 13, "MUTKİ" },
                    { 170, 13, "TATVAN" },
                    { 171, 14, "DÖRTDİVAN" },
                    { 172, 14, "GEREDE" },
                    { 173, 14, "GÖYNÜK" },
                    { 174, 14, "KIBRISCIK" },
                    { 175, 14, "MENGEN" },
                    { 176, 14, "MERKEZ" },
                    { 177, 14, "MUDURNU" },
                    { 178, 14, "SEBEN" },
                    { 179, 14, "YENİÇAĞA" },
                    { 180, 15, "AĞLASUN" },
                    { 181, 15, "ALTINYAYLA" },
                    { 182, 15, "BUCAK" },
                    { 183, 15, "ÇAVDIR" },
                    { 184, 15, "ÇELTİKÇİ" },
                    { 185, 15, "GÖLHİSAR" },
                    { 186, 15, "KARAMANLI" },
                    { 187, 15, "KEMER" },
                    { 188, 15, "MERKEZ" },
                    { 189, 15, "TEFENNİ" },
                    { 190, 15, "YEŞİLOVA" },
                    { 191, 16, "BÜYÜKORHAN" },
                    { 192, 16, "GEMLİK" },
                    { 193, 16, "GÜRSU" },
                    { 194, 16, "HARMANCIK" },
                    { 195, 16, "İNEGÖL" },
                    { 196, 16, "İZNİK" },
                    { 197, 16, "KARACABEY" },
                    { 198, 16, "KELES" },
                    { 199, 16, "KESTEL" },
                    { 200, 16, "MUDANYA" },
                    { 201, 16, "MUSTAFAKEMALPAŞA" },
                    { 202, 16, "NİLÜFER" },
                    { 203, 16, "ORHANELİ" },
                    { 204, 16, "ORHANGAZİ" },
                    { 205, 16, "OSMANGAZİ" },
                    { 206, 16, "YENİŞEHİR" },
                    { 207, 16, "YILDIRIM" },
                    { 208, 17, "AYVACIK" },
                    { 209, 17, "BAYRAMİÇ" },
                    { 210, 17, "BİGA" },
                    { 211, 17, "BOZCAADA" },
                    { 212, 17, "ÇAN" },
                    { 213, 17, "ECEABAT" },
                    { 214, 17, "EZİNE" },
                    { 215, 17, "GELİBOLU" },
                    { 216, 17, "GÖKÇEADA" },
                    { 217, 17, "LAPSEKİ" },
                    { 218, 17, "MERKEZ" },
                    { 219, 17, "YENİCE" },
                    { 220, 18, "ATKARACALAR" },
                    { 221, 18, "BAYRAMÖREN" },
                    { 222, 18, "ÇERKEŞ" },
                    { 223, 18, "ELDİVAN" },
                    { 224, 18, "ILGAZ" },
                    { 225, 18, "KIZILIRMAK" },
                    { 226, 18, "KORGUN" },
                    { 227, 18, "KURŞUNLU" },
                    { 228, 18, "MERKEZ" },
                    { 229, 18, "ORTA" },
                    { 230, 18, "ŞABANÖZÜ" },
                    { 231, 18, "YAPRAKLI" },
                    { 232, 19, "ALACA" },
                    { 233, 19, "BAYAT" },
                    { 234, 19, "BOĞAZKALE" },
                    { 235, 19, "DODURGA" },
                    { 236, 19, "İSKİLİP" },
                    { 237, 19, "KARGI" },
                    { 238, 19, "LAÇİN" },
                    { 239, 19, "MECİTÖZÜ" },
                    { 240, 19, "MERKEZ" },
                    { 241, 19, "OĞUZLAR" },
                    { 242, 19, "ORTAKÖY" },
                    { 243, 19, "OSMANCIK" },
                    { 244, 19, "SUNGURLU" },
                    { 245, 19, "UĞURLUDAĞ" },
                    { 246, 20, "ACIPAYAM" },
                    { 247, 20, "BABADAĞ" },
                    { 248, 20, "BAKLAN" },
                    { 249, 20, "BEKİLLİ" },
                    { 250, 20, "BEYAĞAÇ" },
                    { 251, 20, "BOZKURT" },
                    { 252, 20, "BULDAN" },
                    { 253, 20, "ÇAL" },
                    { 254, 20, "ÇAMELİ" },
                    { 255, 20, "ÇARDAK" },
                    { 256, 20, "ÇİVRİL" },
                    { 257, 20, "GÜNEY" },
                    { 258, 20, "HONAZ" },
                    { 259, 20, "KALE" },
                    { 260, 20, "MERKEZEFENDİ" },
                    { 261, 20, "PAMUKKALE" },
                    { 262, 20, "SARAYKÖY" },
                    { 263, 20, "SERİNHİSAR" },
                    { 264, 20, "TAVAS" },
                    { 265, 21, "BAĞLAR" },
                    { 266, 21, "BİSMİL" },
                    { 267, 21, "ÇERMİK" },
                    { 268, 21, "ÇINAR" },
                    { 269, 21, "ÇÜNGÜŞ" },
                    { 270, 21, "DİCLE" },
                    { 271, 21, "EĞİL" },
                    { 272, 21, "ERGANİ" },
                    { 273, 21, "HANİ" },
                    { 274, 21, "HAZRO" },
                    { 275, 21, "KAYAPINAR" },
                    { 276, 21, "KOCAKÖY" },
                    { 277, 21, "KULP" },
                    { 278, 21, "LİCE" },
                    { 279, 21, "SİLVAN" },
                    { 280, 21, "SUR" },
                    { 281, 21, "YENİŞEHİR" },
                    { 282, 22, "ENEZ" },
                    { 283, 22, "HAVSA" },
                    { 284, 22, "İPSALA" },
                    { 285, 22, "KEŞAN" },
                    { 286, 22, "LALAPAŞA" },
                    { 287, 22, "MERİÇ" },
                    { 288, 22, "MERKEZ" },
                    { 289, 22, "SÜLOĞLU" },
                    { 290, 22, "UZUNKÖPRÜ" },
                    { 291, 23, "AĞIN" },
                    { 292, 23, "ALACAKAYA" },
                    { 293, 23, "ARICAK" },
                    { 294, 23, "BASKİL" },
                    { 295, 23, "KARAKOÇAN" },
                    { 296, 23, "KEBAN" },
                    { 297, 23, "KOVANCILAR" },
                    { 298, 23, "MADEN" },
                    { 299, 23, "MERKEZ" },
                    { 300, 23, "PALU" },
                    { 301, 23, "SİVRİCE" },
                    { 302, 24, "ÇAYIRLI" },
                    { 303, 24, "İLİÇ" },
                    { 304, 24, "KEMAH" },
                    { 305, 24, "KEMALİYE" },
                    { 306, 24, "MERKEZ" },
                    { 307, 24, "OTLUKBELİ" },
                    { 308, 24, "REFAHİYE" },
                    { 309, 24, "TERCAN" },
                    { 310, 24, "ÜZÜMLÜ" },
                    { 311, 25, "AŞKALE" },
                    { 312, 25, "AZİZİYE" },
                    { 313, 25, "ÇAT" },
                    { 314, 25, "HINIS" },
                    { 315, 25, "HORASAN" },
                    { 316, 25, "İSPİR" },
                    { 317, 25, "KARAÇOBAN" },
                    { 318, 25, "KARAYAZI" },
                    { 319, 25, "KÖPRÜKÖY" },
                    { 320, 25, "NARMAN" },
                    { 321, 25, "OLTU" },
                    { 322, 25, "OLUR" },
                    { 323, 25, "PALANDÖKEN" },
                    { 324, 25, "PASİNLER" },
                    { 325, 25, "PAZARYOLU" },
                    { 326, 25, "ŞENKAYA" },
                    { 327, 25, "TEKMAN" },
                    { 328, 25, "TORTUM" },
                    { 329, 25, "UZUNDERE" },
                    { 330, 25, "YAKUTİYE" },
                    { 331, 26, "ALPU" },
                    { 332, 26, "BEYLİKOVA" },
                    { 333, 26, "ÇİFTELER" },
                    { 334, 26, "GÜNYÜZÜ" },
                    { 335, 26, "HAN" },
                    { 336, 26, "İNÖNÜ" },
                    { 337, 26, "MAHMUDİYE" },
                    { 338, 26, "MİHALGAZİ" },
                    { 339, 26, "MİHALIÇÇIK" },
                    { 340, 26, "ODUNPAZARI" },
                    { 341, 26, "SARICAKAYA" },
                    { 342, 26, "SEYİTGAZİ" },
                    { 343, 26, "SİVRİHİSAR" },
                    { 344, 26, "TEPEBAŞI" },
                    { 345, 27, "ARABAN" },
                    { 346, 27, "İSLAHİYE" },
                    { 347, 27, "KARKAMIŞ" },
                    { 348, 27, "NİZİP" },
                    { 349, 27, "NURDAĞI" },
                    { 350, 27, "OĞUZELİ" },
                    { 351, 27, "ŞAHİNBEY" },
                    { 352, 27, "ŞEHİTKAMİL" },
                    { 353, 27, "YAVUZELİ" },
                    { 354, 28, "ALUCRA" },
                    { 355, 28, "BULANCAK" },
                    { 356, 28, "ÇAMOLUK" },
                    { 357, 28, "ÇANAKÇI" },
                    { 358, 28, "DERELİ" },
                    { 359, 28, "DOĞANKENT" },
                    { 360, 28, "ESPİYE" },
                    { 361, 28, "EYNESİL" },
                    { 362, 28, "GÖRELE" },
                    { 363, 28, "GÜCE" },
                    { 364, 28, "KEŞAP" },
                    { 365, 28, "MERKEZ" },
                    { 366, 28, "PİRAZİZ" },
                    { 367, 28, "ŞEBİNKARAHİSAR" },
                    { 368, 28, "TİREBOLU" },
                    { 369, 28, "YAĞLIDERE" },
                    { 370, 29, "KELKİT" },
                    { 371, 29, "KÖSE" },
                    { 372, 29, "KÜRTÜN" },
                    { 373, 29, "MERKEZ" },
                    { 374, 29, "ŞİRAN" },
                    { 375, 29, "TORUL" },
                    { 376, 30, "ÇUKURCA" },
                    { 377, 30, "DERECİK" },
                    { 378, 30, "MERKEZ" },
                    { 379, 30, "ŞEMDİNLİ" },
                    { 380, 30, "YÜKSEKOVA" },
                    { 381, 31, "ALTINÖZÜ" },
                    { 382, 31, "ANTAKYA" },
                    { 383, 31, "ARSUZ" },
                    { 384, 31, "BELEN" },
                    { 385, 31, "DEFNE" },
                    { 386, 31, "DÖRTYOL" },
                    { 387, 31, "ERZİN" },
                    { 388, 31, "HASSA" },
                    { 389, 31, "İSKENDERUN" },
                    { 390, 31, "KIRIKHAN" },
                    { 391, 31, "KUMLU" },
                    { 392, 31, "PAYAS" },
                    { 393, 31, "REYHANLI" },
                    { 394, 31, "SAMANDAĞ" },
                    { 395, 31, "YAYLADAĞI" },
                    { 396, 32, "AKSU" },
                    { 397, 32, "ATABEY" },
                    { 398, 32, "EĞİRDİR" },
                    { 399, 32, "GELENDOST" },
                    { 400, 32, "GÖNEN" },
                    { 401, 32, "KEÇİBORLU" },
                    { 402, 32, "MERKEZ" },
                    { 403, 32, "SENİRKENT" },
                    { 404, 32, "SÜTÇÜLER" },
                    { 405, 32, "ŞARKİKARAAĞAÇ" },
                    { 406, 32, "ULUBORLU" },
                    { 407, 32, "YALVAÇ" },
                    { 408, 32, "YENİŞARBADEMLİ" },
                    { 409, 33, "AKDENİZ" },
                    { 410, 33, "ANAMUR" },
                    { 411, 33, "AYDINCIK" },
                    { 412, 33, "BOZYAZI" },
                    { 413, 33, "ÇAMLIYAYLA" },
                    { 414, 33, "ERDEMLİ" },
                    { 415, 33, "GÜLNAR" },
                    { 416, 33, "MEZİTLİ" },
                    { 417, 33, "MUT" },
                    { 418, 33, "SİLİFKE" },
                    { 419, 33, "TARSUS" },
                    { 420, 33, "TOROSLAR" },
                    { 421, 33, "YENİŞEHİR" },
                    { 422, 34, "ADALAR" },
                    { 423, 34, "ARNAVUTKÖY" },
                    { 424, 34, "ATAŞEHİR" },
                    { 425, 34, "AVCILAR" },
                    { 426, 34, "BAĞCILAR" },
                    { 427, 34, "BAHÇELİEVLER" },
                    { 428, 34, "BAKIRKÖY" },
                    { 429, 34, "BAŞAKŞEHİR" },
                    { 430, 34, "BAYRAMPAŞA" },
                    { 431, 34, "BEŞİKTAŞ" },
                    { 432, 34, "BEYKOZ" },
                    { 433, 34, "BEYLİKDÜZÜ" },
                    { 434, 34, "BEYOĞLU" },
                    { 435, 34, "BÜYÜKÇEKMECE" },
                    { 436, 34, "ÇATALCA" },
                    { 437, 34, "ÇEKMEKÖY" },
                    { 438, 34, "ESENLER" },
                    { 439, 34, "ESENYURT" },
                    { 440, 34, "EYÜPSULTAN" },
                    { 441, 34, "FATİH" },
                    { 442, 34, "GAZİOSMANPAŞA" },
                    { 443, 34, "GÜNGÖREN" },
                    { 444, 34, "KADIKÖY" },
                    { 445, 34, "KAĞITHANE" },
                    { 446, 34, "KARTAL" },
                    { 447, 34, "KÜÇÜKÇEKMECE" },
                    { 448, 34, "MALTEPE" },
                    { 449, 34, "PENDİK" },
                    { 450, 34, "SANCAKTEPE" },
                    { 451, 34, "SARIYER" },
                    { 452, 34, "SİLİVRİ" },
                    { 453, 34, "SULTANBEYLİ" },
                    { 454, 34, "SULTANGAZİ" },
                    { 455, 34, "ŞİLE" },
                    { 456, 34, "ŞİŞLİ" },
                    { 457, 34, "TUZLA" },
                    { 458, 34, "ÜMRANİYE" },
                    { 459, 34, "ÜSKÜDAR" },
                    { 460, 34, "ZEYTİNBURNU" },
                    { 461, 35, "ALİAĞA" },
                    { 462, 35, "BALÇOVA" },
                    { 463, 35, "BAYINDIR" },
                    { 464, 35, "BAYRAKLI" },
                    { 465, 35, "BERGAMA" },
                    { 466, 35, "BEYDAĞ" },
                    { 467, 35, "BORNOVA" },
                    { 468, 35, "BUCA" },
                    { 469, 35, "ÇEŞME" },
                    { 470, 35, "ÇİĞLİ" },
                    { 471, 35, "DİKİLİ" },
                    { 472, 35, "FOÇA" },
                    { 473, 35, "GAZİEMİR" },
                    { 474, 35, "GÜZELBAHÇE" },
                    { 475, 35, "KARABAĞLAR" },
                    { 476, 35, "KARABURUN" },
                    { 477, 35, "KARŞIYAKA" },
                    { 478, 35, "KEMALPAŞA" },
                    { 479, 35, "KINIK" },
                    { 480, 35, "KİRAZ" },
                    { 481, 35, "KONAK" },
                    { 482, 35, "MENDERES" },
                    { 483, 35, "MENEMEN" },
                    { 484, 35, "NARLIDERE" },
                    { 485, 35, "ÖDEMİŞ" },
                    { 486, 35, "SEFERİHİSAR" },
                    { 487, 35, "SELÇUK" },
                    { 488, 35, "TİRE" },
                    { 489, 35, "TORBALI" },
                    { 490, 35, "URLA" },
                    { 491, 36, "AKYAKA" },
                    { 492, 36, "ARPAÇAY" },
                    { 493, 36, "DİGOR" },
                    { 494, 36, "KAĞIZMAN" },
                    { 495, 36, "MERKEZ" },
                    { 496, 36, "SARIKAMIŞ" },
                    { 497, 36, "SELİM" },
                    { 498, 36, "SUSUZ" },
                    { 499, 37, "ABANA" },
                    { 500, 37, "AĞLI" },
                    { 501, 37, "ARAÇ" },
                    { 502, 37, "AZDAVAY" },
                    { 503, 37, "BOZKURT" },
                    { 504, 37, "CİDE" },
                    { 505, 37, "ÇATALZEYTİN" },
                    { 506, 37, "DADAY" },
                    { 507, 37, "DEVREKANİ" },
                    { 508, 37, "DOĞANYURT" },
                    { 509, 37, "HANÖNÜ" },
                    { 510, 37, "İHSANGAZİ" },
                    { 511, 37, "İNEBOLU" },
                    { 512, 37, "KÜRE" },
                    { 513, 37, "MERKEZ" },
                    { 514, 37, "PINARBAŞI" },
                    { 515, 37, "SEYDİLER" },
                    { 516, 37, "ŞENPAZAR" },
                    { 517, 37, "TAŞKÖPRÜ" },
                    { 518, 37, "TOSYA" },
                    { 519, 38, "AKKIŞLA" },
                    { 520, 38, "BÜNYAN" },
                    { 521, 38, "DEVELİ" },
                    { 522, 38, "FELAHİYE" },
                    { 523, 38, "HACILAR" },
                    { 524, 38, "İNCESU" },
                    { 525, 38, "KOCASİNAN" },
                    { 526, 38, "MELİKGAZİ" },
                    { 527, 38, "ÖZVATAN" },
                    { 528, 38, "PINARBAŞI" },
                    { 529, 38, "SARIOĞLAN" },
                    { 530, 38, "SARIZ" },
                    { 531, 38, "TALAS" },
                    { 532, 38, "TOMARZA" },
                    { 533, 38, "YAHYALI" },
                    { 534, 38, "YEŞİLHİSAR" },
                    { 535, 39, "BABAESKİ" },
                    { 536, 39, "DEMİRKÖY" },
                    { 537, 39, "KOFÇAZ" },
                    { 538, 39, "LÜLEBURGAZ" },
                    { 539, 39, "MERKEZ" },
                    { 540, 39, "PEHLİVANKÖY" },
                    { 541, 39, "PINARHİSAR" },
                    { 542, 39, "VİZE" },
                    { 543, 40, "AKÇAKENT" },
                    { 544, 40, "AKPINAR" },
                    { 545, 40, "BOZTEPE" },
                    { 546, 40, "ÇİÇEKDAĞI" },
                    { 547, 40, "KAMAN" },
                    { 548, 40, "MERKEZ" },
                    { 549, 40, "MUCUR" },
                    { 550, 41, "BAŞİSKELE" },
                    { 551, 41, "ÇAYIROVA" },
                    { 552, 41, "DARICA" },
                    { 553, 41, "DERİNCE" },
                    { 554, 41, "DİLOVASI" },
                    { 555, 41, "GEBZE" },
                    { 556, 41, "GÖLCÜK" },
                    { 557, 41, "İZMİT" },
                    { 558, 41, "KANDIRA" },
                    { 559, 41, "KARAMÜRSEL" },
                    { 560, 41, "KARTEPE" },
                    { 561, 41, "KÖRFEZ" },
                    { 562, 42, "AHIRLI" },
                    { 563, 42, "AKÖREN" },
                    { 564, 42, "AKŞEHİR" },
                    { 565, 42, "ALTINEKİN" },
                    { 566, 42, "BEYŞEHİR" },
                    { 567, 42, "BOZKIR" },
                    { 568, 42, "CİHANBEYLİ" },
                    { 569, 42, "ÇELTİK" },
                    { 570, 42, "ÇUMRA" },
                    { 571, 42, "DERBENT" },
                    { 572, 42, "DEREBUCAK" },
                    { 573, 42, "DOĞANHİSAR" },
                    { 574, 42, "EMİRGAZİ" },
                    { 575, 42, "EREĞLİ" },
                    { 576, 42, "GÜNEYSINIR" },
                    { 577, 42, "HADİM" },
                    { 578, 42, "HALKAPINAR" },
                    { 579, 42, "HÜYÜK" },
                    { 580, 42, "ILGIN" },
                    { 581, 42, "KADINHANI" },
                    { 582, 42, "KARAPINAR" },
                    { 583, 42, "KARATAY" },
                    { 584, 42, "KULU" },
                    { 585, 42, "MERAM" },
                    { 586, 42, "SARAYÖNÜ" },
                    { 587, 42, "SELÇUKLU" },
                    { 588, 42, "SEYDİŞEHİR" },
                    { 589, 42, "TAŞKENT" },
                    { 590, 42, "TUZLUKÇU" },
                    { 591, 42, "YALIHÜYÜK" },
                    { 592, 42, "YUNAK" },
                    { 593, 43, "ALTINTAŞ" },
                    { 594, 43, "ASLANAPA" },
                    { 595, 43, "ÇAVDARHİSAR" },
                    { 596, 43, "DOMANİÇ" },
                    { 597, 43, "DUMLUPINAR" },
                    { 598, 43, "EMET" },
                    { 599, 43, "GEDİZ" },
                    { 600, 43, "HİSARCIK" },
                    { 601, 43, "MERKEZ" },
                    { 602, 43, "PAZARLAR" },
                    { 603, 43, "SİMAV" },
                    { 604, 43, "ŞAPHANE" },
                    { 605, 43, "TAVŞANLI" },
                    { 606, 44, "AKÇADAĞ" },
                    { 607, 44, "ARAPGİR" },
                    { 608, 44, "ARGUVAN" },
                    { 609, 44, "BATTALGAZİ" },
                    { 610, 44, "DARENDE" },
                    { 611, 44, "DOĞANŞEHİR" },
                    { 612, 44, "DOĞANYOL" },
                    { 613, 44, "HEKİMHAN" },
                    { 614, 44, "KALE" },
                    { 615, 44, "KULUNCAK" },
                    { 616, 44, "PÜTÜRGE" },
                    { 617, 44, "YAZIHAN" },
                    { 618, 44, "YEŞİLYURT" },
                    { 619, 45, "AHMETLİ" },
                    { 620, 45, "AKHİSAR" },
                    { 621, 45, "ALAŞEHİR" },
                    { 622, 45, "DEMİRCİ" },
                    { 623, 45, "GÖLMARMARA" },
                    { 624, 45, "GÖRDES" },
                    { 625, 45, "KIRKAĞAÇ" },
                    { 626, 45, "KÖPRÜBAŞI" },
                    { 627, 45, "KULA" },
                    { 628, 45, "SALİHLİ" },
                    { 629, 45, "SARIGÖL" },
                    { 630, 45, "SARUHANLI" },
                    { 631, 45, "SELENDİ" },
                    { 632, 45, "SOMA" },
                    { 633, 45, "ŞEHZADELER" },
                    { 634, 45, "TURGUTLU" },
                    { 635, 45, "YUNUSEMRE" },
                    { 636, 46, "AFŞİN" },
                    { 637, 46, "ANDIRIN" },
                    { 638, 46, "ÇAĞLAYANCERİT" },
                    { 639, 46, "DULKADİROĞLU" },
                    { 640, 46, "EKİNÖZÜ" },
                    { 641, 46, "ELBİSTAN" },
                    { 642, 46, "GÖKSUN" },
                    { 643, 46, "NURHAK" },
                    { 644, 46, "ONİKİŞUBAT" },
                    { 645, 46, "PAZARCIK" },
                    { 646, 46, "TÜRKOĞLU" },
                    { 647, 47, "ARTUKLU" },
                    { 648, 47, "DARGEÇİT" },
                    { 649, 47, "DERİK" },
                    { 650, 47, "KIZILTEPE" },
                    { 651, 47, "MAZIDAĞI" },
                    { 652, 47, "MİDYAT" },
                    { 653, 47, "NUSAYBİN" },
                    { 654, 47, "ÖMERLİ" },
                    { 655, 47, "SAVUR" },
                    { 656, 47, "YEŞİLLİ" },
                    { 657, 48, "BODRUM" },
                    { 658, 48, "DALAMAN" },
                    { 659, 48, "DATÇA" },
                    { 660, 48, "FETHİYE" },
                    { 661, 48, "KAVAKLIDERE" },
                    { 662, 48, "KÖYCEĞİZ" },
                    { 663, 48, "MARMARİS" },
                    { 664, 48, "MENTEŞE" },
                    { 665, 48, "MİLAS" },
                    { 666, 48, "ORTACA" },
                    { 667, 48, "SEYDİKEMER" },
                    { 668, 48, "ULA" },
                    { 669, 48, "YATAĞAN" },
                    { 670, 49, "BULANIK" },
                    { 671, 49, "HASKÖY" },
                    { 672, 49, "KORKUT" },
                    { 673, 49, "MALAZGİRT" },
                    { 674, 49, "MERKEZ" },
                    { 675, 49, "VARTO" },
                    { 676, 50, "ACIGÖL" },
                    { 677, 50, "AVANOS" },
                    { 678, 50, "DERİNKUYU" },
                    { 679, 50, "GÜLŞEHİR" },
                    { 680, 50, "HACIBEKTAŞ" },
                    { 681, 50, "KOZAKLI" },
                    { 682, 50, "MERKEZ" },
                    { 683, 50, "ÜRGÜP" },
                    { 684, 51, "ALTUNHİSAR" },
                    { 685, 51, "BOR" },
                    { 686, 51, "ÇAMARDI" },
                    { 687, 51, "ÇİFTLİK" },
                    { 688, 51, "MERKEZ" },
                    { 689, 51, "ULUKIŞLA" },
                    { 690, 52, "AKKUŞ" },
                    { 691, 52, "ALTINORDU" },
                    { 692, 52, "AYBASTI" },
                    { 693, 52, "ÇAMAŞ" },
                    { 694, 52, "ÇATALPINAR" },
                    { 695, 52, "ÇAYBAŞI" },
                    { 696, 52, "FATSA" },
                    { 697, 52, "GÖLKÖY" },
                    { 698, 52, "GÜLYALI" },
                    { 699, 52, "GÜRGENTEPE" },
                    { 700, 52, "İKİZCE" },
                    { 701, 52, "KABADÜZ" },
                    { 702, 52, "KABATAŞ" },
                    { 703, 52, "KORGAN" },
                    { 704, 52, "KUMRU" },
                    { 705, 52, "MESUDİYE" },
                    { 706, 52, "PERŞEMBE" },
                    { 707, 52, "ULUBEY" },
                    { 708, 52, "ÜNYE" },
                    { 709, 53, "ARDEŞEN" },
                    { 710, 53, "ÇAMLIHEMŞİN" },
                    { 711, 53, "ÇAYELİ" },
                    { 712, 53, "DEREPAZARI" },
                    { 713, 53, "FINDIKLI" },
                    { 714, 53, "GÜNEYSU" },
                    { 715, 53, "HEMŞİN" },
                    { 716, 53, "İKİZDERE" },
                    { 717, 53, "İYİDERE" },
                    { 718, 53, "KALKANDERE" },
                    { 719, 53, "MERKEZ" },
                    { 720, 53, "PAZAR" },
                    { 721, 54, "ADAPAZARI" },
                    { 722, 54, "AKYAZI" },
                    { 723, 54, "ARİFİYE" },
                    { 724, 54, "ERENLER" },
                    { 725, 54, "FERİZLİ" },
                    { 726, 54, "GEYVE" },
                    { 727, 54, "HENDEK" },
                    { 728, 54, "KARAPÜRÇEK" },
                    { 729, 54, "KARASU" },
                    { 730, 54, "KAYNARCA" },
                    { 731, 54, "KOCAALİ" },
                    { 732, 54, "PAMUKOVA" },
                    { 733, 54, "SAPANCA" },
                    { 734, 54, "SERDİVAN" },
                    { 735, 54, "SÖĞÜTLÜ" },
                    { 736, 54, "TARAKLI" },
                    { 737, 55, "ALAÇAM" },
                    { 738, 55, "ASARCIK" },
                    { 739, 55, "ATAKUM" },
                    { 740, 55, "AYVACIK" },
                    { 741, 55, "BAFRA" },
                    { 742, 55, "CANİK" },
                    { 743, 55, "ÇARŞAMBA" },
                    { 744, 55, "HAVZA" },
                    { 745, 55, "İLKADIM" },
                    { 746, 55, "KAVAK" },
                    { 747, 55, "LADİK" },
                    { 748, 55, "SALIPAZARI" },
                    { 749, 55, "TEKKEKÖY" },
                    { 750, 55, "TERME" },
                    { 751, 55, "VEZİRKÖPRÜ" },
                    { 752, 55, "YAKAKENT" },
                    { 753, 55, "19 MAYIS" },
                    { 754, 56, "BAYKAN" },
                    { 755, 56, "ERUH" },
                    { 756, 56, "KURTALAN" },
                    { 757, 56, "MERKEZ" },
                    { 758, 56, "PERVARİ" },
                    { 759, 56, "ŞİRVAN" },
                    { 760, 56, "TİLLO" },
                    { 761, 57, "AYANCIK" },
                    { 762, 57, "BOYABAT" },
                    { 763, 57, "DİKMEN" },
                    { 764, 57, "DURAĞAN" },
                    { 765, 57, "ERFELEK" },
                    { 766, 57, "GERZE" },
                    { 767, 57, "MERKEZ" },
                    { 768, 57, "SARAYDÜZÜ" },
                    { 769, 57, "TÜRKELİ" },
                    { 770, 58, "AKINCILAR" },
                    { 771, 58, "ALTINYAYLA" },
                    { 772, 58, "DİVRİĞİ" },
                    { 773, 58, "DOĞANŞAR" },
                    { 774, 58, "GEMEREK" },
                    { 775, 58, "GÖLOVA" },
                    { 776, 58, "GÜRÜN" },
                    { 777, 58, "HAFİK" },
                    { 778, 58, "İMRANLI" },
                    { 779, 58, "KANGAL" },
                    { 780, 58, "KOYULHİSAR" },
                    { 781, 58, "MERKEZ" },
                    { 782, 58, "SUŞEHRİ" },
                    { 783, 58, "ŞARKIŞLA" },
                    { 784, 58, "ULAŞ" },
                    { 785, 58, "YILDIZELİ" },
                    { 786, 58, "ZARA" },
                    { 787, 59, "ÇERKEZKÖY" },
                    { 788, 59, "ÇORLU" },
                    { 789, 59, "ERGENE" },
                    { 790, 59, "HAYRABOLU" },
                    { 791, 59, "KAPAKLI" },
                    { 792, 59, "MALKARA" },
                    { 793, 59, "MARMARAEREĞLİSİ" },
                    { 794, 59, "MURATLI" },
                    { 795, 59, "SARAY" },
                    { 796, 59, "SÜLEYMANPAŞA" },
                    { 797, 59, "ŞARKÖY" },
                    { 798, 60, "ALMUS" },
                    { 799, 60, "ARTOVA" },
                    { 800, 60, "BAŞÇİFTLİK" },
                    { 801, 60, "ERBAA" },
                    { 802, 60, "MERKEZ" },
                    { 803, 60, "NİKSAR" },
                    { 804, 60, "PAZAR" },
                    { 805, 60, "REŞADİYE" },
                    { 806, 60, "SULUSARAY" },
                    { 807, 60, "TURHAL" },
                    { 808, 60, "YEŞİLYURT" },
                    { 809, 60, "ZİLE" },
                    { 810, 61, "AKÇAABAT" },
                    { 811, 61, "ARAKLI" },
                    { 812, 61, "ARSİN" },
                    { 813, 61, "BEŞİKDÜZÜ" },
                    { 814, 61, "ÇARŞIBAŞI" },
                    { 815, 61, "ÇAYKARA" },
                    { 816, 61, "DERNEKPAZARI" },
                    { 817, 61, "DÜZKÖY" },
                    { 818, 61, "HAYRAT" },
                    { 819, 61, "KÖPRÜBAŞI" },
                    { 820, 61, "MAÇKA" },
                    { 821, 61, "OF" },
                    { 822, 61, "ORTAHİSAR" },
                    { 823, 61, "SÜRMENE" },
                    { 824, 61, "ŞALPAZARI" },
                    { 825, 61, "TONYA" },
                    { 826, 61, "VAKFIKEBİR" },
                    { 827, 61, "YOMRA" },
                    { 828, 62, "ÇEMİŞGEZEK" },
                    { 829, 62, "HOZAT" },
                    { 830, 62, "MAZGİRT" },
                    { 831, 62, "MERKEZ" },
                    { 832, 62, "NAZIMİYE" },
                    { 833, 62, "OVACIK" },
                    { 834, 62, "PERTEK" },
                    { 835, 62, "PÜLÜMÜR" },
                    { 836, 63, "AKÇAKALE" },
                    { 837, 63, "BİRECİK" },
                    { 838, 63, "BOZOVA" },
                    { 839, 63, "CEYLANPINAR" },
                    { 840, 63, "EYYÜBİYE" },
                    { 841, 63, "HALFETİ" },
                    { 842, 63, "HALİLİYE" },
                    { 843, 63, "HARRAN" },
                    { 844, 63, "HİLVAN" },
                    { 845, 63, "KARAKÖPRÜ" },
                    { 846, 63, "SİVEREK" },
                    { 847, 63, "SURUÇ" },
                    { 848, 63, "VİRANŞEHİR" },
                    { 849, 64, "BANAZ" },
                    { 850, 64, "EŞME" },
                    { 851, 64, "KARAHALLI" },
                    { 852, 64, "MERKEZ" },
                    { 853, 64, "SİVASLI" },
                    { 854, 64, "ULUBEY" },
                    { 855, 65, "BAHÇESARAY" },
                    { 856, 65, "BAŞKALE" },
                    { 857, 65, "ÇALDIRAN" },
                    { 858, 65, "ÇATAK" },
                    { 859, 65, "EDREMİT" },
                    { 860, 65, "ERCİŞ" },
                    { 861, 65, "GEVAŞ" },
                    { 862, 65, "GÜRPINAR" },
                    { 863, 65, "İPEKYOLU" },
                    { 864, 65, "MURADİYE" },
                    { 865, 65, "ÖZALP" },
                    { 866, 65, "SARAY" },
                    { 867, 65, "TUŞBA" },
                    { 868, 66, "AKDAĞMADENİ" },
                    { 869, 66, "AYDINCIK" },
                    { 870, 66, "BOĞAZLIYAN" },
                    { 871, 66, "ÇANDIR" },
                    { 872, 66, "ÇAYIRALAN" },
                    { 873, 66, "ÇEKEREK" },
                    { 874, 66, "KADIŞEHRİ" },
                    { 875, 66, "MERKEZ" },
                    { 876, 66, "SARAYKENT" },
                    { 877, 66, "SARIKAYA" },
                    { 878, 66, "SORGUN" },
                    { 879, 66, "ŞEFAATLİ" },
                    { 880, 66, "YENİFAKILI" },
                    { 881, 66, "YERKÖY" },
                    { 882, 67, "ALAPLI" },
                    { 883, 67, "ÇAYCUMA" },
                    { 884, 67, "DEVREK" },
                    { 885, 67, "EREĞLİ" },
                    { 886, 67, "GÖKÇEBEY" },
                    { 887, 67, "KİLİMLİ" },
                    { 888, 67, "KOZLU" },
                    { 889, 67, "MERKEZ" },
                    { 890, 68, "AĞAÇÖREN" },
                    { 891, 68, "ESKİL" },
                    { 892, 68, "GÜLAĞAÇ" },
                    { 893, 68, "GÜZELYURT" },
                    { 894, 68, "MERKEZ" },
                    { 895, 68, "ORTAKÖY" },
                    { 896, 68, "SARIYAHŞİ" },
                    { 897, 68, "SULTANHANI" },
                    { 898, 69, "AYDINTEPE" },
                    { 899, 69, "DEMİRÖZÜ" },
                    { 900, 69, "MERKEZ" },
                    { 901, 70, "AYRANCI" },
                    { 902, 70, "BAŞYAYLA" },
                    { 903, 70, "ERMENEK" },
                    { 904, 70, "KAZIMKARABEKİR" },
                    { 905, 70, "MERKEZ" },
                    { 906, 70, "SARIVELİLER" },
                    { 907, 71, "BAHŞİLİ" },
                    { 908, 71, "BALIŞEYH" },
                    { 909, 71, "ÇELEBİ" },
                    { 910, 71, "DELİCE" },
                    { 911, 71, "KARAKEÇİLİ" },
                    { 912, 71, "KESKİN" },
                    { 913, 71, "MERKEZ" },
                    { 914, 71, "SULAKYURT" },
                    { 915, 71, "YAHŞİHAN" },
                    { 916, 72, "BEŞİRİ" },
                    { 917, 72, "GERCÜŞ" },
                    { 918, 72, "HASANKEYF" },
                    { 919, 72, "KOZLUK" },
                    { 920, 72, "MERKEZ" },
                    { 921, 72, "SASON" },
                    { 922, 73, "BEYTÜŞŞEBAP" },
                    { 923, 73, "CİZRE" },
                    { 924, 73, "GÜÇLÜKONAK" },
                    { 925, 73, "İDİL" },
                    { 926, 73, "MERKEZ" },
                    { 927, 73, "SİLOPİ" },
                    { 928, 73, "ULUDERE" },
                    { 929, 74, "AMASRA" },
                    { 930, 74, "KURUCAŞİLE" },
                    { 931, 74, "MERKEZ" },
                    { 932, 74, "ULUS" },
                    { 933, 75, "ÇILDIR" },
                    { 934, 75, "DAMAL" },
                    { 935, 75, "GÖLE" },
                    { 936, 75, "HANAK" },
                    { 937, 75, "MERKEZ" },
                    { 938, 75, "POSOF" },
                    { 939, 76, "ARALIK" },
                    { 940, 76, "KARAKOYUNLU" },
                    { 941, 76, "MERKEZ" },
                    { 942, 76, "TUZLUCA" },
                    { 943, 77, "ALTINOVA" },
                    { 944, 77, "ARMUTLU" },
                    { 945, 77, "ÇINARCIK" },
                    { 946, 77, "ÇİFTLİKKÖY" },
                    { 947, 77, "MERKEZ" },
                    { 948, 77, "TERMAL" },
                    { 949, 78, "EFLANİ" },
                    { 950, 78, "ESKİPAZAR" },
                    { 951, 78, "MERKEZ" },
                    { 952, 78, "OVACIK" },
                    { 953, 78, "SAFRANBOLU" },
                    { 954, 78, "YENİCE" },
                    { 955, 79, "ELBEYLİ" },
                    { 956, 79, "MERKEZ" },
                    { 957, 79, "MUSABEYLİ" },
                    { 958, 79, "POLATELİ" },
                    { 959, 80, "BAHÇE" },
                    { 960, 80, "DÜZİÇİ" },
                    { 961, 80, "HASANBEYLİ" },
                    { 962, 80, "KADİRLİ" },
                    { 963, 80, "MERKEZ" },
                    { 964, 80, "SUMBAS" },
                    { 965, 80, "TOPRAKKALE" },
                    { 966, 81, "AKÇAKOCA" },
                    { 967, 81, "CUMAYERİ" },
                    { 968, 81, "ÇİLİMLİ" },
                    { 969, 81, "GÖLYAKA" },
                    { 970, 81, "GÜMÜŞOVA" },
                    { 971, 81, "KAYNAŞLI" },
                    { 972, 81, "MERKEZ" },
                    { 973, 81, "YIĞILCA" }
                });

            migrationBuilder.InsertData(
                table: "Dosyalar",
                columns: new[] { "Id", "AcilisTarihi", "Adi", "DogumTarihi", "DosyaDurum", "Durum", "EklenmeTarihi", "GuncellenmeTarihi", "HaklilikOrani", "KapanisTarihi", "KazaTarihi", "SakatlikOrani", "SilinmeTarihi", "Soyadi", "Tc", "Telefon", "basvuruturId", "davaturId", "ilId", "ilceId" },
                values: new object[] { 1, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3255), "Deneme", new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3252), 1, false, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3256), null, 10m, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3255), new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(3254), 10m, null, "Dosya", "11111111111", "5555555555", 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "kullanicilar",
                columns: new[] { "Id", "Adi", "Durum", "EklenmeTarihi", "GuncellenmeTarihi", "IlId", "IlceId", "KullaniciAdi", "Sifre", "SilinmeTarihi", "Soyadi" },
                values: new object[] { 1, "Büşra", false, new DateTime(2025, 4, 4, 16, 1, 26, 888, DateTimeKind.Local).AddTicks(4857), null, 1, 1, "busra", "12345", null, "Güneş" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dosyalar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EvrakTurler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "kullanicilar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BasvuruTurleri",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DavaTurleri",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ilceler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Iller",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
