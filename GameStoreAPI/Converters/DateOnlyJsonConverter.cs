using System.Text.Json;
using System.Text.Json.Serialization;

namespace GameStoreAPI.Converters;
public class DateOnlyJsonConverter : JsonConverter<DateOnly>
{
    private const string DateFormat = "yyyy-MM-dd";

    public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Read the JSON value as a string and parse it into a DateOnly object
        return DateOnly.ParseExact(reader.GetString()!, DateFormat);
    }

    public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
    {
        // Write the DateOnly value as a string in the specified format
        writer.WriteStringValue(value.ToString(DateFormat));
    }
}