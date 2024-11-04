
using System.Reflection;
using System.Runtime.CompilerServices;
using eShop.Catalog.Types.Configuration;
using HotChocolate.Types.Descriptors;

public class UseToUpperAttribute : ObjectFieldDescriptorAttribute
{
    public UseToUpperAttribute([CallerLineNumber] int order = default)
    {
        Order = order;
    }
    
    protected override void OnConfigure(
        IDescriptorContext context, 
        IObjectFieldDescriptor descriptor, 
        MemberInfo member)
        => descriptor.UseToUpper();
}