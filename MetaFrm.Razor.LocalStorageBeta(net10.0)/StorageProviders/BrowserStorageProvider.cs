using Microsoft.JSInterop;
using Blazored.LocalStorage.Exceptions;

namespace Blazored.LocalStorage;

[Obsolete("사용되지 않습니다.")]
internal class BrowserStorageProvider : BrowserStorageProviderBase, IStorageProvider
{
    public BrowserStorageProvider(IJSRuntime jSRuntime) : base(jSRuntime) { }

    [Obsolete("사용되지 않습니다.")]
    public async ValueTask<string?> GetItemAsync(string key, CancellationToken cancellationToken = default)
    {
        try
        {
            return await JSRuntime.InvokeAsync<string?>("localStorage.getItem", cancellationToken, key);
        }
        catch (Exception exception)
        {
            if (IsStorageDisabledException(exception))
            {
                throw new BrowserStorageDisabledException(StorageNotAvailableMessage, exception);
            }

            throw;
        }
    }

    [Obsolete("사용되지 않습니다.")]
    public async ValueTask SetItemAsync(string key, string data, CancellationToken cancellationToken = default)
    {
        try
        {
            await JSRuntime.InvokeVoidAsync("localStorage.setItem", cancellationToken, key, data);
        }
        catch (Exception exception)
        {
            if (IsStorageDisabledException(exception))
            {
                throw new BrowserStorageDisabledException(StorageNotAvailableMessage, exception);
            }

            throw;
        }
    }
}