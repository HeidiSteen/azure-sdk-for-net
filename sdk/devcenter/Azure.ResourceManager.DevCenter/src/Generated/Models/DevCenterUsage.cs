// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The core usage details. </summary>
    public partial class DevCenterUsage
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DevCenterUsage"/>. </summary>
        internal DevCenterUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterUsage"/>. </summary>
        /// <param name="currentValue"> The current usage. </param>
        /// <param name="limit"> The limit integer. </param>
        /// <param name="unit"> The unit details. </param>
        /// <param name="name"> The name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevCenterUsage(long? currentValue, long? limit, DevCenterUsageUnit? unit, DevCenterUsageName name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CurrentValue = currentValue;
            Limit = limit;
            Unit = unit;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The current usage. </summary>
        public long? CurrentValue { get; }
        /// <summary> The limit integer. </summary>
        public long? Limit { get; }
        /// <summary> The unit details. </summary>
        public DevCenterUsageUnit? Unit { get; }
        /// <summary> The name. </summary>
        public DevCenterUsageName Name { get; }
    }
}
