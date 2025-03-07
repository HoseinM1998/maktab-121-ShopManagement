using Microsoft.AspNetCore.Mvc;

namespace ShopManagement.MvcUI.WebFramework.Mvc.BaseClasses;

public class MyCustomController : Controller
{
    public string GetName(string name) => name + name;
}