using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AbpGiftCard.Web.Extensions
{
    /// <summary>
    /// 扩展方法用静态类
    /// </summary>
    public static class AssemblyInjectionExtension
    {
        public static void AddByAssembly(this IServiceCollection services, string assemblyName)
        {
            if (string.IsNullOrEmpty(assemblyName)) return;

            Assembly assembly = Assembly.Load(assemblyName);

            var  types = assembly.GetTypes();

            var filterTypes = types.Where(item => !item.IsInterface && !item.IsGenericType).ToList();

            var interfaceInstance = new Dictionary<Type, Type[]>();

            foreach (var type in filterTypes)
            {
                //获取实体的所有接口类型
                var interfaceTypes = type.GetInterfaces();
                foreach (var item in interfaceTypes)
                {
                    interfaceInstance.Add(type,interfaceTypes);
                }
            }
            //注册进容器
            foreach (var dicItem in interfaceInstance)
            {
                foreach (var item in dicItem.Value )
                {
                    services.AddSingleton(item, dicItem.Key);
                }
            }

        }

    }
}
