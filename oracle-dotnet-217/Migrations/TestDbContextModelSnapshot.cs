// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using oracle_dotnet_217;

namespace oracle_dotnet_217.Migrations
{
    [DbContext(typeof(TestDbContext))]
    partial class TestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("TESTSCHEMA")
                .HasAnnotation("Relational:MaxIdentifierLength", 30)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("oracle_dotnet_217.Test", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)")
                        .HasAnnotation("Oracle:IdentityIncrement", 1)
                        .HasAnnotation("Oracle:IdentitySeed", 1)
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("TEST");
                });
#pragma warning restore 612, 618
        }
    }
}
