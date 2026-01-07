using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Nps.Core;
using Nps.Models.ThingsTodo;

namespace Nps.Services;

/// <summary>
/// NOTE: Do not inherit from this type outside the SDK unless you're okay with breaking
/// changes in non-major versions. We may add new methods in the future that cause
/// existing derived classes to break.
/// </summary>
public interface IThingsTodoService
{
    /// <summary>
    /// Returns a view of this service with the given option modifications applied.
    ///
    /// <para>The original service is not modified.</para>
    /// </summary>
    IThingsTodoService WithOptions(Func<ClientOptions, ClientOptions> modifier);

    Task<List<ThingsTodoListResponse>> List(
        ThingsTodoListParams? parameters = null,
        CancellationToken cancellationToken = default
    );
}
