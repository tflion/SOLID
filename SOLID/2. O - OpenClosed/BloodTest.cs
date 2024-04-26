using System;

namespace SOLID.O;

public class BloodTest : HealthCheck
{
    public override string ApproveHealthCheckRequest() => "Blood test was approved!";

    public override bool VerifyHealthCheckCondition() => true;
}
