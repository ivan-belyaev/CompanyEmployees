using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CompanyEmployees.ModelBinders
{
    /// <summary>
    ///  Array Model Binder
    /// </summary>
    public class ArrayModelBinder : IModelBinder
    {
        /// <summary>
        ///  Bind Model Async
        /// </summary>
        /// <param name="bindingContext">Binding Context</param>
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            // check if our parameter IEnumerable type
            if (!bindingContext.ModelMetadata.IsEnumerableType)
            {
                bindingContext.Result = ModelBindingResult.Failed();
                return Task.CompletedTask;
            }

            // extract the value (a comma-separated string of GUIDs) with the 
            // ValueProvider.GetValue() expression
            var providedValue = bindingContext.ValueProvider
                .GetValue(bindingContext.ModelName)
                .ToString();
            if(string.IsNullOrEmpty(providedValue))
            {
                bindingContext.Result = ModelBindingResult.Success(null);
                return Task.CompletedTask;
            }

            // with the reflection store the type the IEnumerable consists of
            var genericType = bindingContext.ModelType.GetTypeInfo().GenericTypeArguments[0];
            var converter = TypeDescriptor.GetConverter(genericType);

            // consist of all the GUID values
            var objectArray = providedValue.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => converter.ConvertFromString(x.Trim()))
                .ToArray();

            // create an array of GUID types
            var guidArray = Array.CreateInstance(genericType, objectArray.Length);

            // copy all the values from the objectArray to the guidArray
            objectArray.CopyTo(guidArray, 0);

            // assign it to the bindingContext
            bindingContext.Model = guidArray;

            bindingContext.Result = ModelBindingResult.Success(bindingContext.Model);
            return Task.CompletedTask;
        }
    }
}
