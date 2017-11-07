public Vehicle GetVehicle(int userId, int vehicleId)
{
  return this.GetDbSet<Vehicle>()
  .Include("Fillups")
  .Include("Reminders")
  .Where(v => v.VehicleId == vehicleId && v.UserId == userId)
  .Single();
}