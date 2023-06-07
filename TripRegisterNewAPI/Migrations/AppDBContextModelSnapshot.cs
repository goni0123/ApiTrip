﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TripRegisterNewAPI.Data;

#nullable disable

namespace TripRegisterNewAPI.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TripRegisterNewAPI.Models.Cost", b =>
                {
                    b.Property<int>("Nalog")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nalog"));

                    b.Property<int?>("Adblue_eu_1")
                        .HasColumnType("int");

                    b.Property<int?>("Adblue_eu_1_liter")
                        .HasColumnType("int");

                    b.Property<int?>("Adblue_eu_2")
                        .HasColumnType("int");

                    b.Property<int?>("Adblue_eu_2_liter")
                        .HasColumnType("int");

                    b.Property<int?>("Adblue_mk_1")
                        .HasColumnType("int");

                    b.Property<int?>("Adblue_mk_1_liter")
                        .HasColumnType("int");

                    b.Property<int?>("Adblue_mk_2")
                        .HasColumnType("int");

                    b.Property<int?>("Adblue_mk_2_liter")
                        .HasColumnType("int");

                    b.Property<int?>("All_Total")
                        .HasColumnType("int");

                    b.Property<int?>("Blank1_cost_1")
                        .HasColumnType("int");

                    b.Property<int?>("Blank1_cost_2")
                        .HasColumnType("int");

                    b.Property<string>("Blank1_name_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Blank1_name_2")
                        .HasColumnType("int");

                    b.Property<int?>("Blank2_cost_1")
                        .HasColumnType("int");

                    b.Property<int?>("Blank2_cost_2")
                        .HasColumnType("int");

                    b.Property<string>("Blank2_name_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Blank2_name_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Blank3_cost_1")
                        .HasColumnType("int");

                    b.Property<int?>("Blank3_cost_2")
                        .HasColumnType("int");

                    b.Property<string>("Blank3_name_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Blank3_name_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Blank4_cost_1")
                        .HasColumnType("int");

                    b.Property<int?>("Blank4_cost_2")
                        .HasColumnType("int");

                    b.Property<string>("Blank4_name_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Blank4_name_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Done")
                        .HasColumnType("bit");

                    b.Property<string>("Driver1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Driver2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Extra_Sh_1")
                        .HasColumnType("int");

                    b.Property<int?>("Extra_Sh_2")
                        .HasColumnType("int");

                    b.Property<int?>("M1_Shofer_1")
                        .HasColumnType("int");

                    b.Property<int?>("M1_Shofer_2")
                        .HasColumnType("int");

                    b.Property<int?>("M2_Shofer_1")
                        .HasColumnType("int");

                    b.Property<int?>("M2_Shofer_2")
                        .HasColumnType("int");

                    b.Property<int?>("Naft_eu_1")
                        .HasColumnType("int");

                    b.Property<int?>("Naft_eu_1_liter")
                        .HasColumnType("int");

                    b.Property<int?>("Naft_eu_2")
                        .HasColumnType("int");

                    b.Property<int?>("Naft_eu_2_liter")
                        .HasColumnType("int");

                    b.Property<int?>("Naft_mk_1")
                        .HasColumnType("int");

                    b.Property<int?>("Naft_mk_1_liter")
                        .HasColumnType("int");

                    b.Property<int?>("Naft_mk_2")
                        .HasColumnType("int");

                    b.Property<int?>("Naft_mk_2_liter")
                        .HasColumnType("int");

                    b.Property<int?>("Phyto_1")
                        .HasColumnType("int");

                    b.Property<int?>("Phyto_2")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_at_1")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_at_2")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_cro_1")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_cro_2")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_cz_1")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_cz_2")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_de_1")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_de_2")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_hu_1")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_hu_2")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_mk_1")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_mk_2")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_nl_1")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_nl_2")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_sk_1")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_sk_2")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_slo_1")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_slo_2")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_srb_1")
                        .HasColumnType("int");

                    b.Property<int?>("Putarina_srb_2")
                        .HasColumnType("int");

                    b.Property<int?>("Taks_srb_1")
                        .HasColumnType("int");

                    b.Property<int?>("Taks_srb_2")
                        .HasColumnType("int");

                    b.Property<int?>("Telephone_1")
                        .HasColumnType("int");

                    b.Property<int?>("Telephone_2")
                        .HasColumnType("int");

                    b.Property<int?>("Terminal_mk_1")
                        .HasColumnType("int");

                    b.Property<int?>("Terminal_mk_2")
                        .HasColumnType("int");

                    b.Property<int?>("Total_1")
                        .HasColumnType("int");

                    b.Property<int?>("Total_2")
                        .HasColumnType("int");

                    b.Property<string>("Truck")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nalog");

                    b.ToTable("costs");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Incoming", b =>
                {
                    b.Property<int>("Nalog_nr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nalog_nr"));

                    b.Property<bool?>("Check")
                        .HasColumnType("bit");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment_Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Driver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("End_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Extra_Cost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extra_Cost_Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Invoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Invoice_Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KM")
                        .HasColumnType("int");

                    b.Property<string>("RIT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Start_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Truck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Work_days")
                        .HasColumnType("int");

                    b.HasKey("Nalog_nr");

                    b.ToTable("incoming");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Inland_driving", b =>
                {
                    b.Property<int>("Nalog_nr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nalog_nr"));

                    b.Property<bool?>("Check")
                        .HasColumnType("bit");

                    b.Property<string>("Invoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Invoice_Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nalog_nr");

                    b.ToTable("inland_Driving");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Inland_driving_more", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("InlandNalog_nr")
                        .HasColumnType("int");

                    b.Property<int?>("KM")
                        .HasColumnType("int");

                    b.Property<string>("Trailor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Truck")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("InlandNalog_nr");

                    b.ToTable("inland_Driving_More");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Inland_week", b =>
                {
                    b.Property<int>("Nalog_nr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nalog_nr"));

                    b.Property<bool?>("Check")
                        .HasColumnType("bit");

                    b.Property<string>("Invoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Invoice_Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeeksID")
                        .HasColumnType("int");

                    b.HasKey("Nalog_nr");

                    b.HasIndex("WeeksID");

                    b.ToTable("inland_week");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Inland_week_more", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KM")
                        .HasColumnType("int");

                    b.Property<string>("Trailor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Truck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("inland_WeekNalog_nr")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("inland_WeekNalog_nr");

                    b.ToTable("inland_week_more");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.LastRoute", b =>
                {
                    b.Property<int>("Last_route")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Last_route"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Last_route");

                    b.ToTable("lastRoute");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.LoadingCompanyIn", b =>
                {
                    b.Property<int>("LCI")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LCI"));

                    b.Property<int?>("Colli")
                        .HasColumnType("int");

                    b.Property<string>("Document")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Export")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Importer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IncomingNalog_nr")
                        .HasColumnType("int");

                    b.Property<decimal?>("KG")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Transport_Invoice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LCI");

                    b.HasIndex("IncomingNalog_nr");

                    b.ToTable("loadingCompanyIn");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.LoadingCompanyOut", b =>
                {
                    b.Property<int>("LCO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LCO"));

                    b.Property<int?>("Colli")
                        .HasColumnType("int");

                    b.Property<string>("Document")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Export")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Importer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("KG")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OutgoingNalog_nr")
                        .HasColumnType("int");

                    b.Property<string>("Transport_Invoice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LCO");

                    b.HasIndex("OutgoingNalog_nr");

                    b.ToTable("loadingCompanyOut");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.LoadingOrderIn", b =>
                {
                    b.Property<int>("LoadingOrderNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoadingOrderNumber"));

                    b.Property<string>("AnAttn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ByOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Check")
                        .HasColumnType("bit");

                    b.Property<string>("Company1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateDocument")
                        .HasColumnType("datetime2");

                    b.Property<string>("DriverOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExporterOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreightPaidBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("FreightPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("GoodsOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImporterOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoadingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LoadingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Offload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Packing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("REFNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TruckPlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VonFrom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoadingOrderNumber");

                    b.ToTable("loadingOrderIn");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.LoadingOrderOut", b =>
                {
                    b.Property<int>("LoadingOrderNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoadingOrderNumber"));

                    b.Property<string>("AnAttn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ByOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Check")
                        .HasColumnType("bit");

                    b.Property<string>("Company1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateDocument")
                        .HasColumnType("datetime2");

                    b.Property<string>("DriverOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExporterOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FreightPaidBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("FreightPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("GoodsOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImporterOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoadingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LoadingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Offload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Packing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("REFNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TruckPlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VonFrom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoadingOrderNumber");

                    b.ToTable("loadingOrderOut");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Outgoing", b =>
                {
                    b.Property<int>("Nalog_nr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nalog_nr"));

                    b.Property<bool?>("Check")
                        .HasColumnType("bit");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment_Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Driver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("End_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Extra_Cost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extra_Cost_Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Invoice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Invoice_Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KM")
                        .HasColumnType("int");

                    b.Property<string>("RIT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Start_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Truck")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Work_days")
                        .HasColumnType("int");

                    b.HasKey("Nalog_nr");

                    b.ToTable("outgoing");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.RouteIn", b =>
                {
                    b.Property<int>("RI")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RI"));

                    b.Property<string>("City_in")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IncomingNalog_nr")
                        .HasColumnType("int");

                    b.Property<string>("Trailor_in")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RI");

                    b.HasIndex("IncomingNalog_nr");

                    b.ToTable("routeIn");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.RouteOut", b =>
                {
                    b.Property<int>("RO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RO"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OutgoingNalog_nr")
                        .HasColumnType("int");

                    b.Property<string>("Trailor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RO");

                    b.HasIndex("OutgoingNalog_nr");

                    b.ToTable("routeOut");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Trailor", b =>
                {
                    b.Property<string>("trailor")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("trailor");

                    b.ToTable("trailors");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Truck", b =>
                {
                    b.Property<string>("truck")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("truck");

                    b.ToTable("trucks");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Weeks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.HasKey("ID");

                    b.ToTable("weeks");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Inland_driving_more", b =>
                {
                    b.HasOne("TripRegisterNewAPI.Models.Inland_driving", "Inland")
                        .WithMany("inland_Driving_More")
                        .HasForeignKey("InlandNalog_nr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inland");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Inland_week", b =>
                {
                    b.HasOne("TripRegisterNewAPI.Models.Weeks", "Weeks")
                        .WithMany("Inland_week")
                        .HasForeignKey("WeeksID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Weeks");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Inland_week_more", b =>
                {
                    b.HasOne("TripRegisterNewAPI.Models.Inland_week", "inland_Week")
                        .WithMany("inland_Week_More")
                        .HasForeignKey("inland_WeekNalog_nr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("inland_Week");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.LoadingCompanyIn", b =>
                {
                    b.HasOne("TripRegisterNewAPI.Models.Incoming", "Incoming")
                        .WithMany("LoadingCompanyIn")
                        .HasForeignKey("IncomingNalog_nr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Incoming");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.LoadingCompanyOut", b =>
                {
                    b.HasOne("TripRegisterNewAPI.Models.Outgoing", "Outgoing")
                        .WithMany("loadingCompanyOut")
                        .HasForeignKey("OutgoingNalog_nr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Outgoing");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.RouteIn", b =>
                {
                    b.HasOne("TripRegisterNewAPI.Models.Incoming", "Incoming")
                        .WithMany("routeIn")
                        .HasForeignKey("IncomingNalog_nr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Incoming");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.RouteOut", b =>
                {
                    b.HasOne("TripRegisterNewAPI.Models.Outgoing", "Outgoing")
                        .WithMany("routeOut")
                        .HasForeignKey("OutgoingNalog_nr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Outgoing");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Incoming", b =>
                {
                    b.Navigation("LoadingCompanyIn");

                    b.Navigation("routeIn");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Inland_driving", b =>
                {
                    b.Navigation("inland_Driving_More");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Inland_week", b =>
                {
                    b.Navigation("inland_Week_More");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Outgoing", b =>
                {
                    b.Navigation("loadingCompanyOut");

                    b.Navigation("routeOut");
                });

            modelBuilder.Entity("TripRegisterNewAPI.Models.Weeks", b =>
                {
                    b.Navigation("Inland_week");
                });
#pragma warning restore 612, 618
        }
    }
}
