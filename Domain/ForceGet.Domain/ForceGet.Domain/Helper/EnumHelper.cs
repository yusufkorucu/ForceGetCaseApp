//using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.Web.Mvc;

namespace ForceGet.Domain.Helper
{
    public static class EnumHelper
    {
        public static string GetEnumDescription(this Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            var descriptionAttribute = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return descriptionAttribute.Length > 0 ? descriptionAttribute[0].Description : enumValue.ToString();
        }
        public static SelectList EnumSelectlist<TEnum>(bool indexed = false) where TEnum : struct
        {
            return new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(item => new SelectListItem
            {
                Text = GetEnumDescription(item as Enum),
                Value = indexed ? Convert.ToInt32(item).ToString() : item.ToString()
            }).ToList(), "Value", "Text");
        }
    }

   
}
