using FluentAssertions;
using NeoMoto.Api.Services;

namespace NeoMoto.Tests;

public class MaintenanceCostEstimatorTests
{
    [Fact]
    public void Predict_should_be_reasonable_for_known_pattern()
    {
        using var svc = new MaintenanceCostEstimator();
        // Expected by synthetic rule: 50 + 10*age + 0.5*days + factor(1)=40
        var features = new MaintenanceFeatures { AgeYears = 3, DaysSinceLastService = 60, ServiceType = 1 };
        var predicted = svc.Predict(features);
        // Ideal target = 50 + 30 + 30 + 40 = 150
        predicted.Should().BeInRange(140f, 160f);
    }
}
