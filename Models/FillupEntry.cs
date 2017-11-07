// Contained in FillupEntry.cs
public class FillupEntry
{
  public int FillupEntryId { get; set; }
  public int VehicleId { get; set; }
  public DateTime Date { get; set; }
  public int Odometer { get; set; }
  public double PricePerUnit { get; set; }
  public double TotalUnits { get; set; }
  public string Vendor { get; set; }
  public double TransactionFee { get; set; }
  public double TotalCost
  {
    get { return (this.PricePerUnit*this.TotalUnits) + this.TransactionFee; }
  }       
}