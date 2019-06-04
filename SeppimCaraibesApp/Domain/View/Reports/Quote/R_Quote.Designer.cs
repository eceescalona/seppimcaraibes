namespace SeppimCaraibesApp.Domain.View.Reports.Quote
{
    partial class R_Quote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.placeDepartureXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.observationsXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.packingXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.netWeightXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.grossWeightXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.totalCostXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.freightXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.eXWXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.deviseXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.incotermsXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.incotermsTypeXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.shippingMethodXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.paymentOptionXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.customerPhoneXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.customerAddressXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.customerNameXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.providerNameXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.providerPhoneXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.providerReferenceXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.dateXRL = new DevExpress.XtraReports.UI.XRLabel();
            this.orderReportViewODS = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.orderReportViewODS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.placeDepartureXRL,
            this.observationsXRL,
            this.packingXRL,
            this.netWeightXRL,
            this.grossWeightXRL,
            this.totalCostXRL,
            this.freightXRL,
            this.eXWXRL,
            this.deviseXRL,
            this.incotermsXRL,
            this.incotermsTypeXRL,
            this.shippingMethodXRL,
            this.paymentOptionXRL,
            this.customerPhoneXRL,
            this.customerAddressXRL,
            this.customerNameXRL,
            this.providerNameXRL,
            this.providerPhoneXRL,
            this.providerReferenceXRL,
            this.dateXRL});
            this.Detail.HeightF = 628.125F;
            this.Detail.Name = "Detail";
            // 
            // placeDepartureXRL
            // 
            this.placeDepartureXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PlaceOfDeparture]")});
            this.placeDepartureXRL.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 590.5834F);
            this.placeDepartureXRL.Multiline = true;
            this.placeDepartureXRL.Name = "placeDepartureXRL";
            this.placeDepartureXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.placeDepartureXRL.SizeF = new System.Drawing.SizeF(296.875F, 23F);
            this.placeDepartureXRL.Text = "placeDepartureXRL";
            // 
            // observationsXRL
            // 
            this.observationsXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Observations]")});
            this.observationsXRL.LocationFloat = new DevExpress.Utils.PointFloat(267.1874F, 490.5833F);
            this.observationsXRL.Multiline = true;
            this.observationsXRL.Name = "observationsXRL";
            this.observationsXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.observationsXRL.SizeF = new System.Drawing.SizeF(372.8124F, 22.99997F);
            this.observationsXRL.Text = "observationsXRL";
            // 
            // packingXRL
            // 
            this.packingXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Packing]")});
            this.packingXRL.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 556.5833F);
            this.packingXRL.Multiline = true;
            this.packingXRL.Name = "packingXRL";
            this.packingXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.packingXRL.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.packingXRL.Text = "packingXRL";
            // 
            // netWeightXRL
            // 
            this.netWeightXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NetWeight]")});
            this.netWeightXRL.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 523.9167F);
            this.netWeightXRL.Multiline = true;
            this.netWeightXRL.Name = "netWeightXRL";
            this.netWeightXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.netWeightXRL.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.netWeightXRL.Text = "netWeightXRL";
            // 
            // grossWeightXRL
            // 
            this.grossWeightXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GrossWeight]")});
            this.grossWeightXRL.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 490.5833F);
            this.grossWeightXRL.Multiline = true;
            this.grossWeightXRL.Name = "grossWeightXRL";
            this.grossWeightXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.grossWeightXRL.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.grossWeightXRL.Text = "grossWeightXRL";
            // 
            // totalCostXRL
            // 
            this.totalCostXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalCost]")});
            this.totalCostXRL.LocationFloat = new DevExpress.Utils.PointFloat(539.9998F, 435.375F);
            this.totalCostXRL.Multiline = true;
            this.totalCostXRL.Name = "totalCostXRL";
            this.totalCostXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.totalCostXRL.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.totalCostXRL.Text = "totalCostXRL";
            // 
            // freightXRL
            // 
            this.freightXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Freight]")});
            this.freightXRL.LocationFloat = new DevExpress.Utils.PointFloat(539.9998F, 399.9583F);
            this.freightXRL.Multiline = true;
            this.freightXRL.Name = "freightXRL";
            this.freightXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.freightXRL.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.freightXRL.Text = "freightXRL";
            // 
            // eXWXRL
            // 
            this.eXWXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EXW]")});
            this.eXWXRL.LocationFloat = new DevExpress.Utils.PointFloat(540F, 366.625F);
            this.eXWXRL.Multiline = true;
            this.eXWXRL.Name = "eXWXRL";
            this.eXWXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.eXWXRL.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.eXWXRL.Text = "eXWXRL";
            // 
            // deviseXRL
            // 
            this.deviseXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Divisa: [Devise]")});
            this.deviseXRL.LocationFloat = new DevExpress.Utils.PointFloat(539.9999F, 258.2917F);
            this.deviseXRL.Multiline = true;
            this.deviseXRL.Name = "deviseXRL";
            this.deviseXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.deviseXRL.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.deviseXRL.Text = "deviseXRL";
            // 
            // incotermsXRL
            // 
            this.incotermsXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Incoterm]")});
            this.incotermsXRL.LocationFloat = new DevExpress.Utils.PointFloat(539.9999F, 291.625F);
            this.incotermsXRL.Multiline = true;
            this.incotermsXRL.Name = "incotermsXRL";
            this.incotermsXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.incotermsXRL.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.incotermsXRL.Text = "incotermsXRL";
            // 
            // incotermsTypeXRL
            // 
            this.incotermsTypeXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Incoterm: [IncotermsType]")});
            this.incotermsTypeXRL.LocationFloat = new DevExpress.Utils.PointFloat(353.5416F, 291.625F);
            this.incotermsTypeXRL.Multiline = true;
            this.incotermsTypeXRL.Name = "incotermsTypeXRL";
            this.incotermsTypeXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.incotermsTypeXRL.SizeF = new System.Drawing.SizeF(168.9584F, 23F);
            this.incotermsTypeXRL.Text = "incotermsTypeXRL";
            // 
            // shippingMethodXRL
            // 
            this.shippingMethodXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Modo de Envío: [ShippingMethod]")});
            this.shippingMethodXRL.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 291.625F);
            this.shippingMethodXRL.Multiline = true;
            this.shippingMethodXRL.Name = "shippingMethodXRL";
            this.shippingMethodXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.shippingMethodXRL.SizeF = new System.Drawing.SizeF(207.2917F, 23F);
            this.shippingMethodXRL.Text = "shippingMethodXRL";
            // 
            // paymentOptionXRL
            // 
            this.paymentOptionXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Condiciones de Pago: [PaymentOption]")});
            this.paymentOptionXRL.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 258.2917F);
            this.paymentOptionXRL.Multiline = true;
            this.paymentOptionXRL.Name = "paymentOptionXRL";
            this.paymentOptionXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.paymentOptionXRL.SizeF = new System.Drawing.SizeF(296.875F, 23F);
            this.paymentOptionXRL.Text = "paymentOptionXRL";
            // 
            // customerPhoneXRL
            // 
            this.customerPhoneXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerPhone]")});
            this.customerPhoneXRL.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 217.6667F);
            this.customerPhoneXRL.Multiline = true;
            this.customerPhoneXRL.Name = "customerPhoneXRL";
            this.customerPhoneXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.customerPhoneXRL.SizeF = new System.Drawing.SizeF(207.2917F, 23F);
            this.customerPhoneXRL.Text = "customerPhoneXRL";
            // 
            // customerAddressXRL
            // 
            this.customerAddressXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerAddress]")});
            this.customerAddressXRL.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 184.3334F);
            this.customerAddressXRL.Multiline = true;
            this.customerAddressXRL.Name = "customerAddressXRL";
            this.customerAddressXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.customerAddressXRL.SizeF = new System.Drawing.SizeF(296.875F, 23F);
            this.customerAddressXRL.Text = "customerAddressXRL";
            // 
            // customerNameXRL
            // 
            this.customerNameXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerName]")});
            this.customerNameXRL.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 149.9584F);
            this.customerNameXRL.Multiline = true;
            this.customerNameXRL.Name = "customerNameXRL";
            this.customerNameXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.customerNameXRL.SizeF = new System.Drawing.SizeF(207.2917F, 23F);
            this.customerNameXRL.Text = "customerNameXRL";
            // 
            // providerNameXRL
            // 
            this.providerNameXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", " A: [ProviderName]")});
            this.providerNameXRL.LocationFloat = new DevExpress.Utils.PointFloat(413.9582F, 82.16667F);
            this.providerNameXRL.Multiline = true;
            this.providerNameXRL.Name = "providerNameXRL";
            this.providerNameXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.providerNameXRL.SizeF = new System.Drawing.SizeF(226.0418F, 23F);
            this.providerNameXRL.Text = "providerNameXRL";
            // 
            // providerPhoneXRL
            // 
            this.providerPhoneXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Teléfono: [ProviderPhone]")});
            this.providerPhoneXRL.LocationFloat = new DevExpress.Utils.PointFloat(462.9166F, 116.625F);
            this.providerPhoneXRL.Multiline = true;
            this.providerPhoneXRL.Name = "providerPhoneXRL";
            this.providerPhoneXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.providerPhoneXRL.SizeF = new System.Drawing.SizeF(177.0833F, 23.00002F);
            this.providerPhoneXRL.Text = "providerPhoneXRL";
            // 
            // providerReferenceXRL
            // 
            this.providerReferenceXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Referencia del Provedor: [ProviderReference]")});
            this.providerReferenceXRL.LocationFloat = new DevExpress.Utils.PointFloat(353.5416F, 45.49999F);
            this.providerReferenceXRL.Multiline = true;
            this.providerReferenceXRL.Name = "providerReferenceXRL";
            this.providerReferenceXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.providerReferenceXRL.SizeF = new System.Drawing.SizeF(286.4583F, 23F);
            this.providerReferenceXRL.Text = "providerReferenceXRL";
            // 
            // dateXRL
            // 
            this.dateXRL.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Fecha: [Date]")});
            this.dateXRL.LocationFloat = new DevExpress.Utils.PointFloat(489.9999F, 10.00001F);
            this.dateXRL.Multiline = true;
            this.dateXRL.Name = "dateXRL";
            this.dateXRL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.dateXRL.SizeF = new System.Drawing.SizeF(150.0001F, 23F);
            this.dateXRL.Text = "dateXRL";
            // 
            // orderReportViewODS
            // 
            this.orderReportViewODS.DataSource = typeof(SeppimCaraibesApp.Data.POCO.OrderReportView);
            this.orderReportViewODS.Name = "orderReportViewODS";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 336.5F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(512.5F, 25F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 11.5D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductId]")});
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.Weight = 2D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")});
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.Weight = 2D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Qty]")});
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.Weight = 2D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")});
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.Weight = 2D;
            // 
            // R_Quote
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.orderReportViewODS});
            this.DataMember = "Products";
            this.DataSource = this.orderReportViewODS;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this.orderReportViewODS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel packingXRL;
        private DevExpress.XtraReports.UI.XRLabel netWeightXRL;
        private DevExpress.XtraReports.UI.XRLabel grossWeightXRL;
        private DevExpress.XtraReports.UI.XRLabel totalCostXRL;
        private DevExpress.XtraReports.UI.XRLabel freightXRL;
        private DevExpress.XtraReports.UI.XRLabel eXWXRL;
        private DevExpress.XtraReports.UI.XRLabel deviseXRL;
        private DevExpress.XtraReports.UI.XRLabel incotermsXRL;
        private DevExpress.XtraReports.UI.XRLabel incotermsTypeXRL;
        private DevExpress.XtraReports.UI.XRLabel shippingMethodXRL;
        private DevExpress.XtraReports.UI.XRLabel paymentOptionXRL;
        private DevExpress.XtraReports.UI.XRLabel customerPhoneXRL;
        private DevExpress.XtraReports.UI.XRLabel customerAddressXRL;
        private DevExpress.XtraReports.UI.XRLabel customerNameXRL;
        private DevExpress.XtraReports.UI.XRLabel providerNameXRL;
        private DevExpress.XtraReports.UI.XRLabel providerPhoneXRL;
        private DevExpress.XtraReports.UI.XRLabel providerReferenceXRL;
        private DevExpress.XtraReports.UI.XRLabel dateXRL;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource orderReportViewODS;
        private DevExpress.XtraReports.UI.XRLabel placeDepartureXRL;
        private DevExpress.XtraReports.UI.XRLabel observationsXRL;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
    }
}
