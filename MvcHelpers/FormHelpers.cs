using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;


namespace MvcHelpers
{
    public static class FormHelpers
    {
        public static MvcHtmlString DatepickerTextBoxFor<TModel, TProperty>(
             this HtmlHelper<TModel> helper,
             Expression<Func<TModel, TProperty>> expression)
        {
            return helper.TextBoxFor(expression, new { @class = "datepicker" });
        }


        //public static DropDownListForEnum DropDownForEnum(this HtmlHelper html, string name, Task Enum e)
        //{
        //    return new DropDownListForEnum(name, e);
        //}
    }

    

    public class DropDownListForEnum : IHtmlString
    {
        public string Name { get; set; }
        public Enum Enum { get; set; }

        public DropDownListForEnum(string name, Enum e)
        {
            this.Enum = e;
        }

        //Render
        public override string ToString()
        {
            return string.Format(@"<select id='{0}'><option>Select ...</option></select>", Name);
        }

        public string ToHtmlString()
        {
            return ToString();
        }
    }
}
