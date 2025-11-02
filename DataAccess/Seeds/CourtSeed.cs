using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
	public class CourtSeed : IEntityTypeConfiguration<Court>
	{
		public void Configure(EntityTypeBuilder<Court> builder)
		{
			builder.HasData(
				// --- Merkez (Haliliye / Eyyübiye / Karaköprü) ---
				new Court
				{
					ID = 1,
					Name = "Şanlıurfa Adliyesi",
					Address = "Yenice Mah. Adliye Sarayı, Haliliye / Şanlıurfa",
					CityID = 63,
					DistrictID = 842, // Haliliye
					Phone = "0414 318 10 00",
					Email = "sanliurfa@adalet.gov.tr",
					CourtType = "Adliye"
				},
				new Court
				{
					ID = 2,
					Name = "Şanlıurfa 1. Asliye Hukuk Mahkemesi",
					Address = "Şanlıurfa Adliyesi, Haliliye / Şanlıurfa",
					CityID = 63,
					DistrictID = 842,
					Phone = "0414 318 10 10",
					Email = "asliyehukuk1@adalet.gov.tr",
					CourtType = "Asliye Hukuk Mahkemesi"
				},
				new Court
				{
					ID = 3,
					Name = "Şanlıurfa İş Mahkemesi",
					Address = "Şanlıurfa Adliyesi, Haliliye / Şanlıurfa",
					CityID = 63,
					DistrictID = 842,
					Phone = "0414 318 10 20",
					Email = "is@adalet.gov.tr",
					CourtType = "İş Mahkemesi"
				},
				new Court
				{
					ID = 4,
					Name = "Şanlıurfa Aile Mahkemesi",
					Address = "Şanlıurfa Adliyesi, Haliliye / Şanlıurfa",
					CityID = 63,
					DistrictID = 842,
					Phone = "0414 318 10 30",
					Email = "aile@adalet.gov.tr",
					CourtType = "Aile Mahkemesi"
				},
				new Court
				{
					ID = 5,
					Name = "Şanlıurfa Ağır Ceza Mahkemesi",
					Address = "Şanlıurfa Adliyesi, Haliliye / Şanlıurfa",
					CityID = 63,
					DistrictID = 842,
					Phone = "0414 318 10 40",
					Email = "agirceza@adalet.gov.tr",
					CourtType = "Ağır Ceza Mahkemesi"
				},
				new Court
				{
					ID = 6,
					Name = "Şanlıurfa 1. Sulh Hukuk Mahkemesi",
					Address = "Şanlıurfa Adliyesi, Haliliye / Şanlıurfa",
					CityID = 63,
					DistrictID = 842,
					Phone = "0414 318 10 50",
					Email = "sulhhukuk1@adalet.gov.tr",
					CourtType = "Sulh Hukuk Mahkemesi"
				},
				new Court
				{
					ID = 7,
					Name = "Şanlıurfa 2. İcra Dairesi",
					Address = "Şanlıurfa Adliyesi, Haliliye / Şanlıurfa",
					CityID = 63,
					DistrictID = 842,
					Phone = "0414 318 10 60",
					Email = "icra2@adalet.gov.tr",
					CourtType = "İcra Dairesi"
				},

				// --- İlçeler ---
				new Court
				{
					ID = 8,
					Name = "Akçakale Adliyesi",
					Address = "Yeni Mah. Adliye Cad. Akçakale / Şanlıurfa",
					CityID = 63,
					DistrictID = 836,
					Phone = "0414 411 20 00",
					Email = "akcakale@adalet.gov.tr",
					CourtType = "Adliye"
				},
				new Court
				{
					ID = 9,
					Name = "Birecik Adliyesi",
					Address = "Yeni Mah. Adliye Cad. Birecik / Şanlıurfa",
					CityID = 63,
					DistrictID = 837,
					Phone = "0414 652 10 00",
					Email = "birecik@adalet.gov.tr",
					CourtType = "Adliye"
				},
				new Court
				{
					ID = 10,
					Name = "Bozova Adliyesi",
					Address = "Yeni Mah. Adliye Cad. Bozova / Şanlıurfa",
					CityID = 63,
					DistrictID = 838,
					Phone = "0414 711 20 00",
					Email = "bozova@adalet.gov.tr",
					CourtType = "Adliye"
				},
				new Court
				{
					ID = 11,
					Name = "Ceylanpınar Adliyesi",
					Address = "Yenişehir Mah. Adliye Cad. Ceylanpınar / Şanlıurfa",
					CityID = 63,
					DistrictID = 839,
					Phone = "0414 471 10 00",
					Email = "ceylanpinar@adalet.gov.tr",
					CourtType = "Adliye"
				},
				new Court
				{
					ID = 12,
					Name = "Halfeti Adliyesi",
					Address = "Yeni Mah. Adliye Cad. Halfeti / Şanlıurfa",
					CityID = 63,
					DistrictID = 841,
					Phone = "0414 751 10 00",
					Email = "halfeti@adalet.gov.tr",
					CourtType = "Adliye"
				},
				new Court
				{
					ID = 13,
					Name = "Harran Adliyesi",
					Address = "Yeni Mah. Hükümet Cad. Harran / Şanlıurfa",
					CityID = 63,
					DistrictID = 843,
					Phone = "0414 471 20 00",
					Email = "harran@adalet.gov.tr",
					CourtType = "Adliye"
				},
				new Court
				{
					ID = 14,
					Name = "Hilvan Adliyesi",
					Address = "Yeni Mah. Adliye Cad. Hilvan / Şanlıurfa",
					CityID = 63,
					DistrictID = 844,
					Phone = "0414 471 30 00",
					Email = "hilvan@adalet.gov.tr",
					CourtType = "Adliye"
				},
				new Court
				{
					ID = 15,
					Name = "Siverek Adliyesi",
					Address = "Camikebir Mah. Hükümet Cad. Siverek / Şanlıurfa",
					CityID = 63,
					DistrictID = 846,
					Phone = "0414 552 10 00",
					Email = "siverek@adalet.gov.tr",
					CourtType = "Adliye"
				},
				new Court
				{
					ID = 16,
					Name = "Suruç Adliyesi",
					Address = "Yenişehir Mah. Adliye Cad. Suruç / Şanlıurfa",
					CityID = 63,
					DistrictID = 847,
					Phone = "0414 471 40 00",
					Email = "suruc@adalet.gov.tr",
					CourtType = "Adliye"
				},
				new Court
				{
					ID = 17,
					Name = "Viranşehir Adliyesi",
					Address = "Yenişehir Mah. Hükümet Cad. Viranşehir / Şanlıurfa",
					CityID = 63,
					DistrictID = 848,
					Phone = "0414 511 20 00",
					Email = "viransehir@adalet.gov.tr",
					CourtType = "Adliye"
				}
			);
		}
	}
}
