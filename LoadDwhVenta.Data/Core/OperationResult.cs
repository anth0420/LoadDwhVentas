﻿
namespace LoadDwhVenta.Data.Core
{
    public class OperationResult
    {
        public string? Message { get; set; }

        public bool? Success { get; set; }
        public dynamic? Data { get; set; }
    }
}