namespace SOLID.O;
public abstract class HealthCheck
{
    public abstract string ApproveHealthCheckRequest();
    public abstract bool VerifyHealthCheckCondition();
}


