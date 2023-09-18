﻿using System.Linq.Expressions;

namespace PozitronDev.BagTrack.Api.Bags;

public static class BagDtoMapper
{
    private static readonly Expression<Func<Bag, BagDto>> _expression = x => new BagDto
    {
        BagTagId = x.BagTagId,
        DeviceId = x.DeviceId,
        Date = x.Date,
        Carousel = x.Carousel,
        AirlineIATA = x.AirlineIATA,
        Flight = x.Flight,
    };

    private static readonly Func<Bag, BagDto> _func = _expression.Compile();


    public static BagDto MapToBagDto(this Bag bag) => _func(bag);

    public static Expression<Func<Bag, BagDto>> Expression => _expression;
}
