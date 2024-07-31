using System.Text;

namespace ConsoleApp1.Core.Application;

public class CsvHelper
{
    public void MakeCsv(List<SearchResult> data)
    {
        var csv = new StringBuilder();
        csv.AppendLine("flight_id,origin_city_id,destination_city_id,departure_time,arrival_time,airline_id,status");


        for (int i = 0; i < data.Count; i++)
        {
            var newRow = $"{data[i].flight_id},{data[i].origin_city_id},{data[i].destination_city_id},{data[i].departure_time},{data[i].arrival_time},{data[i].airline_id},{data[i].status}";
            csv.AppendLine(newRow);
        }

        File.WriteAllText("results.csv", csv.ToString());
        //System.Diagnostics.Process.Start(@"bin\Debug\net8.0\results.csv");
    }
}
