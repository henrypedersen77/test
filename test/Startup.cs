﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(test.Startup))]

namespace test
{
    public partial class Startup
    {
        //En kommentart

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
