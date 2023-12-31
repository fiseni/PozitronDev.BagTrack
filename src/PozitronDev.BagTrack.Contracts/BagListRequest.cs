﻿using MediatR;
using PozitronDev.SharedKernel.Data;

namespace PozitronDev.BagTrack.Contracts;

public record BagListRequest : BaseFilter, IRequest<PagedResponse<BagDto>>
{
    public DateTimeOffset? FromDate { get; set; }
    public DateTimeOffset? ToDate { get; set; }
    public string? BagTagId { get; set; }
    public string? Carousel { get; set; }
    public string? AirlineIATA { get; set; }
    public string? Flight { get; set; }
}
