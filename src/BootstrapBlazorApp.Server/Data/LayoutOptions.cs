using BootstrapBlazor.Components;

namespace BootstrapBlazorApp.Server.Data
{
    public class LayoutOptions
    {
        public bool FixedHeader { get; set; } = true;
        public bool ShowSide { get; set; } = true;
        public bool FullSide { get; set; }
        public bool ShowFooter { get; set; } = true;
        public bool FixedFooter { get; set; } = true;
        public bool UseTabSet { get; set; } = true;
        public bool FixedTab { get; set; } = true;
        public TabStyle TabStyle { get; set; } = TabStyle.Chrome;
        public bool ShowTabInHeader { get; set; }
        public bool TabShowCloseButton { get; set; } = true;
        public bool ShowTabRightClickMenu { get; set; } = true;
        public bool ShowTabExtendButtons { get; set; }
        public bool TabShowToolbar { get; set; } = true;
        public bool Accordion { get; set; } = true;
        public string? Theme { get; set; } = "color6";//可以默认""
        public int Pages { get; set; } = 20;
    }
}
