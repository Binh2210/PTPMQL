namespace FirstWebMVC.Models;
public class InvoiceModel
{
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }

    public double CalculateTotalPrice()
    {
        return Quantity * UnitPrice;
    }
}
