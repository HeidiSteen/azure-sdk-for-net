// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> RemoteApplicationType for which remote support settings is being modified. </summary>
    public partial class EdgeRemoteSupportSettings
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

        /// <summary> Initializes a new instance of <see cref="EdgeRemoteSupportSettings"/>. </summary>
        public EdgeRemoteSupportSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EdgeRemoteSupportSettings"/>. </summary>
        /// <param name="remoteApplicationType"> Remote application type. </param>
        /// <param name="accessLevel"> Access level allowed for this remote application type. </param>
        /// <param name="expireOn"> Expiration time stamp. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeRemoteSupportSettings(EdgeRemoteApplicationType? remoteApplicationType, EdgeRemoteApplicationAccessLevel? accessLevel, DateTimeOffset? expireOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RemoteApplicationType = remoteApplicationType;
            AccessLevel = accessLevel;
            ExpireOn = expireOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Remote application type. </summary>
        public EdgeRemoteApplicationType? RemoteApplicationType { get; set; }
        /// <summary> Access level allowed for this remote application type. </summary>
        public EdgeRemoteApplicationAccessLevel? AccessLevel { get; set; }
        /// <summary> Expiration time stamp. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
    }
}
