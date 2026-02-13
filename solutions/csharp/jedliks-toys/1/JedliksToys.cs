class RemoteControlCar
{
    private int distance = 0;
    private int batteryPercentage = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        if(batteryPercentage > 0)
            return $"Battery at {batteryPercentage}%";
        else
            return "Battery empty";
    }

    public void Drive()
    {
        if(batteryPercentage > 0)
        {
            distance +=20;
            batteryPercentage -=1;
        }
    }
}
