namespace SeppimCaraibesApp.Data.Repository
{
    internal class ShipmentRepository
    {
        public ORM.Shipment GetShipment(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            return context.Shipments.Find(code);
        }

        public void AddShipment(ORM.SeppimCaraibesLocalEntities context, ORM.Shipment shipment)
        {
            context.Shipments.Add(shipment);
            context.SaveChanges();
            context.Entry(shipment).Reload();
        }

        public void EditShipment(ORM.SeppimCaraibesLocalEntities context, ORM.Shipment shipment)
        {
            context.SaveChanges();
            context.Entry(shipment).Reload();
        }

        public void DeleteShipment(ORM.SeppimCaraibesLocalEntities context, string code)
        {
            var shipment = context.Shipments.Find(code);
            context.Shipments.Remove(shipment);
            context.SaveChanges();
        }
    }
}
