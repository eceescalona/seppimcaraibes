namespace SeppimCaraibesApp.Data.Repository
{
    using System.Threading.Tasks;

    internal class ShipmentRepository
    {
        public async Task<ORM.Shipment> GetShipment(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            return await context.Shipments.FindAsync(code);
        }

        public void AddShipment(ORM.SeppimCaraibesLocalEntities context, ORM.Shipment shipment)
        {
            context.Shipments.Add(shipment);
            context.SaveChanges();
            context.Entry(shipment).Reload();
        }

        public void EditShipment(ORM.SeppimCaraibesLocalEntities context, ORM.Shipment shipment)
        {
            context.Shipments.Add(shipment);
            context.Entry(shipment).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            context.Entry(shipment).Reload();
        }

        public async void DeleteShipment(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var shipment = await context.Shipments.FindAsync(code);
            context.Shipments.Remove(shipment);
            context.SaveChanges();
        }
    }
}
