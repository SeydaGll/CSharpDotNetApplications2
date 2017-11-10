using System;
namespace WinFormEFex
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string CertificateNo { get; set; }
        public DateTime LatestService { get; set; }
        public Customer Customer { get; set; } //her arabanın müşteriye ait olma durumu
        public int CustomerId { get; set; }
    }
}