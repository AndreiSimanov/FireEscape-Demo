using FireEscape.Reports.Interfaces;
using FireEscape.Reports.ReportWriters;
using iText.Layout.Element;
using TextAlignment = iText.Layout.Properties.TextAlignment;

namespace FireEscape.Reports.ReportMakers;

public class ProtocolPdfReportMaker(IProtocolReportDataProvider protocolRdp) : IProtocolPdfReportMaker
{
    public async Task CreateReportAsync(Order order, Protocol protocol, string outputPath)
    {
        var document = await PdfReportWriter.CreatePdfDocumentAsync(outputPath, protocolRdp.FontName, protocolRdp.FontSize);
        protocolRdp.Init(order, protocol);
        try
        {
            document.Add(new Paragraph($"ПРОТОКОЛ № DEMO")
                .SetFixedLeading(5)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBold()
                .SetFirstLineIndent(0));
        }
        finally
        {
            document.Close();
        }
    }
}