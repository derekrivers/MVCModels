using System;
using System.Web.Mvc;
using MVCModels.Models;


namespace MVCModels.Infrastructure
{
    public class AddressSummaryBinder : IModelBinder
    {
        public object BindModel(ControllerContext context, ModelBindingContext bindingContext)
        {
            AddressSummary model = (AddressSummary) bindingContext.Model ?? new AddressSummary();

            model.City = GetValue(bindingContext, "City");
            model.Country = GetValue(bindingContext, "Country");

            return model;

        }

        private string GetValue(ModelBindingContext context, string name)
        {
            name = (context.ModelName == "" ? "" : context.ModelName + ".") + name;

            ValueProviderResult result = context.ValueProvider.GetValue(name);

            if (result == null || result.AttemptedValue == "")
            {
                return "<Not Specified>";
            }

            return result.AttemptedValue;
        }
    }
}