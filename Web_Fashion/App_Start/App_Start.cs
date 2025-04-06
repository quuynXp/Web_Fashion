//// -----------------------------------------------------------------------
//// <copyright file="App_Start.cs" company="Fluent.Infrastructure">
////     Copyright © Fluent.Infrastructure. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
/// See more at: https://github.com/dn32/Fluent.Infrastructure/wiki
////-----------------------------------------------------------------------

using Fluent.Infrastructure.FluentTools;
using Web_Fashion.Models;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Web_Fashion.App_Start), "PreStart")]

namespace Web_Fashion {
    public static class App_Start {
        public static void PreStart() {
            FluentStartup.Initialize(typeof(Fashion_ShopDbContext));
        }
    }
}