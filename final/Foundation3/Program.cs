using System;


class Program
{
    static void Main(string[] args)
    {
        // Create the address for Mexico City
        Address mexicoCityAddress = new Address("890 Insurgentes Avenue South", "Mexico City", "CDMX", "Mexico");

        // Create the address for the Church of Jesus Christ of Latter-day Saints
        Address ldsChurchAddress = new Address("200 Ejército Nacional Avenue", "Mexico City", "CDMX", "Mexico");

        // Create the events using the corresponding addresses
        Lectures mexicoCityLectureEvent = new Lectures("Conference in Mexico City", "Conference on various topics", "2024-03-01", "10:00 AM", mexicoCityAddress, "Maria Garcia", 150);
        Receptions ldsChurchReceptionEvent = new Receptions("Meeting at the Church", "Congregation meeting", "2024-03-02", "7:00 PM", ldsChurchAddress, "info@lds.org");
        OutdoorGatherings mexicoCityOutdoorEvent = new OutdoorGatherings("Picnic in the Park", "Community outdoor picnic", "2024-03-03", "12:00 PM", mexicoCityAddress, "Sunny");


        Console.WriteLine("\nLecture Event:");
        Console.WriteLine(mexicoCityLectureEvent.GetStandardDetails());
        Console.WriteLine(mexicoCityLectureEvent.GetFullDetailsLectures());
        Console.WriteLine(mexicoCityLectureEvent.GetShortLecturesDescription());

        Console.WriteLine("\nReception Event:");
        Console.WriteLine(ldsChurchReceptionEvent.GetStandardDetails());
        Console.WriteLine(ldsChurchReceptionEvent.GetFullDetailsReceptions());
        Console.WriteLine(ldsChurchReceptionEvent.GetShortReceptionsDescription());

        Console.WriteLine("\nOutdoor Event:");
        Console.WriteLine(mexicoCityOutdoorEvent.GetStandardDetails());
        Console.WriteLine(mexicoCityOutdoorEvent.GetFullOutdoorGatheringsDetails());
        Console.WriteLine(mexicoCityOutdoorEvent.GetShortFullOutdoorGatheringsDescription());
    }
}