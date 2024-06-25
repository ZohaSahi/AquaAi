using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaAi.Shared.Wrapper
{
    public interface IResult<T>
    {
        bool Succeeded { get; }
        string[] Messages { get; }
        T Data { get; }
    }
}
