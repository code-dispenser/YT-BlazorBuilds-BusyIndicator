using Eventor.Core.Common.Seeds;

namespace BlazorBuilds.Components;


/*
     * You can add whatever properties you like but we only need two additional ones for our component,
     * One to show hide it and the other for screen readers.
*/ 

public class SetBusyIndicatorEvent(string senderName, bool showLoader = false, string? busyText = "", string? arialLiveText = "") : EventBase(senderName)
{
    public bool    ShowLoader   { get; set; } = showLoader;
    public string  AriaLiveText { get; set; } = String.IsNullOrWhiteSpace(arialLiveText) ? String.Empty : arialLiveText.Trim();
    public string  BusyText     { get; set; } = String.IsNullOrWhiteSpace(busyText) ? String.Empty : busyText.Trim();
}
