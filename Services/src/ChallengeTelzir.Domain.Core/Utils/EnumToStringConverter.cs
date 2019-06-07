using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChallengeTelzir.Domain.Core.Utils
{
    public class EnumToStringConverter : JsonConverter
    {
        public override bool CanRead { get; } = true;

        public override bool CanWrite { get; } = true;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null) return;
            var newValue = FunctionEnum.GetEnumDescription((Enum)value);
            JToken.FromObject(newValue).WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader == null ? null : FunctionEnum.GetEnumDescription((Enum)reader.Value);
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}