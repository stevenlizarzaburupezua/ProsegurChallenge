using System;
using System.Collections.Generic;
using System.Text;

namespace Rep.Traserep.Infra.CrossCutting.Adapter
{
    public interface ITypeAdapterFactory
    {
        ITypeAdapter Create();
    }
}
