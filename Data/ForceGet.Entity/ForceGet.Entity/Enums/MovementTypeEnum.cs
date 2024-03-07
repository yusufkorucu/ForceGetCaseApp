using System.ComponentModel;

namespace ForceGet.Entity.Enums
{
    public enum MovementTypeEnum
    {
        [Description("Door to Door")]
        DoorToDoor = 0,

        [Description("Port to Door")]

        PortToDoor = 1,
        [Description("Door to Port")]

        DoorToPort = 2,
        [Description("Port to Port")]

        PortToPort = 3
    }
}
