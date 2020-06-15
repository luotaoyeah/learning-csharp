using Luotao.Blazor.Models;
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
        public event EventHandler<NotifyEventArgs>? Notify;

        /// <summary>
        /// 触发 NotifyEvent 事件.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="value">value.</param>
        public void TriggerNotify(string key, int value)
        {
            Notify?.Invoke(this, new NotifyEventArgs { Key = key, Value = value });
        }
    }
}

#pragma warning restore S3906
