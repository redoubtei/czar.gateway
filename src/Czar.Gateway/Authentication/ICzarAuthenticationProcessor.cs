﻿using System.Threading.Tasks;

namespace Czar.Gateway.Authentication
{
    /// <summary>
    /// 金焰的世界
    /// 2018-11-15
    /// 自定义授权处理器
    /// </summary>
    public interface ICzarAuthenticationProcessor
    {
        /// <summary>
        /// 校验当前的请求地址客户端是否有权限访问
        /// </summary>
        /// <param name="clientid">客户端ID</param>
        /// <param name="path">请求地址</param>
        /// <returns></returns>
        Task<bool> CheckClientAuthenticationAsync(string clientid, string path);
    }
}
