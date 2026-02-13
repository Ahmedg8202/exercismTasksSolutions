class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    private int distanceDriven = 0;
    private int batteryPercentage = 100;
    public RemoteControlCar(int speed, int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
    public bool BatteryDrained()
    {
       return batteryPercentage < batteryDrain;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceDriven += speed;
            batteryPercentage -= batteryDrain;
        }    
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance;
    public RaceTrack(int distance){
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        double drivesNeeded = Math.Ceiling(distance *1.0 / car.speed);
        return (drivesNeeded * car.batteryDrain) <= 100;
    }
    //dis / speed = x
    //x * drain <= 100
    // 14 >> 100
}
