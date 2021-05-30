﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SongTracker.Models;

namespace ProjectName.Migrations
{
    [DbContext(typeof(SongTrackerContext))]
    [Migration("20210530230843_RedoMigrationsAttempt")]
    partial class RedoMigrationsAttempt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SongTracker.Models.Instrument", b =>
                {
                    b.Property<int>("InstrumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("InstrumentId");

                    b.ToTable("Instruments");
                });

            modelBuilder.Entity("SongTracker.Models.InstrumentSong", b =>
                {
                    b.Property<int>("InstrumentSongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("InstrumentId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("InstrumentSongId");

                    b.HasIndex("InstrumentId");

                    b.HasIndex("SongId");

                    b.ToTable("InstrumentSong");
                });

            modelBuilder.Entity("SongTracker.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Artist")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Chords")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SongId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("SongTracker.Models.InstrumentSong", b =>
                {
                    b.HasOne("SongTracker.Models.Instrument", "Instrument")
                        .WithMany("JoinEntities")
                        .HasForeignKey("InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SongTracker.Models.Song", "Song")
                        .WithMany("JoinEntities")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instrument");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("SongTracker.Models.Instrument", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("SongTracker.Models.Song", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
