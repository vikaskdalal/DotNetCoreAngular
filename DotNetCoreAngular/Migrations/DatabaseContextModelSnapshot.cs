﻿// <auto-generated />
using System;
using DotNetCoreAngular.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNetCoreAngular.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DotNetCoreAngular.Models.Entity.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MessageSent")
                        .HasColumnType("datetime2");

                    b.Property<bool>("RecipientDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("RecipientId")
                        .HasColumnType("int");

                    b.Property<string>("RecipientUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SenderDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<string>("SenderUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages", "Message");
                });

            modelBuilder.Entity("DotNetCoreAngular.Models.Entity.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("PublicId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos", "User");
                });

            modelBuilder.Entity("DotNetCoreAngular.Models.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Gender")
                        .HasColumnType("smallint");

                    b.Property<string>("Interests")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Introduction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<string>("LookingFor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", "User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 7, 12, 18, 1, 56, 167, DateTimeKind.Local).AddTicks(1604),
                            DateOfBirth = new DateTime(2022, 7, 12, 18, 1, 56, 167, DateTimeKind.Local).AddTicks(1667),
                            Email = "vikaskdalal@gmail.com",
                            LastActive = new DateTime(2022, 7, 12, 18, 1, 56, 167, DateTimeKind.Local).AddTicks(1595),
                            Name = "Vikas",
                            PasswordHash = new byte[] { 130, 126, 133, 95, 48, 211, 30, 117, 127, 247, 84, 141, 179, 188, 15, 103, 164, 232, 184, 198, 141, 65, 49, 203, 175, 9, 157, 15, 154, 167, 82, 244, 173, 85, 114, 126, 56, 88, 15, 25, 70, 124, 94, 223, 114, 244, 129, 7, 31, 84, 223, 216, 173, 7, 226, 100, 71, 188, 152, 189, 192, 59, 110, 183 },
                            PasswordSalt = new byte[] { 40, 12, 199, 166, 85, 42, 193, 151, 54, 0, 159, 35, 58, 58, 162, 156, 3, 167, 55, 94, 121, 168, 175, 166, 220, 96, 231, 140, 84, 219, 82, 162, 229, 209, 53, 43, 208, 35, 202, 140, 75, 59, 148, 177, 63, 175, 53, 93, 110, 74, 86, 159, 199, 36, 240, 166, 0, 174, 180, 154, 145, 189, 236, 252, 15, 21, 170, 242, 7, 186, 141, 213, 125, 169, 31, 204, 87, 42, 98, 38, 230, 231, 85, 84, 169, 73, 48, 240, 223, 43, 108, 207, 250, 107, 65, 164, 212, 201, 114, 67, 24, 116, 244, 69, 12, 141, 20, 142, 27, 233, 147, 230, 125, 90, 163, 103, 94, 80, 141, 6, 241, 54, 124, 209, 4, 0, 29, 34 },
                            Username = "m+dhmpjucooq5clmqiqsfg=="
                        });
                });

            modelBuilder.Entity("DotNetCoreAngular.Models.Entity.UserLike", b =>
                {
                    b.Property<int>("SourceUserId")
                        .HasColumnType("int");

                    b.Property<int>("LikedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.HasKey("SourceUserId", "LikedUserId");

                    b.HasIndex("LikedUserId");

                    b.ToTable("UserLikes", "User");
                });

            modelBuilder.Entity("DotNetCoreAngular.Models.Entity.Message", b =>
                {
                    b.HasOne("DotNetCoreAngular.Models.Entity.User", "Recipient")
                        .WithMany("MessagesReceived")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DotNetCoreAngular.Models.Entity.User", "Sender")
                        .WithMany("MessagesSent")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("DotNetCoreAngular.Models.Entity.Photo", b =>
                {
                    b.HasOne("DotNetCoreAngular.Models.Entity.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DotNetCoreAngular.Models.Entity.UserLike", b =>
                {
                    b.HasOne("DotNetCoreAngular.Models.Entity.User", "LikedUser")
                        .WithMany("LikedByUsers")
                        .HasForeignKey("LikedUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DotNetCoreAngular.Models.Entity.User", "SourceUser")
                        .WithMany("LikedUsers")
                        .HasForeignKey("SourceUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("LikedUser");

                    b.Navigation("SourceUser");
                });

            modelBuilder.Entity("DotNetCoreAngular.Models.Entity.User", b =>
                {
                    b.Navigation("LikedByUsers");

                    b.Navigation("LikedUsers");

                    b.Navigation("MessagesReceived");

                    b.Navigation("MessagesSent");

                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
