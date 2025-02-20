﻿using System;
using System.Collections.Generic;

namespace TrainTicketsDomain.Model;

public partial class TicketType : Entity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int SeatNumber { get; set; }

    public int TrainCarriage { get; set; }

    public virtual ICollection<TicketTypeTrain> TicketTypeTrains { get; set; } = new List<TicketTypeTrain>();
}
