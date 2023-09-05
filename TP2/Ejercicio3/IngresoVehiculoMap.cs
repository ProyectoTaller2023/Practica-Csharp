using Ejercicio3;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class IngresoVehiculoConfiguration : IEntityTypeConfiguration<IngresoVehiculo>
{
    public void Configure(EntityTypeBuilder<IngresoVehiculo> builder)
    {
        builder.ToTable("Ingresos");
        builder.HasKey(ingreso => ingreso.id);
        builder.Property(ingreso => ingreso.id).HasColumnName("Id");
        builder.Property(ingreso => ingreso.Patente).HasColumnName("Patente");
        builder.Property(ingreso => ingreso.FechaIngreso).HasColumnName("FechaIngreso");
        builder.Property(ingreso => ingreso.FechaEgreso).HasColumnName("FechaEgreso");
        builder.Property(ingreso => ingreso.LugarAsignado).HasColumnName("LugarAsignado");
    }
}
