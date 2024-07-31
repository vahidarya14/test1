namespace Domain;

public class route
{
    public int route_id { get; set; }
    public int origin_city_id { get; set; }
    public int destination_city_id { get; set; }
    public DateOnly departure_date { get; set; }
}
