// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAVN.Service.CurrencyConverter.MsSqlRepositories.Migrations
{
    [DbContext(typeof(CurrencyContext))]
    [Migration("20190917082100_GlobalCurrencyRate")]
    partial class GlobalCurrencyRate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("currency")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Service.CurrencyConvertor.MsSqlRepositories.Entities.CurrencyEntity", b =>
                {
                    b.Property<string>("CurrencyCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("currency_code")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("CurrencyLabel")
                        .HasColumnName("currency_label");

                    b.Property<decimal>("CurrencyRate")
                        .HasColumnName("currency_rate");

                    b.HasKey("CurrencyCode");

                    b.ToTable("currency");
                });

            modelBuilder.Entity("Lykke.Service.CurrencyConvertor.MsSqlRepositories.Entities.CurrencyRateEntity", b =>
                {
                    b.Property<string>("BaseAsset")
                        .HasColumnName("base_asset");

                    b.Property<string>("QuoteAsset")
                        .HasColumnName("quote_asset");

                    b.Property<decimal>("Rate")
                        .HasColumnName("rate");

                    b.HasKey("BaseAsset", "QuoteAsset");

                    b.ToTable("currency_rates");
                });

            modelBuilder.Entity("Lykke.Service.CurrencyConvertor.MsSqlRepositories.Entities.GlobalCurrencyRateEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<decimal>("AmountInCurrency")
                        .HasColumnName("amount_in_currency");

                    b.Property<long>("AmountInTokens")
                        .HasColumnName("amount_in_tokens");

                    b.HasKey("Id");

                    b.ToTable("global_currency_rates");
                });
#pragma warning restore 612, 618
        }
    }
}
