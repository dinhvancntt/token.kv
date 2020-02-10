using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace WebAPI.ServiceModel
{
    [Route("/gettoken")]
    public class Tocken : IReturn<object>
    {
    }
}