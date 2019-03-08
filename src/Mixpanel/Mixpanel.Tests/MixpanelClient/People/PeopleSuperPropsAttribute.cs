﻿using System;
using NUnit.Framework;

namespace Mixpanel.Tests.MixpanelClient.People
{
    [AttributeUsage(AttributeTargets.Method)]
    public class PeopleSuperPropsAttribute : PropertyAttribute
    {
        public const string Name = "PeopleSuperProps";

        public PeopleSuperPropsAttribute(PeopleSuperPropsDetails details)
            : base(details)
        {
        }
    }
}