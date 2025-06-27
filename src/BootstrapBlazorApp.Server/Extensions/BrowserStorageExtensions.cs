using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace BootstrapBlazorApp.Server.Extensions;

public static class BrowserStorageExtensions
{

    public static async Task<TValue?> GetValueAsync<TValue>(this ProtectedLocalStorage localStorage, string key)
    {
        TValue? ret = default;
        try
        {
            var v = await localStorage.GetAsync<TValue>(key);
            if (v.Success)
            {
                ret = v.Value;
            }
        }
        catch { }
        return ret;
    }

    public static async Task<TValue?> GetValueAsync<TValue>(this ProtectedSessionStorage sessionStorage, string key)
    {
        TValue? ret = default;
        try
        {
            var v = await sessionStorage.GetAsync<TValue>(key);
            if (v.Success)
            {
                ret = v.Value;
            }
        }
        catch { }
        return ret;
    }
}
