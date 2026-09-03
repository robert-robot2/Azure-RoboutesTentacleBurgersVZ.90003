namespace RoboutesTentacleBurgers.Pages
{
    public partial class SteamElectrical
    {


        // ============================================================
        // PHASE REGISTRY — add one entry per new phase
        // ============================================================
        private record PhaseEntry(string Id, string Label, string Name);

        private readonly List<PhaseEntry> _phases = new()
    {
        new("phase1", "Phase 1", "Steam-Electric Concept"),
                             new ("phase24", "Phase 24", "Chevy Miasma V8"),
    }; 

        private string _activeId = "phase1";

        private void SetPhase(string id) => _activeId = id;

        private void ScrollTabsLeft() => JS.InvokeVoidAsync("seScrollTabs", -1);
        private void ScrollTabsRight() => JS.InvokeVoidAsync("seScrollTabs", 1);

        [Inject] private IJSRuntime JS { get; set; } = default!;

        public void Dispose() { }

    }










}
