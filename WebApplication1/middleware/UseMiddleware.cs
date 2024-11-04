using System.Reflection;
using System.Runtime.CompilerServices;
using HotChocolate.Types.Descriptors;

namespace eShop.Catalog.Types.Configuration;

public class UseMiddleware: ObjectFieldDescriptorAttribute
{
    public UseMiddleware([CallerLineNumber] int order = 0)
    {
        Order = order;
    }
   
    protected override void OnConfigure(IDescriptorContext context, IObjectFieldDescriptor descriptor, MemberInfo member)
    {
       descriptor.Use(next => async context =>
       {
         var data = new List<string>();
            data.Add("Middleware executing...");
            context.ContextData["Middleware"] = data;
            
            Console.WriteLine(data[0]);
           
           await next(context);
       });
    }
}