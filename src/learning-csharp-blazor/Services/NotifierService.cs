using System;

#pragma warning disable S3906

namespace Luotao.Blazor.Services
{
    /// <summary>
    /// 通知服务.
    /// </summary>
    public class NotifierService
    {
        /// <summary>
        /// 通知事件.
        /// </summary>
        public event EventHandler<NotifyEventArgs>? NotifyEvent;

        /// <summary>
        /// 触发 NotifyEvent 事件.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="value">value.</param>
        public void Update(string key, int value)
        {
            NotifyEvent?.Invoke(this, new NotifyEventArgs { Key = key, Value = value });
        }
    }
}

#pragma warning restore S3906
