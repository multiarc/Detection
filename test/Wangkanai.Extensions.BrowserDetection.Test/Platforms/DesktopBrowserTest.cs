﻿// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.Extensions.BrowserDetection.Platforms;
using Xunit;

namespace Wangkanai.Extensions.BrowserDetection.Test.Platforms
{
    public class DesktopBrowserTest : DeviceBrowserTest
    {
        [Theory]
        [InlineData("Mozilla/5.0 (Windows NT x.y; rv:10.0) Gecko/20100101 Firefox/10.0")]
        [InlineData("Mozilla/5.0 (Windows NT x.y; Win64; x64; rv:10.0) Gecko/20100101 Firefox/10.0")]
        [InlineData("Mozilla/5.0 (Windows NT x.y; WOW64; rv:10.0) Gecko/20100101 Firefox/10.0")]
        [InlineData("Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/47.0.2526.111 Safari/537.36")]
        [InlineData("Mozilla/5.0 (Macintosh; Intel Mac OS X x.y; rv:10.0) Gecko/20100101 Firefox/10.0")]
        [InlineData("Mozilla/5.0 (Macintosh; PPC Mac OS X x.y; rv:10.0) Gecko/20100101 Firefox/10.0")]
        [InlineData("Mozilla/5.0 (X11; Linux i686; rv:10.0) Gecko/20100101 Firefox/10.0")]
        [InlineData("Mozilla/5.0 (X11; Linux x86_64; rv:10.0) Gecko/20100101 Firefox/10.0")]
        public void Keyword(string agent)
        {
            // arrange 
            var request = CreateRequest(agent);
            // act
            var device = new DeviceResolver(request).DeviceInfo;
            // assert
            Assert.Equal(DeviceTypes.Desktop, device.Device);
        }
    }
}