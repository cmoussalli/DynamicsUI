using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsUI.Utilities
{
    public class CssBuilder
    {

        private string buffer;


        public static CssBuilder Default(string value) => new(value);

        public static CssBuilder Empty() => new("");

        public CssBuilder(string value) => buffer = value;

        public CssBuilder AddValue(string value)
        {
            buffer += value;
            return this;
        }

        public CssBuilder AddClass(string value) => AddValue(" " + value);

        public CssBuilder AddClass(string value, bool when = true) => when ? this.AddClass(value) : this;

        public CssBuilder AddClass(string value, bool? when = true) => when == true ? this.AddClass(value) : this;

        public CssBuilder AddClass(string value, Func<bool> when = null) => this.AddClass(value, when != null && when());

        public CssBuilder AddClass(Func<string> value, bool when = true) => when ? this.AddClass(value()) : this;

        public CssBuilder AddClass(Func<string> value, Func<bool> when = null) => this.AddClass(value, when != null && when());

        public CssBuilder AddClass(CssBuilder builder, bool when = true) => when ? this.AddClass(builder.Build()) : this;

        public CssBuilder AddClass(CssBuilder builder, Func<bool> when = null) => this.AddClass(builder, when != null && when());

        public CssBuilder AddClassFromAttributes(IReadOnlyDictionary<string, object> additionalAttributes) =>
            additionalAttributes == null ? this :
            additionalAttributes.TryGetValue("class", out var c) ? AddClass(c.ToString()) : this;

        public string Build()
        {
            return buffer != null ? buffer.Trim() : string.Empty;
        }

        public override string ToString() => Build();



    }

}
