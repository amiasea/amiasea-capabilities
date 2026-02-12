using Amaiasea.Aviator.Validation.Capability.Abstractions;

namespace Amiasea.Aviator.Validation.Capability.Test;

public class TerraformProviderSigner : ICapabilityValidator<TerraformProviderSignerOptions>
{
    public string Name { get; init; } = "TerraformProviderSigner";

    public bool Validate(TerraformProviderSignerOptions value)
    {
        // Implement validation logic here
        return true;
    }
}
