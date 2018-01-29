// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The classification details of the text.
    /// </summary>
    public partial class Classification
    {
        /// <summary>
        /// Initializes a new instance of the Classification class.
        /// </summary>
        public Classification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Classification class.
        /// </summary>
        /// <param name="adultScore">The adult score.</param>
        /// <param name="racyScore">The racy score.</param>
        /// <param name="offensiveScore">The offensive score.</param>
        /// <param name="reviewRecommended">The review recommended
        /// flag.</param>
        public Classification(double? adultScore = default(double?), double? racyScore = default(double?), double? offensiveScore = default(double?), bool? reviewRecommended = default(bool?))
        {
            AdultScore = adultScore;
            RacyScore = racyScore;
            OffensiveScore = offensiveScore;
            ReviewRecommended = reviewRecommended;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the adult score.
        /// </summary>
        [JsonProperty(PropertyName = "AdultScore")]
        public double? AdultScore { get; set; }

        /// <summary>
        /// Gets or sets the racy score.
        /// </summary>
        [JsonProperty(PropertyName = "RacyScore")]
        public double? RacyScore { get; set; }

        /// <summary>
        /// Gets or sets the offensive score.
        /// </summary>
        [JsonProperty(PropertyName = "OffensiveScore")]
        public double? OffensiveScore { get; set; }

        /// <summary>
        /// Gets or sets the review recommended flag.
        /// </summary>
        [JsonProperty(PropertyName = "ReviewRecommended")]
        public bool? ReviewRecommended { get; set; }

    }
}