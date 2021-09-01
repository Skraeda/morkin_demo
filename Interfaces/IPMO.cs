namespace PMO.Interfaces
{
    public interface IPMO
    {
        IPatients Patients { get; }

        IRelatives Relatives { get; }
    }
}
