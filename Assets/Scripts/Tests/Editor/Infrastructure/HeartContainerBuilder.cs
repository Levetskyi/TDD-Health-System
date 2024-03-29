﻿using System.Collections.Generic;

public class HeartContainerBuilder : TestDataBuilder<HeartContainer>
{
    private List<Heart> _hearts;

    public HeartContainerBuilder(List<Heart> hearts)
    {
        _hearts = hearts;
    }

    public HeartContainerBuilder() : this(new List<Heart>())
    {

    }

    public HeartContainerBuilder With(params Heart[] hearts)
    {
        _hearts.AddRange(hearts);

        return this;
    }

    public override HeartContainer Build()
    {
        //return new HeartContainer(_hearts);
        return null;
    }
}
