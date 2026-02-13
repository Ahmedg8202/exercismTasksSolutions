using System.Linq;
class BirdCount
{
    private int[] birdsPerDay;
    
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
       return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay.Last();
    }

    public void IncrementTodaysCount()
    {
       int lastIndex = birdsPerDay.Length - 1;
        birdsPerDay[lastIndex] = birdsPerDay[lastIndex] + 1;
    }

    public bool HasDayWithoutBirds()
    {
        if(birdsPerDay.Contains(0))
            return true;
        else
            return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int totalBirds = 0;
        for(int i = 0; i < numberOfDays && i < birdsPerDay.Length; i++){
            totalBirds += birdsPerDay[i];
        }
        return totalBirds;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        for(int i = 0; i < birdsPerDay.Length; i++){
            if(birdsPerDay[i] > 4)
                busyDays += 1;
        }
        return busyDays;    
    }
}
