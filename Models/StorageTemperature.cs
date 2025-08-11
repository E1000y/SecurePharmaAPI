namespace SecurePharmaAPI.Models
{
    public enum StorageTemperature
    {
        RoomTemperature, // 15-25°C
        Refrigerated,    // 2-8°C
        Frozen,          // Below -18°C
        ControlledRoomTemperature // 20-25°C with specific humidity and light conditions
    }
}
