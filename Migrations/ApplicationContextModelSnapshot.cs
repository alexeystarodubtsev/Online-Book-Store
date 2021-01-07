﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_book_store.Models;

namespace Onlinebookstore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Online_book_store.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("MiddleName");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Online_book_store.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutorID");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("Price");

                    b.Property<int>("PriceAudio");

                    b.Property<int>("PriceElectronic");

                    b.Property<int>("PublisherID");

                    b.Property<int>("Qty");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("Year");

                    b.HasKey("ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Online_book_store.Models.Book_Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookID");

                    b.Property<int>("PublisherID");

                    b.HasKey("Id");

                    b.ToTable("Book_Publishers");
                });

            modelBuilder.Entity("Online_book_store.Models.BookType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("Online_book_store.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("Cost");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired();

                    b.Property<string>("CustomerLastName")
                        .IsRequired();

                    b.Property<int>("DateOfDeliver");

                    b.Property<int>("DateOfOrder");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("OrderStatusID");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Online_book_store.Models.OrderDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookID");

                    b.Property<int>("BookTypeID");

                    b.Property<int>("Cost");

                    b.Property<int>("OrderID");

                    b.Property<int>("Qty");

                    b.HasKey("ID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Online_book_store.Models.OrderStatus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("Online_book_store.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });
#pragma warning restore 612, 618
        }
    }
}
