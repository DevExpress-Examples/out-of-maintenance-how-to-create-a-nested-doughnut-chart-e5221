using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraCharts;

namespace NestedDoughnut {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl NestedDoughnutChart = new ChartControl();

            // Add the chart to the form.
            NestedDoughnutChart.Dock = DockStyle.Fill;
            this.Controls.Add(NestedDoughnutChart);

            // Create a first nested doughnut series.
            Series series1 = new Series("Male", ViewType.NestedDoughnut);

            // Populate the series with points.
            series1.Points.Add(new SeriesPoint("0-14 years", 29.956));
            series1.Points.Add(new SeriesPoint("15-64 years", 25.607));
            series1.Points.Add(new SeriesPoint("65 years and older", 13.493));

            // Add the first series to the chart.
            NestedDoughnutChart.Series.Add(series1);

            // Create a second nested doughnut series.
            Series series2 = new Series("Female", ViewType.NestedDoughnut);

            // Populate the series with points.
            series2.Points.Add(new SeriesPoint("0-14 years", 90.354));
            series2.Points.Add(new SeriesPoint("15-64 years", 55.793));
            series2.Points.Add(new SeriesPoint("65 years and older", 48.983));

            // Add the second series to the chart.
            NestedDoughnutChart.Series.Add(series2);

            // Specify the hole radius percentage and inner indent of the nested doughnut.
            ((NestedDoughnutSeriesView)series1.View).InnerIndent = 8;
            ((NestedDoughnutSeriesView)series1.View).HoleRadiusPercent = 30;

            // Specify the legend text pattern for the first series.
            series1.LegendTextPattern = "{A}";

            // Hide a legend for the second series.
            series2.ShowInLegend = false;

            // Enable a tooltip and specify the tooltip point pattern for series. 
            NestedDoughnutChart.ToolTipEnabled = DefaultBoolean.True;
            series1.ToolTipPointPattern = "{S}:{VP:##.##%}";
            series2.ToolTipPointPattern = "{S}:{VP:##.##%}";

            // Hide series labels.
            series1.LabelsVisibility = DefaultBoolean.False;
            series2.LabelsVisibility = DefaultBoolean.False;

            // Add a title to the chart.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "Nested Doughnut Chart";
            NestedDoughnutChart.Titles.Add(chartTitle1);
        }
    }
}
