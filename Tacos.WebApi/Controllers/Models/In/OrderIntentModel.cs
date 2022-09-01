using System.Collections.Generic;
using System.Linq;
using System;

namespace Tacos.WebApi.Controllers.In;

public class OrderIntentModel
{
    public List<string> Plates { get; set; }

    public List<string> Drinks { get; set; }

    public int Table { get; set; }

}