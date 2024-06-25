﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketStore.Services.Marketing.Models;

namespace TicketStore.Services.Marketing.Entities
{
    public class BasketChangeEvent
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid EventId { get; set; }
        public DateTimeOffset InsertedAt { get; set; }
        public BasketChangeTypeEnum BasketChangeType { get; set; }
    }
}
