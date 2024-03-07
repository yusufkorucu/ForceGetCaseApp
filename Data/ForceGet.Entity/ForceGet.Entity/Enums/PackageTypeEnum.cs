using System.ComponentModel;

namespace ForceGet.Entity.Enums
{
    public enum PackageTypeEnum
    {
        [Description("Pallets")]
        Pallets = 0,
        [Description("Boxes")]
        Boxes = 1,
        [Description("Cartons")]
        Cartons = 2
    }
}
