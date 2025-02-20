using System;
using System.Collections.Generic;

namespace TrainTicketsDomain.Model;

public partial class Train : Entity
{
    public int Id { get; set; }

    public int CurrentStationId { get; set; }

    public string TrainName { get; set; } = null!;

    public TimeOnly Date { get; set; }

    public int Duration { get; set; }

    public string Destination { get; set; } = null!;

    public int NumberOfSeats { get; set; }

    public int NumberOfCarriages { get; set; }

    public virtual ICollection<TicketTypeTrain> TicketTypeTrains { get; set; } = new List<TicketTypeTrain>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual ICollection<TrainAtRoute> TrainAtRoutes { get; set; } = new List<TrainAtRoute>();
}
