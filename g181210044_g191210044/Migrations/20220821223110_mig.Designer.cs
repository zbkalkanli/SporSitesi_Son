﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using g181210044_g191210044.Data;

#nullable disable

namespace g181210044_g191210044.Migrations
{
    [DbContext(typeof(SporContext))]
    [Migration("20220821223110_mig")]
    partial class mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("g181210044_g191210044.Entity.BlogYazisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasMaxLength(7500)
                        .HasColumnType("TEXT");

                    b.Property<int>("BegeniSayisi")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogYazariId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("YayinTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("YazarId")
                        .HasMaxLength(500)
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BlogYazariId");

                    b.ToTable("BlogYazisi");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.Sepet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UrunId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Sepet");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("BegeniSayisi")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fiyat")
                        .HasMaxLength(250)
                        .HasColumnType("INTEGER");

                    b.Property<string>("ResimUrl")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("TEXT");

                    b.Property<int?>("SepetId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StokSayisi")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SepetId");

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.Uye", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Adres")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BegenilenUrunId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HesapNumarasi")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Il")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("Ilce")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("KatilimTarihi")
                        .HasColumnType("TEXT");

                    b.Property<string>("MailAdresi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("SepetId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SepetId");

                    b.ToTable("Uye");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Uye");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.Yorum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogYazisiId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UrunId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UyeId")
                        .HasMaxLength(3000)
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BlogYazisiId");

                    b.HasIndex("UrunId");

                    b.HasIndex("UyeId");

                    b.ToTable("Yorum");
                });

            modelBuilder.Entity("UrunUye", b =>
                {
                    b.Property<int>("BegenenUyelerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BegenilenUrunlerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BegenenUyelerId", "BegenilenUrunlerId");

                    b.HasIndex("BegenilenUrunlerId");

                    b.ToTable("UrunUye");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.Admin", b =>
                {
                    b.HasBaseType("g181210044_g191210044.Entity.Uye");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.BlogYazari", b =>
                {
                    b.HasBaseType("g181210044_g191210044.Entity.Uye");

                    b.HasDiscriminator().HasValue("BlogYazari");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.BlogYazisi", b =>
                {
                    b.HasOne("g181210044_g191210044.Entity.BlogYazari", "BlogYazari")
                        .WithMany("Yazilari")
                        .HasForeignKey("BlogYazariId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogYazari");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.Urun", b =>
                {
                    b.HasOne("g181210044_g191210044.Entity.Sepet", null)
                        .WithMany("Urunler")
                        .HasForeignKey("SepetId");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.Uye", b =>
                {
                    b.HasOne("g181210044_g191210044.Entity.Sepet", "Sepet")
                        .WithMany()
                        .HasForeignKey("SepetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sepet");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.Yorum", b =>
                {
                    b.HasOne("g181210044_g191210044.Entity.BlogYazisi", "BlogYazisi")
                        .WithMany("Yorumlar")
                        .HasForeignKey("BlogYazisiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("g181210044_g191210044.Entity.Urun", "Urun")
                        .WithMany("Yorumlar")
                        .HasForeignKey("UrunId");

                    b.HasOne("g181210044_g191210044.Entity.Uye", "Uye")
                        .WithMany("YaptigiYorumlar")
                        .HasForeignKey("UyeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogYazisi");

                    b.Navigation("Urun");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("UrunUye", b =>
                {
                    b.HasOne("g181210044_g191210044.Entity.Uye", null)
                        .WithMany()
                        .HasForeignKey("BegenenUyelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("g181210044_g191210044.Entity.Urun", null)
                        .WithMany()
                        .HasForeignKey("BegenilenUrunlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.BlogYazisi", b =>
                {
                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.Sepet", b =>
                {
                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.Urun", b =>
                {
                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.Uye", b =>
                {
                    b.Navigation("YaptigiYorumlar");
                });

            modelBuilder.Entity("g181210044_g191210044.Entity.BlogYazari", b =>
                {
                    b.Navigation("Yazilari");
                });
#pragma warning restore 612, 618
        }
    }
}