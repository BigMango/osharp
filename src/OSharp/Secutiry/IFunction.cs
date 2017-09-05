﻿// -----------------------------------------------------------------------
//  <copyright file="IFunction.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-09-04 8:43</last-date>
// -----------------------------------------------------------------------

using System;


namespace OSharp.Secutiry
{
    /// <summary>
    /// 定义最小功能信息
    /// </summary>
    public interface IFunction
    {
        /// <summary>
        /// 获取或设置 功能编号
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// 获取或设置 区域名称
        /// </summary>
        string Area { get; set; }

        /// <summary>
        /// 获取或设置 控制器名称
        /// </summary>
        string Controller { get; set; }

        /// <summary>
        /// 获取或设置 功能名称
        /// </summary>
        string Action { get; set; }

        /// <summary>
        /// 获取或设置 访问类型
        /// </summary>
        AccessType AccessType { get; set; }

        /// <summary>
        /// 获取或设置 访问类型是否理发，如为true，刷新功能时将忽略功能类型
        /// </summary>
        bool IsAccessTypeChanged { get; set; }

        /// <summary>
        /// 获取或设置 是否启用操作日志
        /// </summary>
        bool OperateLogEnabled { get; set; }

        /// <summary>
        /// 获取或设置 是否启用数据日志
        /// </summary>
        bool DataLogEnabled { get; set; }

        /// <summary>
        /// 获取或设置 数据缓存时间（秒）
        /// </summary>
        int CacheExpirationSeconds { get; set; }

        /// <summary>
        /// 获取或设置 是否相对过期时间，否则为绝对过期
        /// </summary>
        bool IsCacheSliding { get; set; }
    }
}