using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submission.API.Endpoints;

public static class EndpointRegistration
{
    public static IEndpointRouteBuilder MapAllEndpoints(this IEndpointRouteBuilder app)
    {
        CreateArticleEndpoint.Map(app);
        return app;
    }
}
