// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeClientEventConversationItemTruncate : InternalRealtimeClientEvent
    {
        public InternalRealtimeClientEventConversationItemTruncate(string itemId, int contentIndex, int audioEndMs)
        {
            Argument.AssertNotNull(itemId, nameof(itemId));

            Kind = InternalRealtimeClientEventType.ConversationItemTruncate;
            ItemId = itemId;
            ContentIndex = contentIndex;
            AudioEndMs = audioEndMs;
        }

        internal InternalRealtimeClientEventConversationItemTruncate(InternalRealtimeClientEventType kind, string eventId, IDictionary<string, BinaryData> serializedAdditionalRawData, string itemId, int contentIndex, int audioEndMs) : base(kind, eventId, serializedAdditionalRawData)
        {
            ItemId = itemId;
            ContentIndex = contentIndex;
            AudioEndMs = audioEndMs;
        }

        internal InternalRealtimeClientEventConversationItemTruncate()
        {
        }

        public string ItemId { get; }
        public int ContentIndex { get; }
        public int AudioEndMs { get; }
    }
}