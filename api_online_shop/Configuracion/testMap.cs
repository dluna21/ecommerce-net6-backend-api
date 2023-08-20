using CB.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_online_shop.Configuracion
{
    public class testMap : IEntityTypeConfiguration<testModel>
    {
        void IEntityTypeConfiguration<testModel>.Configure(EntityTypeBuilder<testModel> builder)
        {
            builder.ToTable("test", "config");
            // key
            builder.HasKey(t => t.id1);

            builder.Property(t => t.id1) 
                .HasColumnName("id")
                .HasColumnType("int");

            builder.Property(t => t.nombre1) 
                .HasColumnName("nombre")
                .HasColumnType("varchar")
                .HasMaxLength(20);

            builder.Property(t => t.fecha1)
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
