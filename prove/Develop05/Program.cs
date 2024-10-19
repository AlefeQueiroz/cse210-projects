using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();

        // Run the activities
        breathingActivity.Run();
        listingActivity.Run();
        reflectingActivity.Run();
    }
}
