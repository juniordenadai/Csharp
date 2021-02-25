﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Entities.Enums
{
    enum OrderStatus :int
    {
        Pending_Payment,
        Processing,
        Shipped,
        Delivered
    }
}
