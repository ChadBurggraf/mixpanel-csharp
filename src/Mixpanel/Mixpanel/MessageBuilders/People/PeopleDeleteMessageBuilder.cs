﻿using System;
using System.Collections.Generic;
using Mixpanel.MessageProperties;
using static System.String;

namespace Mixpanel.MessageBuilders.People
{
    // Message example:
    // {
    //     "$token": "36ada5b10da39a1347559321baf13063",
    //     "$distinct_id": "13793",
    //     "$delete": ""
    // }

    internal static class PeopleDeleteMessageBuilder 
    {
        public static MessageBuildResult Build(
            string token,
            IEnumerable<ObjectProperty> superProperties,
            object distinctId,
            MixpanelConfig config)
        {
            MessageBuildResult messageBuildResult = PeopleMessageBuilderBase.CreateMessage(
                token,
                superProperties,
                null,
                distinctId,
                config,
                "$delete",
                rawValue => throw new InvalidOperationException());

            if (!messageBuildResult.Success)
            {
                return messageBuildResult;
            }

            messageBuildResult.Message["$delete"] = Empty;
            return messageBuildResult;
        }
    }
}