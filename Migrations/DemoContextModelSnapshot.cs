﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebDemo.Models;

namespace WebDemo.Migrations
{
    [DbContext(typeof(DemoContext))]
    partial class DemoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("WebDemo.Models.QuizModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Answer1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Answer2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Answer3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Answer4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice1_1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice1_2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice1_3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice1_4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice2_1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice2_2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice2_3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice2_4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice3_1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice3_2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice3_3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice3_4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice4_1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice4_2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice4_3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Choice4_4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Question2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Question3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Question4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Quiz");
                });

            modelBuilder.Entity("WebDemo.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Sign_status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
