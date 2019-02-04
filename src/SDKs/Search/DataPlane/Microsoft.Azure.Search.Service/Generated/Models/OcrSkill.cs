// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A skill that extracts text from image files.
    /// <see
    /// href="https://docs.microsoft.com/azure/search/cognitive-search-skill-ocr"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Skills.Vision.OcrSkill")]
    public partial class OcrSkill : Skill
    {
        /// <summary>
        /// Initializes a new instance of the OcrSkill class.
        /// </summary>
        public OcrSkill()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OcrSkill class.
        /// </summary>
        /// <param name="description">The description of the skill which
        /// describes the inputs, outputs, and usage of the skill.</param>
        /// <param name="context">Represents the level at which operations take
        /// place, such as the document root or document content (for example,
        /// /document or /document/content).</param>
        /// <param name="inputs">Inputs of the skills could be a column in the
        /// source data set, or the output of an upstream skill.</param>
        /// <param name="outputs">The output of a skill is either a field in an
        /// Azure Search index, or a value that can be consumed as an input by
        /// another skill.</param>
        /// <param name="textExtractionAlgorithm">A value indicating which
        /// algorithm to use for extracting text. Default is printed. Possible
        /// values include: 'printed', 'handwritten'</param>
        /// <param name="defaultLanguageCode">A value indicating which language
        /// code to use. Default is en.</param>
        /// <param name="shouldDetectOrientation">A value indicating to turn
        /// orientation detection on or not. Default is false.</param>
        public OcrSkill(string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, TextExtractionAlgorithm? textExtractionAlgorithm = default(TextExtractionAlgorithm?), OcrSkillLanguage defaultLanguageCode = default(OcrSkillLanguage), bool? shouldDetectOrientation = default(bool?))
            : base(description, context, inputs, outputs)
        {
            TextExtractionAlgorithm = textExtractionAlgorithm;
            DefaultLanguageCode = defaultLanguageCode;
            ShouldDetectOrientation = shouldDetectOrientation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating which algorithm to use for
        /// extracting text. Default is printed. Possible values include:
        /// 'printed', 'handwritten'
        /// </summary>
        [JsonProperty(PropertyName = "textExtractionAlgorithm")]
        public TextExtractionAlgorithm? TextExtractionAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets a value indicating which language code to use. Default
        /// is en.
        /// </summary>
        [JsonProperty(PropertyName = "defaultLanguageCode")]
        public OcrSkillLanguage DefaultLanguageCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating to turn orientation detection on or
        /// not. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "detectOrientation")]
        public bool? ShouldDetectOrientation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}