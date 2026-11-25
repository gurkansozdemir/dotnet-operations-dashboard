public sealed record DemoMetric(string Name, long Value);

public static class DashboardSummary
{
    public static long Total(IEnumerable<DemoMetric> metrics) => metrics.Sum(item => item.Value);
}
