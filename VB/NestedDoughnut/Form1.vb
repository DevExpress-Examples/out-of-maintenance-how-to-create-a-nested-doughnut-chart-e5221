Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraCharts

Namespace NestedDoughnut
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a new chart.
			Dim NestedDoughnutChart As New ChartControl()

			' Add the chart to the form.
			NestedDoughnutChart.Dock = DockStyle.Fill
			Me.Controls.Add(NestedDoughnutChart)

			' Create a first nested doughnut series.
			Dim series1 As New Series("Male", ViewType.NestedDoughnut)

			' Populate the series with points.
			series1.Points.Add(New SeriesPoint("0-14 years", 29.956))
			series1.Points.Add(New SeriesPoint("15-64 years", 25.607))
			series1.Points.Add(New SeriesPoint("65 years and older", 13.493))

			' Add the first series to the chart.
			NestedDoughnutChart.Series.Add(series1)

			' Create a second nested doughnut series.
			Dim series2 As New Series("Female", ViewType.NestedDoughnut)

			' Populate the series with points.
			series2.Points.Add(New SeriesPoint("0-14 years", 90.354))
			series2.Points.Add(New SeriesPoint("15-64 years", 55.793))
			series2.Points.Add(New SeriesPoint("65 years and older", 48.983))

			' Add the second series to the chart.
			NestedDoughnutChart.Series.Add(series2)

			' Specify the hole radius percentage and inner indent of the nested doughnut.
			CType(series1.View, NestedDoughnutSeriesView).InnerIndent = 8
			CType(series1.View, NestedDoughnutSeriesView).HoleRadiusPercent = 30

			' Specify the legend text pattern for the first series.
			series1.LegendTextPattern = "{A}"

			' Hide a legend for the second series.
			series2.ShowInLegend = False

			' Enable a tooltip and specify the tooltip point pattern for series. 
			NestedDoughnutChart.ToolTipEnabled = DefaultBoolean.True
			series1.ToolTipPointPattern = "{S}:{VP:##.##%}"
			series2.ToolTipPointPattern = "{S}:{VP:##.##%}"

			' Hide series labels.
			series1.LabelsVisibility = DefaultBoolean.False
			series2.LabelsVisibility = DefaultBoolean.False

			' Add a title to the chart.
			Dim chartTitle1 As New ChartTitle()
			chartTitle1.Text = "Nested Doughnut Chart"
			NestedDoughnutChart.Titles.Add(chartTitle1)
		End Sub
	End Class
End Namespace
