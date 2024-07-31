namespace Domain;

public class flight
{
    public int flight_id { get; set; }
    public int route_id { get; set; }
    public DateTime departure_time { get; set; }
    public DateTime arrival_time { get; set; }
    public int airline_id { get; set; }
}
