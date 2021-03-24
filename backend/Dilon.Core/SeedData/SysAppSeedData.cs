﻿using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Dilon.Core
{
    /// <summary>
    /// 系统应用表种子数据
    /// </summary>
    public class SysAppSeedData : IEntitySeedData<SysApp>
    {
        /// <summary>
        /// 种子数据
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="dbContextLocator"></param>
        /// <returns></returns>
        public IEnumerable<SysApp> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new[]
            {
                new SysApp{Id=1, Name="系统管理", Code="system", Active="Y", Status=0, Sort=100 },
                new SysApp{Id=2, Name="系统工具", Code="system_tool", Active="N", Status=0, Sort=100 }
            };
        }
    }
}