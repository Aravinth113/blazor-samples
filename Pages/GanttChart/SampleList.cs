﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {

        public List<Sample> GanttChart { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/default-functionalities",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Default",
                        FileName="DefaultFunctionalities.razor"
                    },
                    new SourceCollection
                    {
                        Id="DefaultRecord",
                        FileName="DefaultData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/remote-data",
                FileName="RemoteData.razor",
                Type = SampleType.None,
            },
              new Sample
            {
                Name = "Editing",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/editing",
               Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Editing",
                        FileName="Editing.razor"
                    },
                    new SourceCollection
                    {
                        Id="EditData",
                        FileName="GanttData.cs"
                    }
                }
            },
             new Sample
            {
                Name = "Baseline",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/baseline",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Baseline",
                        FileName="Baseline.razor"
                    },
                    new SourceCollection
                    {
                        Id="BaseRecord",
                        FileName="BaseData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Taskbar Template",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/taskbar-template",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TaskbarTemplate",
                        FileName="GanttTaskbarTemplate.razor"
                    },
                    new SourceCollection
                    {
                        Id="TaskbarRecord",
                        FileName="TaskbarTemplateData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Filtering",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/filtering",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Filtering",
                         FileName = "Filtering.razor",
                    },
                    new SourceCollection
                    {
                        Id="Filter",
                        FileName="FilterData.cs"
                    }
                }
            },

            new Sample
            {
                Name = "Context Menu",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/context-menu",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ContextMenu",
                        FileName = "ContextMenu.razor",
                    },
                    new SourceCollection
                    {
                        Id="ContextMenuData",
                        FileName="GanttData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Unscheduled Task",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/unscheduled-task",
               Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Unscheduled",
                        FileName = "UnscheduledTask.razor",
                    },
                    new SourceCollection
                    {
                        Id="UnscheduledData",
                        FileName="UnscheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Timeline",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/timeline",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="TimeTask",
                        FileName = "Timeline.razor",
                    },
                    new SourceCollection
                    {
                        Id="TimeRecord",
                        FileName="TimelineData.cs"
                    }
                }
            },
        
            new Sample
            {
                Name = "Selection",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/selection",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Schedule",
                        FileName="Selection.razor"
                    },
                    new SourceCollection
                    {
                        Id="SelectionRecord",
                        FileName="SelectionData.cs"
                    }
                }
            },
              new Sample
            {
                Name = "Scheduling Mode",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/scheduling-mode",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Schedule",
                        FileName="Schedulingmode.razor"
                    },
                    new SourceCollection
                    {
                        Id="ScheduleRecord",
                        FileName="ScheduleData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Event Markers",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/eventmarkers",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Events",
                        FileName="EventMarkers.razor"
                    },
                    new SourceCollection
                    {
                        Id="EventRecord",
                        FileName="EventData.cs"
                    }
                }
            },
            new Sample
            {
                Name = "Resource Allocation",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/resource-allocation",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Resource",
                        FileName="Resourceallocation.razor"
                    },
                    new SourceCollection
                    {
                        Id="ResourceRecord",
                        FileName="ResourceData.cs"
                    }
                }
            },
              new Sample
            {
                Name = "Work Week",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/work-week",
                Type = SampleType.New,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Resource",
                        FileName="WorkWeek.razor"
                    },
                    new SourceCollection
                    {
                        Id="ResourceRecord",
                        FileName="WorkData.cs"
                    }
                }
            },
              new Sample
            {
                Name = "Zooming",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/zooming",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="Zoom",
                        FileName = "Zooming.razor",
                    },
                    new SourceCollection
                    {
                        Id="ZoomRecord",
                        FileName="ZoomingData.cs"
                    }
                }
            },
                  new Sample
            {
                Name = "Exporting",
                Category = "Gantt Chart",
                Directory = "GanttChart/GanttChart",
                Url = "gantt-chart/exporting",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id="ExportTask",
                        FileName = "Exporting.razor",
                    },
                    new SourceCollection
                    {
                        Id="ExportRecord",
                        FileName="GanttData.cs"
                    }
                }
            }

        };
    }
}
