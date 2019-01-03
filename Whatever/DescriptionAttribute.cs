using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatever {

    using System;

        [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
        public sealed class DescriptionAttribute : Attribute {
            public DescriptionAttribute(string description) {

                Description = description;
            }

            public string Description { get; }

            public string Copyright {
                get; set;
            }
        }

    }

