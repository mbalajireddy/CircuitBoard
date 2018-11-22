
namespace MeraCircuitBoard
{
    // Common interface for items that can be selected
    // on the DesignerCanvas; used by CircuitPart and Connection
    public interface ISelectable
    {
        bool IsSelected { get; set; }
    }
}
