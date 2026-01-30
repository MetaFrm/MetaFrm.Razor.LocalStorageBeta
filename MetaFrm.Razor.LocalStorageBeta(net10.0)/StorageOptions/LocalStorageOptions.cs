using System.Text.Json;

namespace Blazored.LocalStorage.StorageOptions
{
    /// <summary>
    /// 
    /// </summary>
    public class LocalStorageOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public JsonSerializerOptions JsonSerializerOptions { get; set; } = new JsonSerializerOptions();
    }
}