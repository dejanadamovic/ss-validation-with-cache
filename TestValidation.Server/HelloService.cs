using ServiceStack;

namespace TestValidation.Server
{
    public class HelloService: Service
    {
        [CacheResponse(Duration = 3600, MaxAge = 3600)]
        public object Get(Hello request)
        {
            return new HelloResponse { Result = $"GET: Hello, {request.Name}!" };
        }

        public object Post(Hello request)
        {
            return new HelloResponse { Result = $"POST: Hello, {request.Name}!" };
        }
    }
}
