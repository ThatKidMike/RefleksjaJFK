using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Whatever
{
    public class MainFilter
    {
        public static void Main(string[] args) {

            var path = 0 == args.Length ? string.Empty : args[0];
            if (!File.Exists(path)) {
                return;
            }

            var assembly = Assembly.LoadFrom(path);
            foreach (var type in assembly.GetExportedTypes()) {
                var descriptionAttribute = type.GetCustomAttribute<DescriptionAttribute>(true);
                if (null != descriptionAttribute) {
                    Write("Description: '{0}'", descriptionAttribute.Description);
                    WriteLine(string.IsNullOrEmpty(descriptionAttribute.Copyright) ? string.Empty : $" Copyright: '{descriptionAttribute.Copyright}'");
                }

                if (!typeof(IValid).IsAssignableFrom(type)) {
                    continue;
                }

                if (!(Activator.CreateInstance(type) is IValid validated)) {
                    throw new InvalidOperationException();
                }

                //WriteLine("Result: {0}", callable.Call());
            }
        }

    }
}
