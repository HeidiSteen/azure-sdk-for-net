// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Additional information on the backed up item. </summary>
    public partial class MabFileFolderProtectedItemExtendedInfo
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

        /// <summary> Initializes a new instance of <see cref="MabFileFolderProtectedItemExtendedInfo"/>. </summary>
        public MabFileFolderProtectedItemExtendedInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MabFileFolderProtectedItemExtendedInfo"/>. </summary>
        /// <param name="lastRefreshedOn"> Last time when the agent data synced to service. </param>
        /// <param name="oldestRecoverOn"> The oldest backup copy available. </param>
        /// <param name="recoveryPointCount"> Number of backup copies associated with the backup item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MabFileFolderProtectedItemExtendedInfo(DateTimeOffset? lastRefreshedOn, DateTimeOffset? oldestRecoverOn, int? recoveryPointCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LastRefreshedOn = lastRefreshedOn;
            OldestRecoverOn = oldestRecoverOn;
            RecoveryPointCount = recoveryPointCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Last time when the agent data synced to service. </summary>
        public DateTimeOffset? LastRefreshedOn { get; set; }
        /// <summary> The oldest backup copy available. </summary>
        public DateTimeOffset? OldestRecoverOn { get; set; }
        /// <summary> Number of backup copies associated with the backup item. </summary>
        public int? RecoveryPointCount { get; set; }
    }
}
