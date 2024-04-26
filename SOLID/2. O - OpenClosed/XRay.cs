namespace SOLID.O;

public class XRay : HealthCheck
{
    public override string ApproveHealthCheckRequest() => "X-Ray was reproved!";

    public override bool VerifyHealthCheckCondition() => false;
}
