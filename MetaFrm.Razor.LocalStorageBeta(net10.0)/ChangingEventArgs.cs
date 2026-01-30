using System.Diagnostics.CodeAnalysis;

namespace Blazored.LocalStorage
{
    /// <summary>
    /// 
    /// </summary>
    [ExcludeFromCodeCoverage]
    [Obsolete("사용되지 않습니다.")]
    public class ChangingEventArgs : ChangedEventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        [Obsolete("사용되지 않습니다.")]
        public bool Cancel { get; set; }
    }
}