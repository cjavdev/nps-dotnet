using System.Text.Json;
using Nps.Exceptions;
using Nps.Models.Alerts;
using Nps.Models.Campgrounds;
using Nps.Models.Feespasses;
using ParkingLots = Nps.Models.ParkingLots;
using Parks = Nps.Models.Parks;
using VisitorCenters = Nps.Models.VisitorCenters;

namespace Nps.Core;

/// <summary>
/// The base class for all API objects with properties.
///
/// <para>API objects such as enums and unions do not inherit from this class.</para>
/// </summary>
public abstract record class ModelBase
{
    protected ModelBase(ModelBase modelBase)
    {
        // Nothing to copy. Just so that subclasses can define copy constructors.
    }

    internal static readonly JsonSerializerOptions SerializerOptions = new()
    {
        Converters =
        {
            new ApiEnumConverter<string, Category>(),
            new ApiEnumConverter<string, Type>(),
            new ApiEnumConverter<string, PhoneNumberType>(),
            new ApiEnumConverter<string, ContentOrderOrdinals>(),
            new ApiEnumConverter<string, ParkingLots::Type>(),
            new ApiEnumConverter<string, Parks::Type>(),
            new ApiEnumConverter<string, Parks::PhoneNumberType>(),
            new ApiEnumConverter<string, VisitorCenters::Type>(),
        },
    };

    private protected static readonly JsonSerializerOptions ToStringSerializerOptions = new(
        SerializerOptions
    )
    {
        WriteIndented = true,
    };

    /// <summary>
    /// Validates that all required fields are set and that each field's value is of the expected type.
    ///
    /// <para>This is useful for instances constructed from raw JSON data (e.g. deserialized from an API response).</para>
    ///
    /// <exception cref="NpsInvalidDataException">
    /// Thrown when the instance does not pass validation.
    /// </exception>
    /// </summary>
    public abstract void Validate();
}
