namespace DesignPattern.Creational.Builder.Faceted;
internal class CarFeatures
{
    internal bool NavigationSystem { private get; set; }
    internal bool BluetoothSystem { private get; set; }

    public override string ToString()
    {
        return $" {nameof(NavigationSystem)}: {NavigationSystem}\n {nameof(BluetoothSystem)}: {BluetoothSystem}";
    }
}