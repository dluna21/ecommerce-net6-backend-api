using CB.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CB.Persistencia.Configuraciones
{
    public class OnlineShopMap : IEntityTypeConfiguration<OnlineShop>
    {
        public void Configure(EntityTypeBuilder<OnlineShop> builder)
        { 
            #region Generated Configure
            // table
            builder.ToTable("online_shop", "config");

            // key
            builder.HasKey(t => t.OnlineShopId);

            // properties
            builder.Property(t => t.OnlineShopId)
                .IsRequired()
                .HasColumnName("I_ONLINE_SHOP_ID")
                .HasColumnType("int");

            builder.Property(t => t.Anio)
                .IsRequired()
                .HasColumnName("I_ANIO")
                .HasColumnType("int");

            builder.Property(t => t.Periodo)
                .IsRequired()
                .HasColumnName("I_PERIODO")
                .HasColumnType("int");

            builder.Property(t => t.Nombre)
                .IsRequired()
                .HasColumnName("V_NOMBRE")
                .HasColumnType("varchar")
                .HasMaxLength(200);

            builder.Property(t => t.BasesDocumentacion)
                .IsRequired()
                .HasColumnName("V_BASES_DOCUMENTACION")
                .HasColumnType("varchar");

            builder.Property(t => t.BasesPublicacion)
                .IsRequired()
                .HasColumnName("D_BASES_PUBLICACION")
                .HasColumnType("timestamp");

            builder.Property(t => t.Registro)
                .IsRequired()
                .HasColumnName("D_REGISTRO")
                .HasColumnType("timestamp");

            builder.Property(t => t.UsuarioRegistro)
                .IsRequired()
                .HasColumnName("V_USR_REGISTRO")
                .HasColumnType("varchar")
                .HasMaxLength(20);

            builder.Property(t => t.Modificacion)
                .HasColumnName("D_MODIFICACION")
                .HasColumnType("timestamp");

            builder.Property(t => t.UsuarioModificacion)
                .HasColumnName("V_USR_MODIFICACION")
                .HasColumnType("varchar")
                .HasMaxLength(20);

            // relationships
            #endregion
        } 
    }
}
