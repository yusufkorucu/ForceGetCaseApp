using ForceGet.Domain.Helper;
using System.Web.Mvc;

namespace ForceGet.Domain.ViewModel
{
    public class EnumViewModel<TEnum>
    {
        public IEnumerable<SelectListItem> EnumList { get; set; }

        public EnumViewModel()
        {
            EnumList = Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .Select(e => new SelectListItem
                {
                    Value = ((int)(object)e).ToString(),
                    Text = EnumHelper.GetEnumDescription(e as Enum)
                });

        }
    }
}
