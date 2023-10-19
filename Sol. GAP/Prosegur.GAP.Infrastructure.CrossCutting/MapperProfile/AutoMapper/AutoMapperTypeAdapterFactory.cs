using Rep.Traserep.Infra.CrossCutting.Adapter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;

namespace Rep.Traserep.Infra.CrossCutting.Net.AutoMapper
{
    public class AutoMapperTypeAdapterFactory : ITypeAdapterFactory
    {
        public AutoMapperTypeAdapterFactory()
        {
            var tipos = new List<Type>();
            string[] assembliesAsArray = { "Prosegur.GAP.Application", "Prosegur.GAP.WebAPI", "Prosegur.GAP.Infrastructure.CrossCutting" };
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(p => assembliesAsArray.Contains(p.GetName().Name)).ToList();
            foreach (var assembly in assemblies)
            {
                foreach (var type in assembly.GetTypes())
                {
                    if (type.BaseType == typeof(Profile)) tipos.Add(type);
                }
            }

            Mapper.Initialize(cfg =>
            {
                foreach (var tipo in tipos)
                {
                    cfg.AddProfile(Activator.CreateInstance(tipo) as Profile);
                }

            });
        }

        public ITypeAdapter Create()
        {
            return new AutoMapperTypeAdapter();
        }
    }
}
