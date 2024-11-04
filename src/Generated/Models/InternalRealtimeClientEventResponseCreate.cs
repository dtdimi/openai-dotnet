// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeClientEventResponseCreate : InternalRealtimeClientEvent
    {
        public InternalRealtimeClientEventResponseCreate(InternalRealtimeClientEventResponseCreateResponse response)
        {
            Argument.AssertNotNull(response, nameof(response));

            Kind = InternalRealtimeClientEventType.ResponseCreate;
            Response = response;
        }

        internal InternalRealtimeClientEventResponseCreate(InternalRealtimeClientEventType kind, string eventId, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalRealtimeClientEventResponseCreateResponse response) : base(kind, eventId, serializedAdditionalRawData)
        {
            Response = response;
        }

        internal InternalRealtimeClientEventResponseCreate()
        {
        }

        public InternalRealtimeClientEventResponseCreateResponse Response { get; }
    }
}