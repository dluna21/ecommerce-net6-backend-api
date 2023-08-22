using CB.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CB.Persistencia.Configuraciones
{
    public partial class testMap : IEntityTypeConfiguration<testModel>
    {
        public void Configure(EntityTypeBuilder<testModel> builder)
        {
            builder.ToTable("test", "config");
            // key
            builder.HasKey(t => t.id);

            builder.Property(t => t.id) 
                .HasColumnName("id")
                .HasColumnType("int");

            builder.Property(t => t.nombre) 
                .HasColumnName("nombre")
                .HasColumnType("varchar")
                .HasMaxLength(20);

            builder.Property(t => t.fecha)
                .HasColumnName("fecha")
                .HasColumnType("timestamp");
        }
        public struct Table
        {
            public const string Schema = "config";
            public const string Name = "test";
        }

        public struct Columns
        {
            public const string id1 = "id";
            public const string nombre1 = "nombretest";
            public const string fecha1 = "fecha"; 
        }
    }
}
