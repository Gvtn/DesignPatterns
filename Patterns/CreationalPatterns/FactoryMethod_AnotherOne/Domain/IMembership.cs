﻿namespace CreationalPatterns.Domain
{
    internal interface IMembership
    {
        string Name { get; }
        string Description { get; set; }
        decimal GetPrice();
    }
}
