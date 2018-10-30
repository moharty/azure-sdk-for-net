// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Incoming video stream out of synch event data.
    /// </summary>
    public partial class MediaLiveEventIncomingVideoStreamsOutOfSyncEventData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MediaLiveEventIncomingVideoStreamsOutOfSyncEventData class.
        /// </summary>
        public MediaLiveEventIncomingVideoStreamsOutOfSyncEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MediaLiveEventIncomingVideoStreamsOutOfSyncEventData class.
        /// </summary>
        /// <param name="firstTimestamp">Gets the first timestamp received for
        /// one of the quality levels.</param>
        /// <param name="firstDuration">Gets the duration of the data chunk
        /// with first timestamp.</param>
        /// <param name="secondTimestamp">Gets the timestamp received for some
        /// other quality levels.</param>
        /// <param name="secondDuration">Gets the duration of the data chunk
        /// with second timestamp.</param>
        /// <param name="timescale">Gets the timescale in which both the
        /// timestamps and durations are represented.</param>
        public MediaLiveEventIncomingVideoStreamsOutOfSyncEventData(string firstTimestamp = default(string), string firstDuration = default(string), string secondTimestamp = default(string), string secondDuration = default(string), string timescale = default(string))
        {
            FirstTimestamp = firstTimestamp;
            FirstDuration = firstDuration;
            SecondTimestamp = secondTimestamp;
            SecondDuration = secondDuration;
            Timescale = timescale;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the first timestamp received for one of the quality levels.
        /// </summary>
        [JsonProperty(PropertyName = "firstTimestamp")]
        public string FirstTimestamp { get; private set; }

        /// <summary>
        /// Gets the duration of the data chunk with first timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "firstDuration")]
        public string FirstDuration { get; private set; }

        /// <summary>
        /// Gets the timestamp received for some other quality levels.
        /// </summary>
        [JsonProperty(PropertyName = "secondTimestamp")]
        public string SecondTimestamp { get; private set; }

        /// <summary>
        /// Gets the duration of the data chunk with second timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "secondDuration")]
        public string SecondDuration { get; private set; }

        /// <summary>
        /// Gets the timescale in which both the timestamps and durations are
        /// represented.
        /// </summary>
        [JsonProperty(PropertyName = "timescale")]
        public string Timescale { get; private set; }

    }
}