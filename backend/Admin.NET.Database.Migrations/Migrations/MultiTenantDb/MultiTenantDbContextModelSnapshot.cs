﻿// <auto-generated />
using System;
using Admin.NET.EntityFramework.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Admin.NET.Database.Migrations.Migrations.MultiTenantDb
{
    [DbContext(typeof(MultiTenantDbContext))]
    partial class MultiTenantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("Admin.NET.Application.Entity.Delivery", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("INTEGER")
                        .HasComment("Id主键");

                    b.Property<DateTimeOffset?>("CreatedTime")
                        .HasColumnType("TEXT")
                        .HasComment("创建时间");

                    b.Property<long?>("CreatedUserId")
                        .HasColumnType("INTEGER")
                        .HasComment("创建者Id");

                    b.Property<string>("CreatedUserName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasComment("创建者名称");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER")
                        .HasComment("软删除标记");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasComment("下拉选择器");

                    b.Property<DateTimeOffset?>("UpdatedTime")
                        .HasColumnType("TEXT")
                        .HasComment("更新时间");

                    b.Property<long?>("UpdatedUserId")
                        .HasColumnType("INTEGER")
                        .HasComment("修改者Id");

                    b.Property<string>("UpdatedUserName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasComment("修改者名称");

                    b.HasKey("Id");

                    b.ToTable("Delivery");

                    b.HasComment(" 交付管理");
                });

            modelBuilder.Entity("Admin.NET.Core.SysTenant", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("INTEGER")
                        .HasComment("Id主键");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasComment("管理员名称");

                    b.Property<string>("Connection")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT")
                        .HasComment("数据库连接");

                    b.Property<DateTimeOffset?>("CreatedTime")
                        .HasColumnType("TEXT")
                        .HasComment("创建时间");

                    b.Property<long?>("CreatedUserId")
                        .HasColumnType("INTEGER")
                        .HasComment("创建者Id");

                    b.Property<string>("CreatedUserName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasComment("创建者名称");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasComment("电子邮箱");

                    b.Property<string>("Host")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasComment("主机");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER")
                        .HasComment("软删除标记");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT")
                        .HasComment("公司名称");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasComment("电话");

                    b.Property<string>("Remark")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasComment("备注");

                    b.Property<string>("Schema")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasComment("架构");

                    b.Property<DateTimeOffset?>("UpdatedTime")
                        .HasColumnType("TEXT")
                        .HasComment("更新时间");

                    b.Property<long?>("UpdatedUserId")
                        .HasColumnType("INTEGER")
                        .HasComment("修改者Id");

                    b.Property<string>("UpdatedUserName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasComment("修改者名称");

                    b.HasKey("Id");

                    b.ToTable("sys_tenant");

                    b.HasComment("租户表");

                    b.HasData(
                        new
                        {
                            Id = 142307070918780L,
                            AdminName = "SuperAdmin",
                            Connection = "",
                            CreatedTime = new DateTimeOffset(new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            Email = "515096995@163.com",
                            Host = "",
                            IsDeleted = false,
                            Name = "平台开发",
                            Phone = "18020030720"
                        },
                        new
                        {
                            Id = 142307070918781L,
                            AdminName = "Admin",
                            Connection = "",
                            CreatedTime = new DateTimeOffset(new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)),
                            Email = "zuohuaijun@163.com",
                            Host = "",
                            IsDeleted = false,
                            Name = "公司1租户",
                            Phone = "18020030720"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
