﻿// <auto-generated />
using System;
using Com.Danliris.Service.Sales.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Com.Danliris.Service.Sales.Lib.Migrations
{
    [DbContext(typeof(SalesDbContext))]
    [Migration("20180614100816_updateSpinningSalesContractModel")]
    partial class updateSpinningSalesContractModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Danliris.Service.Sales.Lib.Models.Spinning.SpinningSalesContractModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountBankCode")
                        .HasMaxLength(255);

                    b.Property<long>("AccountBankId");

                    b.Property<string>("AccountBankName")
                        .HasMaxLength(1000);

                    b.Property<string>("AccountBankNumber");

                    b.Property<string>("AccountCurrencyCode")
                        .HasMaxLength(255);

                    b.Property<string>("AccountCurrencyId")
                        .HasMaxLength(255);

                    b.Property<bool>("Active");

                    b.Property<string>("AgentCode")
                        .HasMaxLength(255);

                    b.Property<long>("AgentId");

                    b.Property<string>("AgentName")
                        .HasMaxLength(1000);

                    b.Property<int>("AutoIncrementNumber");

                    b.Property<string>("BankName")
                        .HasMaxLength(255);

                    b.Property<string>("BuyerCode")
                        .HasMaxLength(255);

                    b.Property<long>("BuyerId");

                    b.Property<string>("BuyerName")
                        .HasMaxLength(1000);

                    b.Property<string>("BuyerType")
                        .HasMaxLength(255);

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("Comission")
                        .HasMaxLength(1000);

                    b.Property<string>("ComodityCode")
                        .HasMaxLength(255);

                    b.Property<string>("ComodityDescription");

                    b.Property<long>("ComodityId");

                    b.Property<string>("ComodityName")
                        .HasMaxLength(1000);

                    b.Property<string>("ComodityType")
                        .HasMaxLength(255);

                    b.Property<string>("Condition")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("DeliveredTo")
                        .HasMaxLength(1000);

                    b.Property<DateTimeOffset>("DeliverySchedule");

                    b.Property<string>("DispositionNumber")
                        .HasMaxLength(255);

                    b.Property<bool>("FromStock");

                    b.Property<string>("IncomeTax")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("MaterialWidth")
                        .HasMaxLength(255);

                    b.Property<double>("OrderQuantity");

                    b.Property<string>("Packing")
                        .HasMaxLength(1000);

                    b.Property<string>("PieceLength")
                        .HasMaxLength(1000);

                    b.Property<double>("Price");

                    b.Property<string>("QualityCode")
                        .HasMaxLength(255);

                    b.Property<long>("QualityId");

                    b.Property<string>("QualityName")
                        .HasMaxLength(1000);

                    b.Property<string>("Remark");

                    b.Property<string>("SalesContractNo")
                        .HasMaxLength(255);

                    b.Property<string>("ShipmentDescription");

                    b.Property<double>("ShippingQuantityTolerance");

                    b.Property<string>("TermOfPaymentCode")
                        .HasMaxLength(255);

                    b.Property<long>("TermOfPaymentId");

                    b.Property<bool>("TermOfPaymentIsExport");

                    b.Property<string>("TermOfPaymentName")
                        .HasMaxLength(1000);

                    b.Property<string>("TermOfShipment")
                        .HasMaxLength(1000);

                    b.Property<string>("TransportFee")
                        .HasMaxLength(1000);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("SpinningSalesContract");
                });

            modelBuilder.Entity("Com.Danliris.Service.Sales.Lib.Models.Weaving.WeavingSalesContractModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountBankCode")
                        .HasMaxLength(255);

                    b.Property<long>("AccountBankId");

                    b.Property<string>("AccountBankName")
                        .HasMaxLength(1000);

                    b.Property<string>("AccountBankNumber");

                    b.Property<string>("AccountCurrencyCode")
                        .HasMaxLength(255);

                    b.Property<string>("AccountCurrencyId")
                        .HasMaxLength(255);

                    b.Property<bool>("Active");

                    b.Property<string>("AgentCode")
                        .HasMaxLength(255);

                    b.Property<long>("AgentId");

                    b.Property<string>("AgentName")
                        .HasMaxLength(1000);

                    b.Property<int>("AutoIncrementNumber");

                    b.Property<string>("BankName")
                        .HasMaxLength(255);

                    b.Property<string>("BuyerCode")
                        .HasMaxLength(255);

                    b.Property<long>("BuyerId");

                    b.Property<string>("BuyerName")
                        .HasMaxLength(1000);

                    b.Property<string>("BuyerType")
                        .HasMaxLength(255);

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("Comission")
                        .HasMaxLength(1000);

                    b.Property<string>("ComodityCode")
                        .HasMaxLength(255);

                    b.Property<string>("ComodityDescription");

                    b.Property<long>("ComodityId");

                    b.Property<string>("ComodityName")
                        .HasMaxLength(1000);

                    b.Property<string>("ComodityType")
                        .HasMaxLength(255);

                    b.Property<string>("Condition")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("DeliveredTo")
                        .HasMaxLength(1000);

                    b.Property<DateTimeOffset>("DeliverySchedule");

                    b.Property<string>("DispositionNumber")
                        .HasMaxLength(255);

                    b.Property<bool>("FromStock");

                    b.Property<string>("IncomeTax")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("MaterialConstructionCode")
                        .HasMaxLength(255);

                    b.Property<long>("MaterialConstructionId");

                    b.Property<string>("MaterialConstructionName")
                        .HasMaxLength(1000);

                    b.Property<string>("MaterialConstructionRemark");

                    b.Property<string>("MaterialWidth")
                        .HasMaxLength(255);

                    b.Property<double>("OrderQuantity");

                    b.Property<string>("Packing")
                        .HasMaxLength(1000);

                    b.Property<string>("PieceLength")
                        .HasMaxLength(1000);

                    b.Property<double>("Price");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(255);

                    b.Property<long>("ProductId");

                    b.Property<string>("ProductName")
                        .HasMaxLength(1000);

                    b.Property<double>("ProductPrice");

                    b.Property<string>("ProductTags")
                        .HasMaxLength(255);

                    b.Property<string>("QualityCode")
                        .HasMaxLength(255);

                    b.Property<long>("QualityId");

                    b.Property<string>("QualityName")
                        .HasMaxLength(1000);

                    b.Property<string>("Remark");

                    b.Property<string>("SalesContractNo")
                        .HasMaxLength(255);

                    b.Property<string>("ShipmentDescription");

                    b.Property<double>("ShippingQuantityTolerance");

                    b.Property<string>("TermOfPaymentCode")
                        .HasMaxLength(255);

                    b.Property<long>("TermOfPaymentId");

                    b.Property<bool>("TermOfPaymentIsExport");

                    b.Property<string>("TermOfPaymentName")
                        .HasMaxLength(1000);

                    b.Property<string>("TermOfShipment")
                        .HasMaxLength(1000);

                    b.Property<string>("TransportFee")
                        .HasMaxLength(1000);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<long>("UomId");

                    b.Property<string>("UomUnit")
                        .HasMaxLength(255);

                    b.Property<string>("YarnMaterialCode")
                        .HasMaxLength(255);

                    b.Property<long>("YarnMaterialId");

                    b.Property<string>("YarnMaterialName")
                        .HasMaxLength(1000);

                    b.Property<string>("YarnMaterialRemark");

                    b.HasKey("Id");

                    b.ToTable("WeavingSalesContract");
                });
#pragma warning restore 612, 618
        }
    }
}
