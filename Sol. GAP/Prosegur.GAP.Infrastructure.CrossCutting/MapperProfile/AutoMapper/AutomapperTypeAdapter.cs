using Rep.Traserep.Infra.CrossCutting.Adapter;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rep.Traserep.Infra.CrossCutting.Net.AutoMapper
{
    public class AutoMapperTypeAdapter : ITypeAdapter
    {
        public TTarget Adapt<TSource, TTarget>(TSource source)
            where TSource : class
            where TTarget : class, new()
        {
            return Mapper.Map<TSource, TTarget>(source);
        }

        public TTarget Adapt<TTarget>(object source) where TTarget : class, new()
        {
            return Mapper.Map<TTarget>(source);
        }
    }
}
