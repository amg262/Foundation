using Foundation.Features.Folder;

namespace Foundation.Features.Events.CalendarBlock
{
    [ContentType(GUID = "D5148C01-DFB0-4E57-8399-6CEEBF48F38E",
        DisplayName = "Calendar Block",
        Description = "A block that lists a bunch of calendar events",
        GroupName = GroupNames.Calendar)]
    [ImageUrl("/icons/cms/pages/calendar.png")]
    public class CalendarBlock : FoundationBlockData
    {
        [Required]
        [CultureSpecific]
        [SelectOne(SelectionFactoryType = typeof(CalendarViewModeSelectionFactory))]
        [Display(Name = "View as", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string ViewMode { get; set; }

        [Required]
        [AllowedTypes(typeof(FolderPage))]
        [Display(Name = "Events root", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual PageReference EventsRoot { get; set; }

        [Display(Name = "Number of events", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual int Count { get; set; }

        [Display(Name = "Filter by category", GroupName = SystemTabNames.Content, Order = 40)]
        public virtual CategoryList CategoryFilter { get; set; }

        [Display(Name = "Include all levels", GroupName = SystemTabNames.Content, Order = 50)]
        public virtual bool Recursive { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            Count = 5;
            ViewMode = "dayGridMonth";
        }
    }
}