// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationResponseFinishedUpdate : IJsonModel<ConversationResponseFinishedUpdate>
    {
        void IJsonModel<ConversationResponseFinishedUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationResponseFinishedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationResponseFinishedUpdate)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("response") != true)
            {
                writer.WritePropertyName("response"u8);
                writer.WriteObjectValue<InternalRealtimeResponse>(_internalResponse, options);
            }
            if (SerializedAdditionalRawData?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Kind.ToSerialString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("event_id") != true)
            {
                writer.WritePropertyName("event_id"u8);
                writer.WriteStringValue(EventId);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ConversationResponseFinishedUpdate IJsonModel<ConversationResponseFinishedUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationResponseFinishedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationResponseFinishedUpdate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationResponseFinishedUpdate(document.RootElement, options);
        }

        internal static ConversationResponseFinishedUpdate DeserializeConversationResponseFinishedUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalRealtimeResponse response = default;
            ConversationUpdateKind type = default;
            string eventId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("response"u8))
                {
                    response = InternalRealtimeResponse.DeserializeInternalRealtimeResponse(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToConversationUpdateKind();
                    continue;
                }
                if (property.NameEquals("event_id"u8))
                {
                    eventId = property.Value.GetString();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConversationResponseFinishedUpdate(type, eventId, serializedAdditionalRawData, response);
        }

        BinaryData IPersistableModel<ConversationResponseFinishedUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationResponseFinishedUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationResponseFinishedUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationResponseFinishedUpdate IPersistableModel<ConversationResponseFinishedUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationResponseFinishedUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConversationResponseFinishedUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationResponseFinishedUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationResponseFinishedUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static new ConversationResponseFinishedUpdate FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeConversationResponseFinishedUpdate(document.RootElement);
        }

        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}