// <auto-generated />
using System;
using Books.Api.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Books.Api.Migrations
{
    [DbContext(typeof(BooksContext))]
    [Migration("20221006094507_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Books.Api.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            CreatedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(672),
                            FirstName = "George",
                            IsArchived = false,
                            LastModifiedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(672),
                            LastName = "RR Martin"
                        },
                        new
                        {
                            Id = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            CreatedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(679),
                            FirstName = "Stephen",
                            IsArchived = false,
                            LastModifiedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(679),
                            LastName = "Fry"
                        },
                        new
                        {
                            Id = new Guid("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"),
                            CreatedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(682),
                            FirstName = "James",
                            IsArchived = false,
                            LastModifiedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(682),
                            LastName = "Elroy"
                        },
                        new
                        {
                            Id = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            CreatedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(682),
                            FirstName = "Douglas",
                            IsArchived = false,
                            LastModifiedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(682),
                            LastName = "Adams"
                        });
                });

            modelBuilder.Entity("Books.Api.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("varchar(2500)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                            AuthorId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            CreatedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(739),
                            Description = "The book that seems impossible to write.",
                            IsArchived = false,
                            LastModifiedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(739),
                            Title = "The Winds of Winter"
                        },
                        new
                        {
                            Id = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            AuthorId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            CreatedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(741),
                            Description = "A Game of Thrones is the first novel in A Song of Ice and Fire, a series of fantasy novels by American author George R. R. ... In the novel, recounting events from various points of view, Martin introduces the plot-lines of the noble houses of Westeros, the Wall, and the Targaryens.",
                            IsArchived = false,
                            LastModifiedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(741),
                            Title = "A Game of Thrones"
                        },
                        new
                        {
                            Id = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            AuthorId = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            CreatedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(742),
                            Description = "The Greek myths are amongst the best stories ever told, passed down through millennia and inspiring writers and artists as varied as Shakespeare, Michelangelo, James Joyce and Walt Disney.  They are embedded deeply in the traditions, tales and cultural DNA of the West.You'll fall in love with Zeus, marvel at the birth of Athena, wince at Cronus and Gaia's revenge on Ouranos, weep with King Midas and hunt with the beautiful and ferocious Artemis. Spellbinding, informative and moving, Stephen Fry's Mythos perfectly captures these stories for the modern age - in all their rich and deeply human relevance.",
                            IsArchived = false,
                            LastModifiedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(742),
                            Title = "Mythos"
                        },
                        new
                        {
                            Id = new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                            AuthorId = new Guid("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"),
                            CreatedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(743),
                            Description = "American Tabloid is a 1995 novel by James Ellroy that chronicles the events surrounding three rogue American law enforcement officers from November 22, 1958 through November 22, 1963. Each becomes entangled in a web of interconnecting associations between the FBI, the CIA, and the mafia, which eventually leads to their collective involvement in the John F. Kennedy assassination.",
                            IsArchived = false,
                            LastModifiedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(743),
                            Title = "American Tabloid"
                        },
                        new
                        {
                            Id = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                            AuthorId = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            CreatedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(745),
                            Description = "In The Hitchhiker's Guide to the Galaxy, the characters visit the legendary planet Magrathea, home to the now-collapsed planet-building industry, and meet Slartibartfast, a planetary coastline designer who was responsible for the fjords of Norway. Through archival recordings, he relates the story of a race of hyper-intelligent pan-dimensional beings who built a computer named Deep Thought to calculate the Answer to the Ultimate Question of Life, the Universe, and Everything.",
                            IsArchived = false,
                            LastModifiedAt = new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(745),
                            Title = "The Hitchhiker's Guide to the Galaxy"
                        });
                });

            modelBuilder.Entity("Books.Api.Entities.Book", b =>
                {
                    b.HasOne("Books.Api.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
