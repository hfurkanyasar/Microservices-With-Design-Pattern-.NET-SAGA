﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class RabbitMQSettingsConst
    {
        public const string StockRedervedEventQueueName = "stock-reserved-queue";
        public const string StockOrderCreatedEventQueueName = "stock-order-created-queue";
        public const string PaymentStockReservedEventQueueName = "Payment-storck-reserved-queue";
    }
}
