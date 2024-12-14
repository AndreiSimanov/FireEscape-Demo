namespace FireEscape.Reports.Interfaces;

public interface IProtocolReportDataProvider
{
    void Init(Order order, Protocol protocol); 
    string FontName { get; }
    float FontSize { get; }
}