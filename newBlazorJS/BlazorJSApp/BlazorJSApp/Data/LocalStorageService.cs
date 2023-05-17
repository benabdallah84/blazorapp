using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorJSApp.Data
{
    public class LocalStorageService
    {
        public IJSRuntime JSRuntime { get; set; }
        public LocalStorageService(IJSRuntime jsRuntime)
        {
            JSRuntime = jsRuntime;
        }
        
        
        public async Task SetItemAsync(string key, string value)
        {
            await JSRuntime.InvokeVoidAsync("localStorage.setItem", key, value);
        }
        public async Task<string> GetItemsAsync(string key)
        {
            return await JSRuntime.InvokeAsync<string>("localStorage.getItem", key);
        }
    }
}
