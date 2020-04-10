﻿using Prism.Modularity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlankApp.Doamin.Services
{
    public interface IModuleService
    {
        IEnumerable<IModuleInfo> Modules { get; }
        Task Initialized();
    }
}