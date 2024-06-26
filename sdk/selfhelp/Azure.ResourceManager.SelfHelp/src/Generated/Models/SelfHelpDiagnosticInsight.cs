// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Detailed insights(s) obtained via the invocation of an insight diagnostic. </summary>
    public partial class SelfHelpDiagnosticInsight
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

        /// <summary> Initializes a new instance of <see cref="SelfHelpDiagnosticInsight"/>. </summary>
        public SelfHelpDiagnosticInsight()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SelfHelpDiagnosticInsight"/>. </summary>
        /// <param name="id"> Article id. </param>
        /// <param name="title"> This insight's title. </param>
        /// <param name="results"> Detailed result content. </param>
        /// <param name="insightImportanceLevel"> Importance level of the insight. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SelfHelpDiagnosticInsight(string id, string title, string results, SelfHelpImportanceLevel? insightImportanceLevel, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Title = title;
            Results = results;
            InsightImportanceLevel = insightImportanceLevel;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Article id. </summary>
        public string Id { get; set; }
        /// <summary> This insight's title. </summary>
        public string Title { get; set; }
        /// <summary> Detailed result content. </summary>
        public string Results { get; set; }
        /// <summary> Importance level of the insight. </summary>
        public SelfHelpImportanceLevel? InsightImportanceLevel { get; set; }
    }
}
