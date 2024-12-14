using FireEscape.Reports.Interfaces;
using Microsoft.Extensions.Options;

namespace FireEscape.Reports.ReportDataProviders;

public class ProtocolReportDataProvider(IStairsRepository stairsRepository, IOptions<StairsSettings> stairsSettings, IOptions<ReportSettings> reportSettings) : IProtocolReportDataProvider
{
    readonly ReportSettings reportSettings = reportSettings.Value;

    public void Init(Order order, Protocol protocol)
    {
    }
    public string FontName => reportSettings.FontName;
    public float FontSize => reportSettings.FontSize;
}
