using System.Diagnostics.CodeAnalysis;

namespace Blazored.LocalStorage
{
    /// <summary>
    /// 
    /// </summary>
    [ExcludeFromCodeCoverage]
    [Obsolete("사용되지 않습니다.")]
    public class ChangedEventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        [Obsolete("사용되지 않습니다.")]
        public string Key { get; set; } = null!; // Since .NET 6 is supported, `required` is not available yet
        /// <summary>
        /// 
        /// </summary>
        [Obsolete("사용되지 않습니다.")]
        public object? OldValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Obsolete("사용되지 않습니다.")]
        public object? NewValue { get; set; }
    }
}