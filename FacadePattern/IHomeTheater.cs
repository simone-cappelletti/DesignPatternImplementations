using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public interface IHomeTheater
    {
        string TurnOnHomeTheater(string movie);
        string TurnOfHomeTheater();
    }
}
