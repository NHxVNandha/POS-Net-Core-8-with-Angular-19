﻿namespace POS.Domain.Entities.MasterData
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
    }
}
