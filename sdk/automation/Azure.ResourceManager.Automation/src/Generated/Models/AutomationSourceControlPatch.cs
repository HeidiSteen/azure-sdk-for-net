// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the update source control operation. </summary>
    public partial class AutomationSourceControlPatch
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

        /// <summary> Initializes a new instance of <see cref="AutomationSourceControlPatch"/>. </summary>
        public AutomationSourceControlPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationSourceControlPatch"/>. </summary>
        /// <param name="branch"> The repo branch of the source control. </param>
        /// <param name="folderPath"> The folder path of the source control. Path must be relative. </param>
        /// <param name="isAutoSyncEnabled"> The auto sync of the source control. Default is false. </param>
        /// <param name="isAutoPublishRunbookEnabled"> The auto publish of the source control. Default is true. </param>
        /// <param name="securityToken"> The authorization token for the repo of the source control. </param>
        /// <param name="description"> The user description of the source control. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationSourceControlPatch(string branch, string folderPath, bool? isAutoSyncEnabled, bool? isAutoPublishRunbookEnabled, SourceControlSecurityTokenProperties securityToken, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Branch = branch;
            FolderPath = folderPath;
            IsAutoSyncEnabled = isAutoSyncEnabled;
            IsAutoPublishRunbookEnabled = isAutoPublishRunbookEnabled;
            SecurityToken = securityToken;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The repo branch of the source control. </summary>
        public string Branch { get; set; }
        /// <summary> The folder path of the source control. Path must be relative. </summary>
        public string FolderPath { get; set; }
        /// <summary> The auto sync of the source control. Default is false. </summary>
        public bool? IsAutoSyncEnabled { get; set; }
        /// <summary> The auto publish of the source control. Default is true. </summary>
        public bool? IsAutoPublishRunbookEnabled { get; set; }
        /// <summary> The authorization token for the repo of the source control. </summary>
        public SourceControlSecurityTokenProperties SecurityToken { get; set; }
        /// <summary> The user description of the source control. </summary>
        public string Description { get; set; }
    }
}
