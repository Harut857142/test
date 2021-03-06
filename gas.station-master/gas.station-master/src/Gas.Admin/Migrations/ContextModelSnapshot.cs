// <auto-generated />
using System;
using Gas.Shared.DbProvider;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gas.Admin.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Gas.Shared.Models.Core.Device.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DeviceName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Key")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("UserId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Gas.Shared.Models.Core.DeviceConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<float?>("dpdrac")
                        .HasColumnType("float");

                    b.Property<float?>("dpgorcakic")
                        .HasColumnType("float");

                    b.Property<float?>("dpgorcakicset")
                        .HasColumnType("float");

                    b.Property<float?>("dppastaci")
                        .HasColumnType("float");

                    b.Property<bool?>("flowAutoOnoff")
                        .HasColumnType("tinyint(1)");

                    b.Property<float?>("flowauto")
                        .HasColumnType("float");

                    b.Property<float?>("flowhanac")
                        .HasColumnType("float");

                    b.Property<float?>("flowhanacset")
                        .HasColumnType("float");

                    b.Property<float?>("flowmax")
                        .HasColumnType("float");

                    b.Property<float?>("flowmaxset")
                        .HasColumnType("float");

                    b.Property<float?>("flowpast")
                        .HasColumnType("float");

                    b.Property<float?>("flowproc")
                        .HasColumnType("float");

                    b.Property<float?>("flowprocset")
                        .HasColumnType("float");

                    b.Property<float?>("flowsarqac")
                        .HasColumnType("float");

                    b.Property<float?>("kgorcakic")
                        .HasColumnType("float");

                    b.Property<float?>("kgorcakicset")
                        .HasColumnType("float");

                    b.Property<bool?>("onoff")
                        .HasColumnType("tinyint(1)");

                    b.Property<float?>("pressgorcakic")
                        .HasColumnType("float");

                    b.Property<float?>("pressgorcakicset")
                        .HasColumnType("float");

                    b.Property<float?>("presspastaci")
                        .HasColumnType("float");

                    b.Property<float?>("selfonoff")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId")
                        .IsUnique();

                    b.ToTable("DeviceConfig");
                });

            modelBuilder.Entity("Gas.Shared.Models.Core.File", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FileName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Path")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Gas.Shared.Models.Core.Permission.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ModuleName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ModuleNumber")
                        .HasColumnType("int");

                    b.Property<string>("PermissionName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PermissionNumber")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Gas.Shared.Models.Core.Permission.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SystemName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("SystemRole")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Gas.Shared.Models.Core.Permission.RolePermission", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ID");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("Gas.Shared.Models.Core.Permission.UserRole", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Gas.Shared.Models.Core.User.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Salt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("UserState")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Gas.Shared.Models.Core.Device.Device", b =>
                {
                    b.HasOne("Gas.Shared.Models.Core.Device.Device", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Gas.Shared.Models.Core.User.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Gas.Shared.Models.Core.DeviceConfig", b =>
                {
                    b.HasOne("Gas.Shared.Models.Core.Device.Device", "Device")
                        .WithOne("DeviceConfig")
                        .HasForeignKey("Gas.Shared.Models.Core.DeviceConfig", "DeviceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Gas.Shared.Models.Core.Permission.RolePermission", b =>
                {
                    b.HasOne("Gas.Shared.Models.Core.Permission.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Gas.Shared.Models.Core.Permission.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Gas.Shared.Models.Core.Permission.UserRole", b =>
                {
                    b.HasOne("Gas.Shared.Models.Core.Permission.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Gas.Shared.Models.Core.User.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
