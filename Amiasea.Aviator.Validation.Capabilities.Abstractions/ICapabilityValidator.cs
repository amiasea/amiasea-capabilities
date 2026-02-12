using System;
using System.Collections.Generic;
using System.Text;

namespace Amaiasea.Aviator.Validation.Capability.Abstractions;

public interface ICapabilityValidator<T>
{
    public bool Validate(T value);
    public string Name { get; }
}
