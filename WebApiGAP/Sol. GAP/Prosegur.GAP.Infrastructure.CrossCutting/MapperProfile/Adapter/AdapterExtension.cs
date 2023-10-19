﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rep.Traserep.Infra.CrossCutting.Adapter
{
    public static class AdapterExtension
    {
        public static TProjection ProjectedAs<TProjection>(this object item)
            where TProjection : class, new()
        {
            var adapter = TypeAdapterFactory.CreateAdapter();
            return adapter.Adapt<TProjection>(item);
        }
    }
}
