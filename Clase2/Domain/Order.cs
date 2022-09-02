namespace Domain;

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address  { get; set; }
    public int PutchaseNumber { get; set; }
    public int Price { get; set; }
    public DateTime DeliveryDateTima { get; set; }
}