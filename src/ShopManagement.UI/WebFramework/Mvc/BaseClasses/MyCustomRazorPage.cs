using Microsoft.AspNetCore.Mvc.Razor;

namespace ShopManagement.MvcUI.WebFramework.Mvc.BaseClasses;

public abstract class MyCustomRazorPage<T> : RazorPage<T>
{

    public string GetName(string name) => name;

}