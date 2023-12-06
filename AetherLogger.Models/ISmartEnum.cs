namespace AetherLogger.Models;

public interface ISmartEnum : Ardalis.SmartEnum.ISmartEnum
{
    // Ardalis.SmartEnum.ISmartEnum is defined empty,
    // but it should have a Name and Value property.
    string Name { get; }
    int Value { get; }
}
