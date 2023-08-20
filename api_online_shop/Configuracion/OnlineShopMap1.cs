using CB.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_online_shop.Configuracion
{
    public class OnlineShopMap1 : IEntityTypeConfiguration<OnlineShop>
    {
        void IEntityTypeConfiguration<OnlineShop>.Configure(EntityTypeBuilder<OnlineShop> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("online_shop", "config");

            // key
            builder.HasKey(t => t.OnlineShopId);

            // properties
            builder.Property(t => t.OnlineShopId) 
                .HasColumnName("I_ONLINE_SHOP_ID".ToLower())
                .HasColumnType("int");

            builder.Property(t => t.Anio) 
                .HasColumnName("I_ANIO".ToLower())
                .HasColumnType("int");

            builder.Property(t => t.Periodo) 
                .HasColumnName("I_PERIODO".ToLower())
                .HasColumnType("int");

            builder.Property(t => t.Nombre) 
                .HasColumnName("V_NOMBRE".ToLower())
                .HasColumnType("varchar")
                .HasMaxLength(300);

            builder.Property(t => t.BasesDocumentacion) 
                .HasColumnName("V_BASES_DOCUMENTACION".ToLower())
                .HasColumnType("varchar");

            builder.Property(t => t.BasesPublicacion) 
                .HasColumnName("D_BASES_PUBLICACION".ToLower())
                .HasColumnType("timestamp");

            builder.Property(t => t.Registro)
                
                .HasColumnName("D_REGISTRO".ToLower())
                .HasColumnType("timestamp");

            builder.Property(t => t.UsuarioRegistro)
                 
                .HasColumnName("V_USR_REGISTRO".ToLower())
                .HasColumnType("varchar")
                .HasMaxLength(20);

            builder.Property(t => t.Modificacion)
                .HasColumnName("D_MODIFICACION".ToLower())
                .HasColumnType("timestamp");

            builder.Property(t => t.UsuarioModificacion)
                .HasColumnName("V_USR_MODIFICACION".ToLower())
                .HasColumnType("varchar")
                .HasMaxLength(20);

            // relationships
            #endregion
        }
        public struct Table
        {
            public const string Schema = "config";
            public const string Name = "online_shop";
        }

        public struct Columns
        {
            public const string OnlineShopId = "I_ONLINE_SHOP_ID";
            public const string Anio = "i_anio";
            public const string Periodo = "I_PERIODO";
            public const string Nombre = "V_NOMBRE";
            public const string BasesDocumentacion = "V_BASES_DOCUMENTACION";
            public const string BasesPublicacion = "D_BASES_PUBLICACION";
            public const string Registro = "D_REGISTRO";
            public const string UsuarioRegistro = "V_USR_REGISTRO";
            public const string Modificacion = "D_MODIFICACION";
            public const string UsuarioModificacion = "V_USR_MODIFICACION";
        }

    }
}
